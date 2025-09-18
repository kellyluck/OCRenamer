namespace OCRenamer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGo = new Button();
            btnExit = new Button();
            txtRulesetPreview = new TextBox();
            label1 = new Label();
            btnLoadRuleset = new Button();
            txtRulesetFilename = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnDirSelect = new Button();
            txtDirectory = new TextBox();
            groupBox1 = new GroupBox();
            rbCopy = new RadioButton();
            txtCopyDirectory = new TextBox();
            btnSelectCopyDirectory = new Button();
            rbRename = new RadioButton();
            chkDryRun = new CheckBox();
            chkOverwrite = new CheckBox();
            lstLog = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.Lime;
            btnGo.Location = new Point(632, 491);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 31);
            btnGo.TabIndex = 0;
            btnGo.Text = "Go!";
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(713, 491);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 31);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txtRulesetPreview
            // 
            txtRulesetPreview.Location = new Point(12, 80);
            txtRulesetPreview.Multiline = true;
            txtRulesetPreview.Name = "txtRulesetPreview";
            txtRulesetPreview.ReadOnly = true;
            txtRulesetPreview.ScrollBars = ScrollBars.Both;
            txtRulesetPreview.Size = new Size(389, 150);
            txtRulesetPreview.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Ruleset:";
            // 
            // btnLoadRuleset
            // 
            btnLoadRuleset.BackColor = SystemColors.Control;
            btnLoadRuleset.Location = new Point(326, 12);
            btnLoadRuleset.Name = "btnLoadRuleset";
            btnLoadRuleset.Size = new Size(75, 31);
            btnLoadRuleset.TabIndex = 4;
            btnLoadRuleset.Text = "Select";
            btnLoadRuleset.UseVisualStyleBackColor = false;
            btnLoadRuleset.Click += btnLoadRuleset_Click;
            // 
            // txtRulesetFilename
            // 
            txtRulesetFilename.Location = new Point(78, 14);
            txtRulesetFilename.Name = "txtRulesetFilename";
            txtRulesetFilename.Size = new Size(242, 27);
            txtRulesetFilename.TabIndex = 5;
            txtRulesetFilename.Text = "F:\\Documents\\Source\\Repos\\kellyluck\\OCRenamer\\OCRenamer\\MatineeBnR.json";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 6;
            label2.Text = "Preview:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 17);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Files:";
            // 
            // btnDirSelect
            // 
            btnDirSelect.Location = new Point(713, 12);
            btnDirSelect.Name = "btnDirSelect";
            btnDirSelect.Size = new Size(75, 31);
            btnDirSelect.TabIndex = 8;
            btnDirSelect.Text = "Select";
            btnDirSelect.UseVisualStyleBackColor = true;
            btnDirSelect.Click += btnDirSelect_Click;
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(454, 14);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new Size(253, 27);
            txtDirectory.TabIndex = 9;
            txtDirectory.Text = "I:\\Radio Programs\\Bob & Ray\\Matinee With Bob Ray";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbCopy);
            groupBox1.Controls.Add(txtCopyDirectory);
            groupBox1.Controls.Add(btnSelectCopyDirectory);
            groupBox1.Controls.Add(rbRename);
            groupBox1.Controls.Add(chkDryRun);
            groupBox1.Controls.Add(chkOverwrite);
            groupBox1.Location = new Point(407, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 181);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Behavior";
            // 
            // rbCopy
            // 
            rbCopy.AutoSize = true;
            rbCopy.Checked = true;
            rbCopy.Location = new Point(6, 116);
            rbCopy.Name = "rbCopy";
            rbCopy.Size = new Size(176, 24);
            rbCopy.TabIndex = 13;
            rbCopy.TabStop = true;
            rbCopy.Text = "Copy to new directory:";
            rbCopy.UseVisualStyleBackColor = true;
            // 
            // txtCopyDirectory
            // 
            txtCopyDirectory.Location = new Point(25, 146);
            txtCopyDirectory.Name = "txtCopyDirectory";
            txtCopyDirectory.Size = new Size(269, 27);
            txtCopyDirectory.TabIndex = 12;
            txtCopyDirectory.Text = "I:\\Radio Programs\\Bob & Ray\\Matinee With Bob Ray\\RenameUs";
            // 
            // btnSelectCopyDirectory
            // 
            btnSelectCopyDirectory.Location = new Point(300, 142);
            btnSelectCopyDirectory.Name = "btnSelectCopyDirectory";
            btnSelectCopyDirectory.Size = new Size(75, 31);
            btnSelectCopyDirectory.TabIndex = 11;
            btnSelectCopyDirectory.Text = "Select";
            btnSelectCopyDirectory.UseVisualStyleBackColor = true;
            btnSelectCopyDirectory.Click += btnSelectCopyDirectory_Click;
            // 
            // rbRename
            // 
            rbRename.AutoSize = true;
            rbRename.Location = new Point(6, 86);
            rbRename.Name = "rbRename";
            rbRename.Size = new Size(139, 24);
            rbRename.TabIndex = 2;
            rbRename.Text = "Rename in-place";
            rbRename.UseVisualStyleBackColor = true;
            // 
            // chkDryRun
            // 
            chkDryRun.AutoSize = true;
            chkDryRun.Location = new Point(6, 56);
            chkDryRun.Name = "chkDryRun";
            chkDryRun.Size = new Size(289, 24);
            chkDryRun.TabIndex = 1;
            chkDryRun.Text = "Dry run only (does not actually rename)";
            chkDryRun.UseVisualStyleBackColor = true;
            // 
            // chkOverwrite
            // 
            chkOverwrite.AutoSize = true;
            chkOverwrite.Checked = true;
            chkOverwrite.CheckState = CheckState.Checked;
            chkOverwrite.Location = new Point(6, 26);
            chkOverwrite.Name = "chkOverwrite";
            chkOverwrite.Size = new Size(178, 24);
            chkOverwrite.TabIndex = 0;
            chkOverwrite.Text = "Overwrite existing files";
            chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(12, 244);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(770, 244);
            lstLog.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(lstLog);
            Controls.Add(groupBox1);
            Controls.Add(txtDirectory);
            Controls.Add(btnDirSelect);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtRulesetFilename);
            Controls.Add(btnLoadRuleset);
            Controls.Add(label1);
            Controls.Add(txtRulesetPreview);
            Controls.Add(btnExit);
            Controls.Add(btnGo);
            Name = "Form1";
            Text = "The Overly Complicated Renamer (tm)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGo;
        private Button btnExit;
        private TextBox txtRulesetPreview;
        private Label label1;
        private Button btnLoadRuleset;
        private TextBox txtRulesetFilename;
        private Label label2;
        private Label label3;
        private Button btnDirSelect;
        private TextBox txtDirectory;
        private GroupBox groupBox1;
        private CheckBox chkOverwrite;
        private CheckBox chkDryRun;
        private RadioButton rbRename;
        private RadioButton rbCopy;
        private TextBox txtCopyDirectory;
        private Button btnSelectCopyDirectory;
        private ListBox lstLog;
    }
}
