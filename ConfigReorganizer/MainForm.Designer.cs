namespace ConfigReorganizer
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.targetFolderBrowseButton = new System.Windows.Forms.Button();
			this.targetFolderTextBox = new System.Windows.Forms.TextBox();
			this.targetFolderLabel = new System.Windows.Forms.Label();
			this.outputFolderBrowseButton = new System.Windows.Forms.Button();
			this.outputFolderTextBox = new System.Windows.Forms.TextBox();
			this.outputFolderLabel = new System.Windows.Forms.Label();
			this.referenceFolderLabel = new System.Windows.Forms.Label();
			this.referenceFolderTextBox = new System.Windows.Forms.TextBox();
			this.referenceFolderBrowseButton = new System.Windows.Forms.Button();
			this.InsertEnglishTextCheckBox = new System.Windows.Forms.CheckBox();
			this.lastLetterGroupBox = new System.Windows.Forms.GroupBox();
			this.alwaysLargeRadioButton = new System.Windows.Forms.RadioButton();
			this.alwaysSmallRadioButton = new System.Windows.Forms.RadioButton();
			this.dontChangeRadioButton = new System.Windows.Forms.RadioButton();
			this.startButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.logRichTextBox = new System.Windows.Forms.RichTextBox();
			this.targetLanguageGroupBox = new System.Windows.Forms.GroupBox();
			this.targetJapaneseRadioButton = new System.Windows.Forms.RadioButton();
			this.targetEnglishRadioButton = new System.Windows.Forms.RadioButton();
			this.newLineGroupBox = new System.Windows.Forms.GroupBox();
			this.leaveNewLineCheckBox = new System.Windows.Forms.CheckBox();
			this.browseFontButton = new System.Windows.Forms.Button();
			this.wordWrapCheckBox = new System.Windows.Forms.CheckBox();
			this.pointLabel = new System.Windows.Forms.Label();
			this.pointTextBox = new System.Windows.Forms.TextBox();
			this.fontTextBox = new System.Windows.Forms.TextBox();
			this.fontLabel = new System.Windows.Forms.Label();
			this.pixelNewLineLabel = new System.Windows.Forms.Label();
			this.letterNewLineLabel = new System.Windows.Forms.Label();
			this.pixelNewLineTextBox = new System.Windows.Forms.TextBox();
			this.letterNewLineTextBox = new System.Windows.Forms.TextBox();
			this.pixelNewLineRadioButton = new System.Windows.Forms.RadioButton();
			this.letterNewLineRadioButton = new System.Windows.Forms.RadioButton();
			this.noNewLineRadioButton = new System.Windows.Forms.RadioButton();
			this.referenceLanguageGroupBox = new System.Windows.Forms.GroupBox();
			this.referenceJapaneseRadioButton = new System.Windows.Forms.RadioButton();
			this.referenceEnglishRadioButton = new System.Windows.Forms.RadioButton();
			this.optionGroupBox = new System.Windows.Forms.GroupBox();
			this.logMissingDefineCheckBox = new System.Windows.Forms.CheckBox();
			this.lastLetterGroupBox.SuspendLayout();
			this.targetLanguageGroupBox.SuspendLayout();
			this.newLineGroupBox.SuspendLayout();
			this.referenceLanguageGroupBox.SuspendLayout();
			this.optionGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// targetFolderBrowseButton
			// 
			this.targetFolderBrowseButton.Location = new System.Drawing.Point(526, 20);
			this.targetFolderBrowseButton.Name = "targetFolderBrowseButton";
			this.targetFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.targetFolderBrowseButton.TabIndex = 2;
			this.targetFolderBrowseButton.Text = "参照";
			this.targetFolderBrowseButton.UseVisualStyleBackColor = true;
			this.targetFolderBrowseButton.Click += new System.EventHandler(this.OnTargetFolderBrowseButtonClick);
			// 
			// targetFolderTextBox
			// 
			this.targetFolderTextBox.AllowDrop = true;
			this.targetFolderTextBox.Location = new System.Drawing.Point(93, 22);
			this.targetFolderTextBox.Name = "targetFolderTextBox";
			this.targetFolderTextBox.Size = new System.Drawing.Size(427, 19);
			this.targetFolderTextBox.TabIndex = 1;
			this.targetFolderTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnTargetFolderTextBoxDragDrop);
			this.targetFolderTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnTargetFolderTextBoxDragEnter);
			// 
			// targetFolderLabel
			// 
			this.targetFolderLabel.AutoSize = true;
			this.targetFolderLabel.Location = new System.Drawing.Point(23, 25);
			this.targetFolderLabel.Name = "targetFolderLabel";
			this.targetFolderLabel.Size = new System.Drawing.Size(64, 12);
			this.targetFolderLabel.TabIndex = 0;
			this.targetFolderLabel.Text = "対象フォルダ";
			// 
			// outputFolderBrowseButton
			// 
			this.outputFolderBrowseButton.Location = new System.Drawing.Point(526, 70);
			this.outputFolderBrowseButton.Name = "outputFolderBrowseButton";
			this.outputFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.outputFolderBrowseButton.TabIndex = 8;
			this.outputFolderBrowseButton.Text = "参照";
			this.outputFolderBrowseButton.UseVisualStyleBackColor = true;
			this.outputFolderBrowseButton.Click += new System.EventHandler(this.OnOutputFolderBrowseButtonClick);
			// 
			// outputFolderTextBox
			// 
			this.outputFolderTextBox.AllowDrop = true;
			this.outputFolderTextBox.Location = new System.Drawing.Point(93, 72);
			this.outputFolderTextBox.Name = "outputFolderTextBox";
			this.outputFolderTextBox.Size = new System.Drawing.Size(427, 19);
			this.outputFolderTextBox.TabIndex = 7;
			this.outputFolderTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnOutputFolderTextBoxDragDrop);
			this.outputFolderTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnOutputFolderTextBoxDragEnter);
			// 
			// outputFolderLabel
			// 
			this.outputFolderLabel.AutoSize = true;
			this.outputFolderLabel.Location = new System.Drawing.Point(23, 75);
			this.outputFolderLabel.Name = "outputFolderLabel";
			this.outputFolderLabel.Size = new System.Drawing.Size(64, 12);
			this.outputFolderLabel.TabIndex = 6;
			this.outputFolderLabel.Text = "出力フォルダ";
			// 
			// referenceFolderLabel
			// 
			this.referenceFolderLabel.AutoSize = true;
			this.referenceFolderLabel.Location = new System.Drawing.Point(23, 50);
			this.referenceFolderLabel.Name = "referenceFolderLabel";
			this.referenceFolderLabel.Size = new System.Drawing.Size(64, 12);
			this.referenceFolderLabel.TabIndex = 3;
			this.referenceFolderLabel.Text = "参照フォルダ";
			// 
			// referenceFolderTextBox
			// 
			this.referenceFolderTextBox.AllowDrop = true;
			this.referenceFolderTextBox.Location = new System.Drawing.Point(93, 47);
			this.referenceFolderTextBox.Name = "referenceFolderTextBox";
			this.referenceFolderTextBox.Size = new System.Drawing.Size(427, 19);
			this.referenceFolderTextBox.TabIndex = 4;
			this.referenceFolderTextBox.TextChanged += new System.EventHandler(this.OnReferenceFolderTextBoxTextChanged);
			this.referenceFolderTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnReferenceFolderTextBoxDragDrop);
			this.referenceFolderTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnReferenceFolderTextBoxDragEnter);
			// 
			// referenceFolderBrowseButton
			// 
			this.referenceFolderBrowseButton.Location = new System.Drawing.Point(526, 45);
			this.referenceFolderBrowseButton.Name = "referenceFolderBrowseButton";
			this.referenceFolderBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.referenceFolderBrowseButton.TabIndex = 5;
			this.referenceFolderBrowseButton.Text = "参照";
			this.referenceFolderBrowseButton.UseVisualStyleBackColor = true;
			this.referenceFolderBrowseButton.Click += new System.EventHandler(this.OnReferenceFolderBrowserButtonClick);
			// 
			// InsertEnglishTextCheckBox
			// 
			this.InsertEnglishTextCheckBox.AutoSize = true;
			this.InsertEnglishTextCheckBox.Checked = true;
			this.InsertEnglishTextCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.InsertEnglishTextCheckBox.Location = new System.Drawing.Point(19, 18);
			this.InsertEnglishTextCheckBox.Name = "InsertEnglishTextCheckBox";
			this.InsertEnglishTextCheckBox.Size = new System.Drawing.Size(136, 16);
			this.InsertEnglishTextCheckBox.TabIndex = 16;
			this.InsertEnglishTextCheckBox.Text = "英語テキストを付加する";
			this.InsertEnglishTextCheckBox.UseVisualStyleBackColor = true;
			// 
			// lastLetterGroupBox
			// 
			this.lastLetterGroupBox.Controls.Add(this.alwaysLargeRadioButton);
			this.lastLetterGroupBox.Controls.Add(this.alwaysSmallRadioButton);
			this.lastLetterGroupBox.Controls.Add(this.dontChangeRadioButton);
			this.lastLetterGroupBox.Location = new System.Drawing.Point(218, 100);
			this.lastLetterGroupBox.Name = "lastLetterGroupBox";
			this.lastLetterGroupBox.Size = new System.Drawing.Size(302, 42);
			this.lastLetterGroupBox.TabIndex = 18;
			this.lastLetterGroupBox.TabStop = false;
			this.lastLetterGroupBox.Text = "行末の文字";
			// 
			// alwaysLargeRadioButton
			// 
			this.alwaysLargeRadioButton.AutoSize = true;
			this.alwaysLargeRadioButton.Location = new System.Drawing.Point(169, 18);
			this.alwaysLargeRadioButton.Name = "alwaysLargeRadioButton";
			this.alwaysLargeRadioButton.Size = new System.Drawing.Size(63, 16);
			this.alwaysLargeRadioButton.TabIndex = 21;
			this.alwaysLargeRadioButton.Text = "常に\"X\"";
			this.alwaysLargeRadioButton.UseVisualStyleBackColor = true;
			// 
			// alwaysSmallRadioButton
			// 
			this.alwaysSmallRadioButton.AutoSize = true;
			this.alwaysSmallRadioButton.Location = new System.Drawing.Point(101, 18);
			this.alwaysSmallRadioButton.Name = "alwaysSmallRadioButton";
			this.alwaysSmallRadioButton.Size = new System.Drawing.Size(62, 16);
			this.alwaysSmallRadioButton.TabIndex = 20;
			this.alwaysSmallRadioButton.Text = "常に\"x\"";
			this.alwaysSmallRadioButton.UseVisualStyleBackColor = true;
			// 
			// dontChangeRadioButton
			// 
			this.dontChangeRadioButton.AutoSize = true;
			this.dontChangeRadioButton.Checked = true;
			this.dontChangeRadioButton.Location = new System.Drawing.Point(19, 18);
			this.dontChangeRadioButton.Name = "dontChangeRadioButton";
			this.dontChangeRadioButton.Size = new System.Drawing.Size(76, 16);
			this.dontChangeRadioButton.TabIndex = 19;
			this.dontChangeRadioButton.TabStop = true;
			this.dontChangeRadioButton.Text = "変更しない";
			this.dontChangeRadioButton.UseVisualStyleBackColor = true;
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(526, 144);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 68);
			this.startButton.TabIndex = 33;
			this.startButton.Text = "開始";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.OnStartButtonClick);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(526, 218);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 68);
			this.exitButton.TabIndex = 34;
			this.exitButton.Text = "終了";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.OnExitButtonClick);
			// 
			// logRichTextBox
			// 
			this.logRichTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.logRichTextBox.Location = new System.Drawing.Point(25, 292);
			this.logRichTextBox.Name = "logRichTextBox";
			this.logRichTextBox.Size = new System.Drawing.Size(576, 129);
			this.logRichTextBox.TabIndex = 35;
			this.logRichTextBox.Text = "";
			// 
			// targetLanguageGroupBox
			// 
			this.targetLanguageGroupBox.Controls.Add(this.targetJapaneseRadioButton);
			this.targetLanguageGroupBox.Controls.Add(this.targetEnglishRadioButton);
			this.targetLanguageGroupBox.Location = new System.Drawing.Point(25, 100);
			this.targetLanguageGroupBox.Name = "targetLanguageGroupBox";
			this.targetLanguageGroupBox.Size = new System.Drawing.Size(187, 42);
			this.targetLanguageGroupBox.TabIndex = 9;
			this.targetLanguageGroupBox.TabStop = false;
			this.targetLanguageGroupBox.Text = "対象フォルダの言語";
			// 
			// targetJapaneseRadioButton
			// 
			this.targetJapaneseRadioButton.AutoSize = true;
			this.targetJapaneseRadioButton.Location = new System.Drawing.Point(101, 18);
			this.targetJapaneseRadioButton.Name = "targetJapaneseRadioButton";
			this.targetJapaneseRadioButton.Size = new System.Drawing.Size(59, 16);
			this.targetJapaneseRadioButton.TabIndex = 11;
			this.targetJapaneseRadioButton.Text = "日本語";
			this.targetJapaneseRadioButton.UseVisualStyleBackColor = true;
			// 
			// targetEnglishRadioButton
			// 
			this.targetEnglishRadioButton.AutoSize = true;
			this.targetEnglishRadioButton.Checked = true;
			this.targetEnglishRadioButton.Location = new System.Drawing.Point(19, 18);
			this.targetEnglishRadioButton.Name = "targetEnglishRadioButton";
			this.targetEnglishRadioButton.Size = new System.Drawing.Size(47, 16);
			this.targetEnglishRadioButton.TabIndex = 10;
			this.targetEnglishRadioButton.TabStop = true;
			this.targetEnglishRadioButton.Text = "英語";
			this.targetEnglishRadioButton.UseVisualStyleBackColor = true;
			this.targetEnglishRadioButton.CheckedChanged += new System.EventHandler(this.OnEnglishRadioButtonCheckedChanged);
			// 
			// newLineGroupBox
			// 
			this.newLineGroupBox.Controls.Add(this.leaveNewLineCheckBox);
			this.newLineGroupBox.Controls.Add(this.browseFontButton);
			this.newLineGroupBox.Controls.Add(this.wordWrapCheckBox);
			this.newLineGroupBox.Controls.Add(this.pointLabel);
			this.newLineGroupBox.Controls.Add(this.pointTextBox);
			this.newLineGroupBox.Controls.Add(this.fontTextBox);
			this.newLineGroupBox.Controls.Add(this.fontLabel);
			this.newLineGroupBox.Controls.Add(this.pixelNewLineLabel);
			this.newLineGroupBox.Controls.Add(this.letterNewLineLabel);
			this.newLineGroupBox.Controls.Add(this.pixelNewLineTextBox);
			this.newLineGroupBox.Controls.Add(this.letterNewLineTextBox);
			this.newLineGroupBox.Controls.Add(this.pixelNewLineRadioButton);
			this.newLineGroupBox.Controls.Add(this.letterNewLineRadioButton);
			this.newLineGroupBox.Controls.Add(this.noNewLineRadioButton);
			this.newLineGroupBox.Location = new System.Drawing.Point(218, 148);
			this.newLineGroupBox.Name = "newLineGroupBox";
			this.newLineGroupBox.Size = new System.Drawing.Size(302, 138);
			this.newLineGroupBox.TabIndex = 22;
			this.newLineGroupBox.TabStop = false;
			this.newLineGroupBox.Text = "改行コード";
			// 
			// leaveNewLineCheckBox
			// 
			this.leaveNewLineCheckBox.AutoSize = true;
			this.leaveNewLineCheckBox.Checked = true;
			this.leaveNewLineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.leaveNewLineCheckBox.Enabled = false;
			this.leaveNewLineCheckBox.Location = new System.Drawing.Point(125, 112);
			this.leaveNewLineCheckBox.Name = "leaveNewLineCheckBox";
			this.leaveNewLineCheckBox.Size = new System.Drawing.Size(128, 16);
			this.leaveNewLineCheckBox.TabIndex = 32;
			this.leaveNewLineCheckBox.Text = "元の改行コードを残す";
			this.leaveNewLineCheckBox.UseVisualStyleBackColor = true;
			// 
			// browseFontButton
			// 
			this.browseFontButton.Enabled = false;
			this.browseFontButton.Location = new System.Drawing.Point(199, 59);
			this.browseFontButton.Name = "browseFontButton";
			this.browseFontButton.Size = new System.Drawing.Size(95, 23);
			this.browseFontButton.TabIndex = 28;
			this.browseFontButton.Text = "フォント参照";
			this.browseFontButton.UseVisualStyleBackColor = true;
			this.browseFontButton.Click += new System.EventHandler(this.OnBrowseFontButtonClick);
			// 
			// wordWrapCheckBox
			// 
			this.wordWrapCheckBox.AutoSize = true;
			this.wordWrapCheckBox.Checked = true;
			this.wordWrapCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.wordWrapCheckBox.Enabled = false;
			this.wordWrapCheckBox.Location = new System.Drawing.Point(19, 112);
			this.wordWrapCheckBox.Name = "wordWrapCheckBox";
			this.wordWrapCheckBox.Size = new System.Drawing.Size(100, 16);
			this.wordWrapCheckBox.TabIndex = 31;
			this.wordWrapCheckBox.Text = "禁則処理を行う";
			this.wordWrapCheckBox.UseVisualStyleBackColor = true;
			// 
			// pointLabel
			// 
			this.pointLabel.AutoSize = true;
			this.pointLabel.Location = new System.Drawing.Point(253, 90);
			this.pointLabel.Name = "pointLabel";
			this.pointLabel.Size = new System.Drawing.Size(41, 12);
			this.pointLabel.TabIndex = 10;
			this.pointLabel.Text = "ポイント";
			// 
			// pointTextBox
			// 
			this.pointTextBox.Enabled = false;
			this.pointTextBox.Location = new System.Drawing.Point(199, 87);
			this.pointTextBox.Name = "pointTextBox";
			this.pointTextBox.Size = new System.Drawing.Size(48, 19);
			this.pointTextBox.TabIndex = 30;
			this.pointTextBox.Text = "9";
			this.pointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// fontTextBox
			// 
			this.fontTextBox.Enabled = false;
			this.fontTextBox.Location = new System.Drawing.Point(61, 87);
			this.fontTextBox.Name = "fontTextBox";
			this.fontTextBox.Size = new System.Drawing.Size(132, 19);
			this.fontTextBox.TabIndex = 29;
			this.fontTextBox.Text = "MS UI Gothic";
			// 
			// fontLabel
			// 
			this.fontLabel.AutoSize = true;
			this.fontLabel.Location = new System.Drawing.Point(17, 90);
			this.fontLabel.Name = "fontLabel";
			this.fontLabel.Size = new System.Drawing.Size(38, 12);
			this.fontLabel.TabIndex = 7;
			this.fontLabel.Text = "フォント";
			// 
			// pixelNewLineLabel
			// 
			this.pixelNewLineLabel.AutoSize = true;
			this.pixelNewLineLabel.Location = new System.Drawing.Point(151, 64);
			this.pixelNewLineLabel.Name = "pixelNewLineLabel";
			this.pixelNewLineLabel.Size = new System.Drawing.Size(42, 12);
			this.pixelNewLineLabel.TabIndex = 6;
			this.pixelNewLineLabel.Text = "ピクセル";
			// 
			// letterNewLineLabel
			// 
			this.letterNewLineLabel.AutoSize = true;
			this.letterNewLineLabel.Location = new System.Drawing.Point(151, 42);
			this.letterNewLineLabel.Name = "letterNewLineLabel";
			this.letterNewLineLabel.Size = new System.Drawing.Size(29, 12);
			this.letterNewLineLabel.TabIndex = 5;
			this.letterNewLineLabel.Text = "文字";
			// 
			// pixelNewLineTextBox
			// 
			this.pixelNewLineTextBox.Enabled = false;
			this.pixelNewLineTextBox.Location = new System.Drawing.Point(97, 61);
			this.pixelNewLineTextBox.Name = "pixelNewLineTextBox";
			this.pixelNewLineTextBox.Size = new System.Drawing.Size(48, 19);
			this.pixelNewLineTextBox.TabIndex = 27;
			this.pixelNewLineTextBox.Text = "348";
			this.pixelNewLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// letterNewLineTextBox
			// 
			this.letterNewLineTextBox.Enabled = false;
			this.letterNewLineTextBox.Location = new System.Drawing.Point(97, 39);
			this.letterNewLineTextBox.Name = "letterNewLineTextBox";
			this.letterNewLineTextBox.Size = new System.Drawing.Size(48, 19);
			this.letterNewLineTextBox.TabIndex = 25;
			this.letterNewLineTextBox.Text = "28";
			this.letterNewLineTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// pixelNewLineRadioButton
			// 
			this.pixelNewLineRadioButton.AutoSize = true;
			this.pixelNewLineRadioButton.Location = new System.Drawing.Point(19, 62);
			this.pixelNewLineRadioButton.Name = "pixelNewLineRadioButton";
			this.pixelNewLineRadioButton.Size = new System.Drawing.Size(72, 16);
			this.pixelNewLineRadioButton.TabIndex = 26;
			this.pixelNewLineRadioButton.TabStop = true;
			this.pixelNewLineRadioButton.Text = "ピクセル数";
			this.pixelNewLineRadioButton.UseVisualStyleBackColor = true;
			this.pixelNewLineRadioButton.CheckedChanged += new System.EventHandler(this.OnPixelNewLineRadioButtonCheckedChanged);
			// 
			// letterNewLineRadioButton
			// 
			this.letterNewLineRadioButton.AutoSize = true;
			this.letterNewLineRadioButton.Location = new System.Drawing.Point(19, 40);
			this.letterNewLineRadioButton.Name = "letterNewLineRadioButton";
			this.letterNewLineRadioButton.Size = new System.Drawing.Size(59, 16);
			this.letterNewLineRadioButton.TabIndex = 24;
			this.letterNewLineRadioButton.TabStop = true;
			this.letterNewLineRadioButton.Text = "文字数";
			this.letterNewLineRadioButton.UseVisualStyleBackColor = true;
			this.letterNewLineRadioButton.CheckedChanged += new System.EventHandler(this.OnLetterNewLineRadioButtonCheckedChanged);
			// 
			// noNewLineRadioButton
			// 
			this.noNewLineRadioButton.AutoSize = true;
			this.noNewLineRadioButton.Checked = true;
			this.noNewLineRadioButton.Location = new System.Drawing.Point(19, 18);
			this.noNewLineRadioButton.Name = "noNewLineRadioButton";
			this.noNewLineRadioButton.Size = new System.Drawing.Size(76, 16);
			this.noNewLineRadioButton.TabIndex = 23;
			this.noNewLineRadioButton.TabStop = true;
			this.noNewLineRadioButton.Text = "付加しない";
			this.noNewLineRadioButton.UseVisualStyleBackColor = true;
			this.noNewLineRadioButton.CheckedChanged += new System.EventHandler(this.OnNoNewLineRadioButtonCheckedChanged);
			// 
			// referenceLanguageGroupBox
			// 
			this.referenceLanguageGroupBox.Controls.Add(this.referenceJapaneseRadioButton);
			this.referenceLanguageGroupBox.Controls.Add(this.referenceEnglishRadioButton);
			this.referenceLanguageGroupBox.Location = new System.Drawing.Point(25, 148);
			this.referenceLanguageGroupBox.Name = "referenceLanguageGroupBox";
			this.referenceLanguageGroupBox.Size = new System.Drawing.Size(187, 42);
			this.referenceLanguageGroupBox.TabIndex = 12;
			this.referenceLanguageGroupBox.TabStop = false;
			this.referenceLanguageGroupBox.Text = "参照フォルダの言語";
			// 
			// referenceJapaneseRadioButton
			// 
			this.referenceJapaneseRadioButton.AutoSize = true;
			this.referenceJapaneseRadioButton.Checked = true;
			this.referenceJapaneseRadioButton.Enabled = false;
			this.referenceJapaneseRadioButton.Location = new System.Drawing.Point(101, 18);
			this.referenceJapaneseRadioButton.Name = "referenceJapaneseRadioButton";
			this.referenceJapaneseRadioButton.Size = new System.Drawing.Size(59, 16);
			this.referenceJapaneseRadioButton.TabIndex = 14;
			this.referenceJapaneseRadioButton.TabStop = true;
			this.referenceJapaneseRadioButton.Text = "日本語";
			this.referenceJapaneseRadioButton.UseVisualStyleBackColor = true;
			// 
			// referenceEnglishRadioButton
			// 
			this.referenceEnglishRadioButton.AutoSize = true;
			this.referenceEnglishRadioButton.Enabled = false;
			this.referenceEnglishRadioButton.Location = new System.Drawing.Point(19, 18);
			this.referenceEnglishRadioButton.Name = "referenceEnglishRadioButton";
			this.referenceEnglishRadioButton.Size = new System.Drawing.Size(47, 16);
			this.referenceEnglishRadioButton.TabIndex = 13;
			this.referenceEnglishRadioButton.Text = "英語";
			this.referenceEnglishRadioButton.UseVisualStyleBackColor = true;
			// 
			// optionGroupBox
			// 
			this.optionGroupBox.Controls.Add(this.logMissingDefineCheckBox);
			this.optionGroupBox.Controls.Add(this.InsertEnglishTextCheckBox);
			this.optionGroupBox.Location = new System.Drawing.Point(25, 196);
			this.optionGroupBox.Name = "optionGroupBox";
			this.optionGroupBox.Size = new System.Drawing.Size(187, 62);
			this.optionGroupBox.TabIndex = 15;
			this.optionGroupBox.TabStop = false;
			this.optionGroupBox.Text = "オプション";
			// 
			// logMissingDefineCheckBox
			// 
			this.logMissingDefineCheckBox.AutoSize = true;
			this.logMissingDefineCheckBox.Checked = true;
			this.logMissingDefineCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.logMissingDefineCheckBox.Location = new System.Drawing.Point(19, 40);
			this.logMissingDefineCheckBox.Name = "logMissingDefineCheckBox";
			this.logMissingDefineCheckBox.Size = new System.Drawing.Size(164, 16);
			this.logMissingDefineCheckBox.TabIndex = 17;
			this.logMissingDefineCheckBox.Text = "存在しない定義名をログ出力";
			this.logMissingDefineCheckBox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 443);
			this.Controls.Add(this.optionGroupBox);
			this.Controls.Add(this.referenceLanguageGroupBox);
			this.Controls.Add(this.newLineGroupBox);
			this.Controls.Add(this.targetLanguageGroupBox);
			this.Controls.Add(this.logRichTextBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.lastLetterGroupBox);
			this.Controls.Add(this.outputFolderBrowseButton);
			this.Controls.Add(this.outputFolderTextBox);
			this.Controls.Add(this.targetFolderLabel);
			this.Controls.Add(this.outputFolderLabel);
			this.Controls.Add(this.referenceFolderLabel);
			this.Controls.Add(this.targetFolderBrowseButton);
			this.Controls.Add(this.referenceFolderTextBox);
			this.Controls.Add(this.targetFolderTextBox);
			this.Controls.Add(this.referenceFolderBrowseButton);
			this.Name = "MainForm";
			this.Text = "Config Reorganizer";
			this.lastLetterGroupBox.ResumeLayout(false);
			this.lastLetterGroupBox.PerformLayout();
			this.targetLanguageGroupBox.ResumeLayout(false);
			this.targetLanguageGroupBox.PerformLayout();
			this.newLineGroupBox.ResumeLayout(false);
			this.newLineGroupBox.PerformLayout();
			this.referenceLanguageGroupBox.ResumeLayout(false);
			this.referenceLanguageGroupBox.PerformLayout();
			this.optionGroupBox.ResumeLayout(false);
			this.optionGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button targetFolderBrowseButton;
		private System.Windows.Forms.TextBox targetFolderTextBox;
		private System.Windows.Forms.Label targetFolderLabel;
		private System.Windows.Forms.Button outputFolderBrowseButton;
		private System.Windows.Forms.TextBox outputFolderTextBox;
		private System.Windows.Forms.Label outputFolderLabel;
		private System.Windows.Forms.Button referenceFolderBrowseButton;
		private System.Windows.Forms.TextBox referenceFolderTextBox;
		private System.Windows.Forms.Label referenceFolderLabel;
		private System.Windows.Forms.CheckBox InsertEnglishTextCheckBox;
		private System.Windows.Forms.GroupBox lastLetterGroupBox;
		private System.Windows.Forms.RadioButton alwaysLargeRadioButton;
		private System.Windows.Forms.RadioButton alwaysSmallRadioButton;
		private System.Windows.Forms.RadioButton dontChangeRadioButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.RichTextBox logRichTextBox;
		private System.Windows.Forms.GroupBox targetLanguageGroupBox;
		private System.Windows.Forms.RadioButton targetJapaneseRadioButton;
		private System.Windows.Forms.RadioButton targetEnglishRadioButton;
		private System.Windows.Forms.GroupBox newLineGroupBox;
		private System.Windows.Forms.TextBox letterNewLineTextBox;
		private System.Windows.Forms.RadioButton pixelNewLineRadioButton;
		private System.Windows.Forms.RadioButton letterNewLineRadioButton;
		private System.Windows.Forms.RadioButton noNewLineRadioButton;
		private System.Windows.Forms.TextBox fontTextBox;
		private System.Windows.Forms.Label fontLabel;
		private System.Windows.Forms.Label pixelNewLineLabel;
		private System.Windows.Forms.Label letterNewLineLabel;
		private System.Windows.Forms.TextBox pixelNewLineTextBox;
		private System.Windows.Forms.Label pointLabel;
		private System.Windows.Forms.TextBox pointTextBox;
		private System.Windows.Forms.CheckBox wordWrapCheckBox;
		private System.Windows.Forms.Button browseFontButton;
		private System.Windows.Forms.GroupBox referenceLanguageGroupBox;
		private System.Windows.Forms.RadioButton referenceJapaneseRadioButton;
		private System.Windows.Forms.RadioButton referenceEnglishRadioButton;
		private System.Windows.Forms.CheckBox leaveNewLineCheckBox;
		private System.Windows.Forms.GroupBox optionGroupBox;
		private System.Windows.Forms.CheckBox logMissingDefineCheckBox;
	}
}