using System;
using System.IO;
using System.Windows.Forms;

namespace ConfigReorganizer
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 再構成エンジン
        /// </summary>
        private readonly ReorganizerEngine engine;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            engine = new ReorganizerEngine(this);

            InitializeComponent();

            InitTitle();
        }

        /// <summary>
        /// タイトル文字列を初期化する
        /// </summary>
        private void InitTitle()
        {
            Text = string.Format("Config Reorganizer Ver {0}", ConfigReorganizer.Version);
        }

        /// <summary>
        /// 開始ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnStartButtonClick(object sender, EventArgs e)
        {
            // 対象フォルダ名が入力されていなければエラー
            if (string.IsNullOrEmpty(targetFolderTextBox.Text))
            {
                MessageBox.Show("対象フォルダ名を入力して下さい。");
                return;
            }

            // 参照フォルダ名が入力されていなければ、対象フォルダ名を流用する
            string referenceFolderName;
            if (string.IsNullOrEmpty(referenceFolderTextBox.Text))
            {
                referenceFolderTextBox.Text = targetFolderTextBox.Text;
                referenceFolderName = targetFolderTextBox.Text;
            }
            else
            {
                referenceFolderName = referenceFolderTextBox.Text;
            }

            // 出力フォルダ名が入力されていなければ、実行ファイルのあるフォルダにconfigフォルダを作成する
            string outputFolderName = string.IsNullOrEmpty(outputFolderTextBox.Text)
                                          ? Path.Combine(Environment.CurrentDirectory, "config")
                                          : outputFolderTextBox.Text;

            // UI上の選択に合わせて設定を更新する
            UpdateSetting();

            engine.Reorganize(targetFolderTextBox.Text, referenceFolderName, outputFolderName);
        }

        /// <summary>
        /// 終了ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 対象フォルダの参照ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTargetFolderBrowseButtonClick(object sender, EventArgs e)
        {
            // フォルダ参照ダイアログを開き、選択されたフォルダ名をテキストボックスに入力する
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                targetFolderTextBox.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 参照フォルダの参照ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnReferenceFolderBrowserButtonClick(object sender, EventArgs e)
        {
            // フォルダ参照ダイアログを開き、選択されたフォルダ名をテキストボックスに入力する
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                referenceFolderTextBox.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 出力フォルダの参照ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOutputFolderBrowseButtonClick(object sender, EventArgs e)
        {
            // フォルダ参照ダイアログを開き、選択されたフォルダ名をテキストボックスに入力する
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderTextBox.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// フォント参照ボタン押下時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBrowseFontButtonClick(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowEffects = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                engine.FontName = dialog.Font.Name;
                fontTextBox.Text = engine.FontName;

                engine.FontPoint = dialog.Font.SizeInPoints;
                pointTextBox.Text = engine.FontPoint.ToString();
            }
        }

        /// <summary>
        /// 対象フォルダの言語を切り替えた時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEnglishRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            InsertEnglishTextCheckBox.Enabled = targetEnglishRadioButton.Checked;
        }

        /// <summary>
        /// 改行コードで付加しないを選択した時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNoNewLineRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (noNewLineRadioButton.Checked)
            {
                // 文字数/ピクセル数/フォント選択/禁則/元の改行コードを残すを無効にする
                letterNewLineTextBox.Enabled = false;
                pixelNewLineTextBox.Enabled = false;
                fontTextBox.Enabled = false;
                pointTextBox.Enabled = false;
                browseFontButton.Enabled = false;
                wordWrapCheckBox.Enabled = false;
                leaveNewLineCheckBox.Enabled = false;
            }
        }

        /// <summary>
        /// 改行コードで文字数を選択した時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLetterNewLineRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (letterNewLineRadioButton.Checked)
            {
                // 文字数/禁則/元の改行コードを残すを有効にする
                letterNewLineTextBox.Enabled = true;
                wordWrapCheckBox.Enabled = true;
                leaveNewLineCheckBox.Enabled = true;

                // ピクセル数/フォント選択を無効にする
                pixelNewLineTextBox.Enabled = false;
                fontTextBox.Enabled = false;
                pointTextBox.Enabled = false;
                browseFontButton.Enabled = false;
            }
        }

        /// <summary>
        /// 改行コードでピクセル数を選択した時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPixelNewLineRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (pixelNewLineRadioButton.Checked)
            {
                // 文字数/元の改行コードを残すを無効にする
                letterNewLineTextBox.Enabled = false;
                leaveNewLineCheckBox.Enabled = true;

                // ピクセル数/フォント選択/禁則を有効にする
                pixelNewLineTextBox.Enabled = true;
                fontTextBox.Enabled = true;
                pointTextBox.Enabled = true;
                browseFontButton.Enabled = true;
                wordWrapCheckBox.Enabled = true;
            }
        }

        /// <summary>
        /// 対象フォルダ名テキストボックスにフォルダをドラッグした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTargetFolderTextBoxDragEnter(object sender, DragEventArgs e)
        {
            // フォルダのドロップを許可する
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// 対象フォルダ名テキストボックスにフォルダをドロップした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTargetFolderTextBoxDragDrop(object sender, DragEventArgs e)
        {
            // 対象フォルダ名テキストボックスにフォルダ名を入力する
            string[] fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            targetFolderTextBox.Text = fileNames[0];
        }

        /// <summary>
        /// 参照フォルダ名テキストボックスにフォルダをドラッグした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnReferenceFolderTextBoxDragEnter(object sender, DragEventArgs e)
        {
            // フォルダのドロップを許可する
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// 参照フォルダ名テキストボックスにフォルダをドロップした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnReferenceFolderTextBoxDragDrop(object sender, DragEventArgs e)
        {
            // 参照フォルダ名テキストボックスにフォルダ名を入力する
            string[] fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            referenceFolderTextBox.Text = fileNames[0];
        }

        /// <summary>
        /// 出力フォルダ名テキストボックスにフォルダをドラッグした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOutputFolderTextBoxDragEnter(object sender, DragEventArgs e)
        {
            // フォルダのドロップを許可する
            e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        /// <summary>
        /// 出力フォルダ名テキストボックスにフォルダをドロップした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOutputFolderTextBoxDragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            outputFolderTextBox.Text = fileNames[0];
        }

        /// <summary>
        /// UI上の選択に合わせて設定を更新する
        /// </summary>
        private void UpdateSetting()
        {
            engine.IsTargetJapanese = targetJapaneseRadioButton.Checked;
            engine.IsReferenceJapanese = string.IsNullOrEmpty(referenceFolderTextBox.Text)
                                             ? engine.IsTargetJapanese
                                             : referenceJapaneseRadioButton.Checked;

            engine.DoesInsertEnglishText = InsertEnglishTextCheckBox.Checked;
            engine.DoesOutputLogMissingDefine = logMissingDefineCheckBox.Checked;

            if (alwaysSmallRadioButton.Checked)
            {
                engine.LineBreak = ReorganizerEngine.LineBreakMode.AlwaysSmall;
            }
            else if (alwaysLargeRadioButton.Checked)
            {
                engine.LineBreak = ReorganizerEngine.LineBreakMode.AlwaysLarge;
            }
            else
            {
                engine.LineBreak = ReorganizerEngine.LineBreakMode.None;
            }

            if (letterNewLineRadioButton.Checked)
            {
                engine.NewLine = ReorganizerEngine.NewLineMode.Letter;
            }
            else if (pixelNewLineRadioButton.Checked)
            {
                engine.NewLine = ReorganizerEngine.NewLineMode.Pixel;
            }
            else
            {
                engine.NewLine = ReorganizerEngine.NewLineMode.None;
            }

            engine.NewLineLetter = int.Parse(letterNewLineTextBox.Text);
            engine.NewLinePixel = int.Parse(pixelNewLineTextBox.Text);

            engine.FontName = fontTextBox.Text;
            engine.FontPoint = float.Parse(pointTextBox.Text);

            engine.IsWordWrap = wordWrapCheckBox.Checked;
            engine.DoesLeaveNewLine = leaveNewLineCheckBox.Checked;
        }

        /// <summary>
        /// ログを追加する
        /// </summary>
        /// <param name="s"></param>
        public void AppendLog(string s)
        {
            logRichTextBox.AppendText(s);

            // カーソルを末尾の行へスクロールする
            logRichTextBox.ScrollToCaret();
        }

        private void OnReferenceFolderTextBoxTextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(referenceFolderTextBox.Text))
            {
                referenceEnglishRadioButton.Enabled = false;
                referenceJapaneseRadioButton.Enabled = false;
            }
            else
            {
                referenceEnglishRadioButton.Enabled = true;
                referenceJapaneseRadioButton.Enabled = true;
            }
        }
    }
}