namespace BaekjoonOnlineJudge
{
    partial class ProblemForm
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
            this.contestStatusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.problemTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.additionalFileListView = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileLocationLabel = new System.Windows.Forms.Label();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.problemComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusListview = new System.Windows.Forms.ListView();
            this.submissionCountLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.questionButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.questionProblemComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.problemTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // contestStatusLabel
            // 
            this.contestStatusLabel.AutoSize = true;
            this.contestStatusLabel.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.contestStatusLabel.Location = new System.Drawing.Point(13, 13);
            this.contestStatusLabel.Name = "contestStatusLabel";
            this.contestStatusLabel.Size = new System.Drawing.Size(0, 21);
            this.contestStatusLabel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // problemTabControl
            // 
            this.problemTabControl.Controls.Add(this.tabPage1);
            this.problemTabControl.Controls.Add(this.tabPage2);
            this.problemTabControl.Controls.Add(this.tabPage3);
            this.problemTabControl.Controls.Add(this.tabPage4);
            this.problemTabControl.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.problemTabControl.Location = new System.Drawing.Point(0, 54);
            this.problemTabControl.Name = "problemTabControl";
            this.problemTabControl.SelectedIndex = 0;
            this.problemTabControl.Size = new System.Drawing.Size(544, 433);
            this.problemTabControl.TabIndex = 2;
            this.problemTabControl.SelectedIndexChanged += new System.EventHandler(this.problemTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.submitButton);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(536, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "제출";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.additionalFileListView);
            this.groupBox4.Location = new System.Drawing.Point(13, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 126);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(276, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "제거";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(84, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "추가";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // additionalFileListView
            // 
            this.additionalFileListView.AllowColumnReorder = true;
            this.additionalFileListView.FullRowSelect = true;
            this.additionalFileListView.GridLines = true;
            this.additionalFileListView.Location = new System.Drawing.Point(0, 8);
            this.additionalFileListView.Name = "additionalFileListView";
            this.additionalFileListView.Size = new System.Drawing.Size(433, 78);
            this.additionalFileListView.TabIndex = 0;
            this.additionalFileListView.UseCompatibleStateImageBehavior = false;
            this.additionalFileListView.View = System.Windows.Forms.View.Details;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(56, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "테스트";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(371, 349);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "제출";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fileLocationLabel);
            this.groupBox3.Controls.Add(this.fileSelectButton);
            this.groupBox3.Location = new System.Drawing.Point(13, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "파일";
            // 
            // fileLocationLabel
            // 
            this.fileLocationLabel.AutoEllipsis = true;
            this.fileLocationLabel.Location = new System.Drawing.Point(7, 19);
            this.fileLocationLabel.Name = "fileLocationLabel";
            this.fileLocationLabel.Size = new System.Drawing.Size(366, 19);
            this.fileLocationLabel.TabIndex = 1;
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Location = new System.Drawing.Point(379, 15);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(47, 27);
            this.fileSelectButton.TabIndex = 0;
            this.fileSelectButton.Text = "선택";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.fileSelectButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.languageComboBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "언어";
            // 
            // languageComboBox
            // 
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "언어를 선택해 주세요."});
            this.languageComboBox.Location = new System.Drawing.Point(7, 20);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(322, 27);
            this.languageComboBox.TabIndex = 0;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.problemComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "문제";
            // 
            // problemComboBox
            // 
            this.problemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.problemComboBox.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.problemComboBox.FormattingEnabled = true;
            this.problemComboBox.Items.AddRange(new object[] {
            "문제를 선택해 주세요."});
            this.problemComboBox.Location = new System.Drawing.Point(7, 21);
            this.problemComboBox.Name = "problemComboBox";
            this.problemComboBox.Size = new System.Drawing.Size(420, 27);
            this.problemComboBox.TabIndex = 0;
            this.problemComboBox.SelectedIndexChanged += new System.EventHandler(this.problemComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.statusListview);
            this.tabPage2.Controls.Add(this.submissionCountLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(536, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "제출 현황";
            // 
            // statusListview
            // 
            this.statusListview.FullRowSelect = true;
            this.statusListview.GridLines = true;
            this.statusListview.Location = new System.Drawing.Point(0, 29);
            this.statusListview.Name = "statusListview";
            this.statusListview.Size = new System.Drawing.Size(535, 342);
            this.statusListview.TabIndex = 1;
            this.statusListview.UseCompatibleStateImageBehavior = false;
            this.statusListview.View = System.Windows.Forms.View.Details;
            // 
            // submissionCountLabel
            // 
            this.submissionCountLabel.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.submissionCountLabel.Location = new System.Drawing.Point(492, 7);
            this.submissionCountLabel.Name = "submissionCountLabel";
            this.submissionCountLabel.Size = new System.Drawing.Size(38, 22);
            this.submissionCountLabel.TabIndex = 0;
            this.submissionCountLabel.Text = "0";
            this.submissionCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.questionButton);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(536, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "질문 하기";
            // 
            // questionButton
            // 
            this.questionButton.Location = new System.Drawing.Point(20, 267);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(214, 35);
            this.questionButton.TabIndex = 3;
            this.questionButton.Text = "질문하기";
            this.questionButton.UseVisualStyleBackColor = true;
            this.questionButton.Click += new System.EventHandler(this.questionButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.questionTextBox);
            this.groupBox6.Location = new System.Drawing.Point(13, 92);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(433, 158);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "질문";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(7, 22);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(420, 130);
            this.questionTextBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.questionProblemComboBox);
            this.groupBox5.Location = new System.Drawing.Point(13, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 57);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "문제";
            // 
            // questionProblemComboBox
            // 
            this.questionProblemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionProblemComboBox.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.questionProblemComboBox.FormattingEnabled = true;
            this.questionProblemComboBox.Items.AddRange(new object[] {
            "문제를 선택해 주세요."});
            this.questionProblemComboBox.Location = new System.Drawing.Point(7, 21);
            this.questionProblemComboBox.Name = "questionProblemComboBox";
            this.questionProblemComboBox.Size = new System.Drawing.Size(420, 27);
            this.questionProblemComboBox.TabIndex = 0;
            this.questionProblemComboBox.SelectedIndexChanged += new System.EventHandler(this.questionProblemComboBox_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(536, 405);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "질문 보기";
            // 
            // ProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 488);
            this.Controls.Add(this.problemTabControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contestStatusLabel);
            this.Name = "ProblemForm";
            this.Text = "Baekjoon Online Judge Contest Client";
            this.Load += new System.EventHandler(this.ProblemForm_Load);
            this.problemTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contestStatusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl problemTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox problemComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.Label fileLocationLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView additionalFileListView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label submissionCountLabel;
        private System.Windows.Forms.ListView statusListview;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox questionProblemComboBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Button questionButton;
    }
}