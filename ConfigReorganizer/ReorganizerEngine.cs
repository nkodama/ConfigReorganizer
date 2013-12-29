using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConfigReorganizer
{
    /// <summary>
    /// 再構成エンジン
    /// </summary>
    internal class ReorganizerEngine
    {
        /// <summary>
        /// メインフォームへの参照
        /// </summary>
        private readonly MainForm mainForm;

        /// <summary>
        /// 文字列変換テーブル
        /// </summary>
        private Dictionary<string, string> convertTable;

        /// <summary>
        /// 対象フォルダの文字列が日本語か英語か
        ///   true:  日本語 CP932
        ///   false: 英語   CP1252
        /// </summary>
        public bool IsTargetJapanese { get; set; }

        /// <summary>
        /// 参照フォルダの文字列が日本語化英語か
        ///   true:  日本語 CP932
        ///   false: 英語   CP1252
        /// </summary>
        public bool IsReferenceJapanese { get; set; }

        /// <summary>
        /// 英語テキストを付加するかどうか
        /// </summary>
        public bool DoesInsertEnglishText { get; set; }

        /// <summary>
        /// 存在しない定義名をログ出力するかどうか
        /// </summary>
        public bool DoesOutputLogMissingDefine { get; set; }

        /// <summary>
        /// 行末の文字の処理モード
        /// </summary>
        public enum LineBreakMode
        {
            None, // 変更しない
            AlwaysSmall, // 常に"x"
            AlwaysLarge, // 常に"X"
        }

        public LineBreakMode LineBreak { get; set; }

        /// <summary>
        /// 改行コードの挿入モード
        /// </summary>
        public enum NewLineMode
        {
            None, // 付加しない
            Letter, // 文字数換算
            Pixel, // ピクセル数換算
        }

        public NewLineMode NewLine { get; set; }

        /// <summary>
        /// 改行コードを挿入する文字数
        /// </summary>
        public int NewLineLetter { get; set; }

        /// <summary>
        /// 改行コードを挿入するピクセル数
        /// </summary>
        public int NewLinePixel { get; set; }

        /// <summary>
        /// 表示幅計算用のフォント名
        /// </summary>
        public string FontName { get; set; }

        /// <summary>
        /// 表示幅計算用のフォントのポイント数
        /// </summary>
        public float FontPoint { get; set; }

        /// <summary>
        /// 禁則処理を行うかどうか
        /// </summary>
        public bool IsWordWrap { get; set; }

        /// <summary>
        /// 元の改行コードを残すかどうか
        /// </summary>
        public bool DoesLeaveNewLine { get; set; }

        /// <summary>
        /// 区切り文字
        /// </summary>
        private static readonly char[] SeparatorLetters = new char[] {';'};

        /// <summary>
        /// 改行コードの区切り文字
        /// </summary>
        private static readonly string[] LineBreakSeparators = new string[] {"\\n"};

        /// <summary>
        /// 行頭の数字にマッチする正規表現
        /// </summary>
        private readonly Regex rLineHeadNumbers = new Regex("^[\\d０１２３４５６７８９]");

        /// <summary>
        /// 行末禁則文字にマッチする正規表現
        /// </summary>
        private readonly Regex rNoLineBreakLetters = new Regex("[\\(\\[\\{（［｛〔【「『―‥…]*$");

        /// <summary>
        /// 行頭禁則文字にマッチする正規表現
        /// </summary>
        private readonly Regex rNoLineHeadLetters =
            new Regex("^[\\.,\\)\\]\\}\\-=_:;!\\?．，。、･・）］｝〕】」』－ー＝＿：；！？ァィゥェォッャュョぁぃぅぇぉっゃゅょ々]");

        /// <summary>
        /// 改行コードにマッチする正規表現
        /// </summary>
        private readonly Regex rLineBreak = new Regex("\\\\n");

        /// <summary>
        /// メインフォームのグラフィックオブジェクト(表示幅計算用)
        /// </summary>
        private readonly Graphics graph;

        /// <summary>
        /// フォントオブジェクト(表示幅計算用)
        /// </summary>
        private Font font;

        /// <summary>
        /// 指定ピクセル数に収まるおおよその文字数
        /// </summary>
        private int approximateLetter;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="mainForm">メインフォームへの参照</param>
        public ReorganizerEngine(MainForm mainForm)
        {
            this.mainForm = mainForm;

            graph = mainForm.CreateGraphics();

            // 変数の初期化(念のため)
            IsTargetJapanese = false;
            DoesInsertEnglishText = true;
            LineBreak = LineBreakMode.None;
            NewLine = NewLineMode.None;
            NewLineLetter = 28;
            NewLinePixel = 348;
            FontName = "MS UI Gothic";
            FontPoint = 9;
            IsWordWrap = true;
        }

        /// <summary>
        /// 再構成を実行する
        /// </summary>
        /// <param name="targetFolderName">対象フォルダ名</param>
        /// <param name="referenceFolderName">参照フォルダ名</param>
        /// <param name="outputFolderName">出力フォルダ名</param>
        public void Reorganize(string targetFolderName, string referenceFolderName, string outputFolderName)
        {
            mainForm.AppendLog(string.Format("Config Reorganizer Ver {0}\n\n", ConfigReorganizer.Version));

            ParseReferenceFolder(referenceFolderName);
            ConvertFolder(targetFolderName, outputFolderName);

            mainForm.AppendLog("\n完了\n");
        }

        /// <summary>
        /// 参照フォルダ内のCSVファイルを順に解析する
        /// </summary>
        /// <param name="referenceFolderName">参照フォルダ名</param>
        private void ParseReferenceFolder(string referenceFolderName)
        {
            mainForm.AppendLog("参照フォルダの文字列解析中...\n\n");
            convertTable = new Dictionary<string, string>();

            // 参照フォルダ内のCSVファイルを順に解析する
            foreach (string fileName in Directory.GetFiles(referenceFolderName, "*.csv"))
            {
                mainForm.AppendLog(Path.GetFileName(fileName) + "\n");
                ParseReferenceFile(fileName);
            }

            // 参照フォルダ内のサブフォルダを順に解析する
            foreach (string folderName in Directory.GetDirectories(referenceFolderName))
            {
                ParseReferenceFolderRecursive(referenceFolderName, Path.GetFileName(folderName));
            }

            mainForm.AppendLog("\n");
        }

        /// <summary>
        /// 参照フォルダ内のサブフォルダを順に解析する
        /// </summary>
        /// <param name="referenceFolderName">参照フォルダ名</param>
        /// <param name="subFolderName">サブフォルダ名</param>
        private void ParseReferenceFolderRecursive(string referenceFolderName, string subFolderName)
        {
            string currentFolderName = Path.Combine(referenceFolderName, subFolderName);

            // フォルダ内のCSVファイルを順に解析する
            foreach (string fileName in Directory.GetFiles(currentFolderName, "*.csv"))
            {
                mainForm.AppendLog(string.Format("{0}\\{1}\n", subFolderName, Path.GetFileName(fileName)));
                ParseReferenceFile(fileName);
            }

            // フォルダ内のサブフォルダを順に処理する
            foreach (string folderName in Directory.GetDirectories(currentFolderName))
            {
                ParseReferenceFolderRecursive(referenceFolderName,
                                              Path.Combine(subFolderName, Path.GetFileName(folderName)));
            }
        }

        /// <summary>
        /// 参照フォルダ内のCSVファイルを解析する
        /// </summary>
        /// <param name="fileName">CSVファイルのファイル名</param>
        private void ParseReferenceFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding(IsReferenceJapanese ? 932 : 1252));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] tokens = line.Split(SeparatorLetters);

                // 空行、コメント行を読み飛ばす
                if (tokens.Length <= 1 || string.IsNullOrEmpty(tokens[0]) || tokens[0][0] == '#')
                {
                    continue;
                }

                // 変換テーブルに登録する
                convertTable[tokens[0]] = tokens[1];
            }
            reader.Close();
        }

        /// <summary>
        /// 対象フォルダ内のCSVファイルを順に変換する
        /// </summary>
        /// <param name="targetFolderName">対象フォルダ名</param>
        /// <param name="outputFolderName">出力フォルダ名</param>
        private void ConvertFolder(string targetFolderName, string outputFolderName)
        {
            mainForm.AppendLog("対象フォルダの文字列変換中...\n\n");

            if (NewLine == NewLineMode.Pixel)
            {
                font = new Font(FontName, FontPoint);
                approximateLetter = 2;
                string s = "ああ";
                while (graph.MeasureString(s, font).Width <= NewLinePixel)
                {
                    approximateLetter += 1;
                    s += "あ";
                }
                approximateLetter -= 1;
            }

            // 対象フォルダ内のCSVファイルを順に変換する
            foreach (string fileName in Directory.GetFiles(targetFolderName, "*.csv"))
            {
                mainForm.AppendLog(Path.GetFileName(fileName) + "\n");
                ConvertFile(fileName, outputFolderName);
            }

            // (AoD用) Additionalサブフォルダ内のCSVファイルを順に変換する
            if (Directory.Exists(Path.Combine(targetFolderName, "Additional")))
            {
                foreach (string fileName in Directory.GetFiles(Path.Combine(targetFolderName, "Additional"), "*.csv"))
                {
                    mainForm.AppendLog("Additional\\" + Path.GetFileName(fileName) + "\n");
                    ConvertFile(fileName, Path.Combine(outputFolderName, "Additional"));
                }
            }
        }

        /// <summary>
        /// 対象フォルダ内のCSVファイルを変換する
        /// </summary>
        /// <param name="fileName">CSVファイルのファイル名</param>
        /// <param name="outputFolderName">出力フォルダ名</param>
        private void ConvertFile(string fileName, string outputFolderName)
        {
            StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding(IsTargetJapanese ? 932 : 1252));

            if (!Directory.Exists(outputFolderName))
            {
                Directory.CreateDirectory(outputFolderName);
            }

            StreamWriter writer = new StreamWriter(Path.Combine(outputFolderName, Path.GetFileName(fileName)), false,
                                                   Encoding.GetEncoding(932));

            int lineNum = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] tokens = line.Split(SeparatorLetters);

                lineNum += 1;

                // 空行はそのまま出力する
                if (string.IsNullOrEmpty(line))
                {
                    writer.WriteLine();
                    continue;
                }

                // コメント行は行末のみ変換して出力する
                if (line[0] == '#')
                {
                    if (LineBreak != LineBreakMode.None)
                    {
                        char c = line[line.Length - 1];
                        if (c == 'x' || c == 'X')
                        {
                            if (LineBreak == LineBreakMode.AlwaysSmall)
                            {
                                line = line.Substring(0, line.Length - 1) + 'x';
                            }
                            else
                            {
                                line = line.Substring(0, line.Length - 1) + 'X';
                            }
                        }
                    }
                    writer.WriteLine(line);
                    continue;
                }

                StringBuilder sb = new StringBuilder();

                // 定義名を挿入
                sb.Append(tokens[0]);
                sb.Append(";");

                if (convertTable.ContainsKey(tokens[0]))
                {
                    string[] list;

                    if (DoesLeaveNewLine)
                    {
                        list = convertTable[tokens[0]].Split(LineBreakSeparators, StringSplitOptions.None);
                    }
                    else
                    {
                        // 改行コードを残さない場合は削除する
                        list = new string[] {rLineBreak.Replace(convertTable[tokens[0]], "")};
                    }

                    // 変換テキストを挿入
                    bool first = true;
                    foreach (string s in list)
                    {
                        if (first)
                        {
                            first = false;
                        }
                        else
                        {
                            sb.Append("\\n");
                        }

                        if (NewLine == NewLineMode.Letter)
                        {
                            sb.Append(GetNewLineTextByLetter(s));
                        }
                        else if (NewLine == NewLineMode.Pixel)
                        {
                            sb.Append(GetNewLineTextByPixel(s));
                        }
                        else
                        {
                            sb.Append(s);
                        }
                    }
                    sb.Append(";");

                    // 英語テキストを挿入
                    if (DoesInsertEnglishText && !IsTargetJapanese && tokens.Length > 1)
                    {
                        sb.Append(tokens[1]);
                    }
                }
                else
                {
                    // 変換テキストがない場合は、元のテキストをそのまま挿入する
                    if (tokens.Length > 1)
                    {
                        sb.Append(tokens[1]);
                        sb.Append(";");

                        if (DoesInsertEnglishText)
                        {
                            sb.Append(tokens[1]);
                        }
                    }
                    else
                    {
                        sb.Append(";");
                    }

                    if (DoesOutputLogMissingDefine)
                    {
                        mainForm.AppendLog(string.Format("  L{0}: {1}\n", lineNum, tokens[0]));
                    }
                }

                // 残りの言語のテキストは削除
                sb.Append(";;;;;;;;;");

                // 末尾の文字を挿入
                if (LineBreak == LineBreakMode.AlwaysSmall)
                {
                    sb.Append('x');
                }
                else if (LineBreak == LineBreakMode.AlwaysLarge)
                {
                    sb.Append('X');
                }
                else
                {
                    char c = line[line.Length - 1];
                    if (c == 'x' || c == 'X')
                    {
                        sb.Append(c);
                    }
                    else
                    {
                        // 行末に'x'がない場合は付加する
                        sb.Append("x");
                    }
                }

                // 1行の文字列を出力する
                writer.WriteLine(sb.ToString());
            }

            writer.Close();
            reader.Close();
        }

        /// <summary>
        /// 指定文字数ごとに改行コードで区切った文字列を返す
        /// </summary>
        /// <param name="s">対象文字列</param>
        /// <returns>指定文字数ごとに改行コードで区切った文字列</returns>
        private string GetNewLineTextByLetter(string s)
        {
            // 元の改行コードを残さない場合、改行コードを一旦削除する
            if (!DoesLeaveNewLine)
            {
                s = rLineBreak.Replace(s, "");
            }

            StringBuilder sb = new StringBuilder();
            while (s.Length > NewLineLetter)
            {
                // 禁則処理
                string line = IsWordWrap
                                  ? GetWordWrappedString(s.Substring(0, NewLineLetter), s.Substring(NewLineLetter, 1))
                                  : s.Substring(0, NewLineLetter);

                // 改行コードを挿入する
                sb.Append(line);
                sb.Append("\\n");

                s = s.Substring(line.Length);
            }
            // 残りを出力する
            sb.Append(s);

            return sb.ToString();
        }

        /// <summary>
        /// >指定ピクセル数ごとに改行コードで区切った文字列を返す
        /// </summary>
        /// <param name="s">対象文字列</param>
        /// <returns>指定ピクセル数ごとに改行コードで区切った文字列</returns>
        private string GetNewLineTextByPixel(string s)
        {
            // 元の改行コードを残さない場合、改行コードを一旦削除する
            if (!DoesLeaveNewLine)
            {
                s = rLineBreak.Replace(s, "");
            }

            StringBuilder sb = new StringBuilder();
            int pos = approximateLetter;
            if (pos > s.Length)
            {
                pos = s.Length;
            }
            int dir = 0;

            while (!string.IsNullOrEmpty(s))
            {
                int width = (int) graph.MeasureString(s.Substring(0, pos), font).Width;

                if (dir == 1)
                {
                    if (width <= NewLinePixel)
                    {
                        // 文字列の終端に到達したら、残りを出力して終了
                        if (pos >= s.Length)
                        {
                            sb.Append(s);
                            break;
                        }
                        // 1文字増やして再トライ
                        pos++;
                    }
                    else
                    {
                        // 禁則処理
                        string line = IsWordWrap
                                          ? GetWordWrappedString(s.Substring(0, pos - 1), s.Substring(pos - 1, 1))
                                          : s.Substring(0, pos - 1);

                        // 改行コードを挿入する
                        sb.Append(line);
                        sb.Append("\\n");

                        // 次の行の処理へ
                        s = s.Substring(line.Length);
                        pos = approximateLetter;
                        if (pos > s.Length)
                        {
                            pos = s.Length;
                        }
                        dir = 0;
                    }
                }
                else if (dir == -1)
                {
                    if (width <= NewLinePixel)
                    {
                        // 禁則処理
                        string line = IsWordWrap
                                          ? GetWordWrappedString(s.Substring(0, pos), s.Substring(pos, 1))
                                          : s.Substring(0, pos);

                        // 改行コードを挿入する
                        sb.Append(line);
                        sb.Append("\\n");

                        // 次の行の処理へ
                        s = s.Substring(line.Length);
                        pos = approximateLetter;
                        if (pos > s.Length)
                        {
                            pos = s.Length;
                        }
                        dir = 0;
                    }
                    else
                    {
                        // 1文字減らして再トライ
                        pos--;
                    }
                }
                else
                {
                    if (width <= NewLinePixel)
                    {
                        // 文字列の終端に到達したら、残りを出力して終了
                        if (pos >= s.Length)
                        {
                            sb.Append(s);
                            break;
                        }
                        // 1文字増やす
                        pos++;
                        dir = 1;
                    }
                    else
                    {
                        // 1文字減らす
                        pos--;
                        dir = -1;
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// 禁則処理した文字列を取得する
        /// </summary>
        /// <param name="s">対象文字列</param>
        /// <param name="next">次の行の先頭(1文字で構わない)</param>
        /// <returns>禁則処理した文字列</returns>
        private string GetWordWrappedString(string s, string next)
        {
            // 次の行頭に禁則文字が現れるなら、1文字次の行に送り出す
            if (rNoLineHeadLetters.IsMatch(next) && (s.Length > 1))
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                // 数字が2行に分割されるようなら、次の行に送り出す
                if (rLineHeadNumbers.IsMatch(next))
                {
                    s = rLineHeadNumbers.Replace(s, "");
                }
            }

            // 行末禁則文字を次の行に送り出す
            s = rNoLineBreakLetters.Replace(s, "");

            return s;
        }
    }
}