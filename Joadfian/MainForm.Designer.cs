namespace Joadfian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.keywordSearchLabel = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.keywordSearchButton = new System.Windows.Forms.Button();
            this.analysisTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.topHundredWords = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.specificWordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.specificWordCount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultLabel = new System.Windows.Forms.Label();
            this.jobsFoundLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.analysisTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem1
            // 
            this.programToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearResultTSMI,
            this.instructionsTSMI,
            this.aboutTSMI,
            this.exitTSMI});
            this.programToolStripMenuItem1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programToolStripMenuItem1.Name = "programToolStripMenuItem1";
            this.programToolStripMenuItem1.Size = new System.Drawing.Size(60, 22);
            this.programToolStripMenuItem1.Text = "Menu";
            // 
            // clearResultTSMI
            // 
            this.clearResultTSMI.Name = "clearResultTSMI";
            this.clearResultTSMI.Size = new System.Drawing.Size(165, 22);
            this.clearResultTSMI.Text = "Clear Result";
            this.clearResultTSMI.Click += new System.EventHandler(this.clearResultTSMI_Click);
            // 
            // instructionsTSMI
            // 
            this.instructionsTSMI.Name = "instructionsTSMI";
            this.instructionsTSMI.Size = new System.Drawing.Size(165, 22);
            this.instructionsTSMI.Text = "How To Use";
            this.instructionsTSMI.Click += new System.EventHandler(this.instructionsTSMI_Click);
            // 
            // aboutTSMI
            // 
            this.aboutTSMI.Name = "aboutTSMI";
            this.aboutTSMI.Size = new System.Drawing.Size(165, 22);
            this.aboutTSMI.Text = "About";
            this.aboutTSMI.Click += new System.EventHandler(this.aboutTSMI_Click);
            // 
            // exitTSMI
            // 
            this.exitTSMI.Name = "exitTSMI";
            this.exitTSMI.Size = new System.Drawing.Size(165, 22);
            this.exitTSMI.Text = "Exit";
            this.exitTSMI.Click += new System.EventHandler(this.exitTSMI_Click);
            // 
            // keywordSearchLabel
            // 
            this.keywordSearchLabel.AutoSize = true;
            this.keywordSearchLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordSearchLabel.Location = new System.Drawing.Point(16, 43);
            this.keywordSearchLabel.Name = "keywordSearchLabel";
            this.keywordSearchLabel.Size = new System.Drawing.Size(128, 18);
            this.keywordSearchLabel.TabIndex = 1;
            this.keywordSearchLabel.Text = "Keyword Search:";
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordTextBox.Location = new System.Drawing.Point(150, 40);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(729, 26);
            this.keywordTextBox.TabIndex = 2;
            // 
            // keywordSearchButton
            // 
            this.keywordSearchButton.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordSearchButton.Location = new System.Drawing.Point(891, 37);
            this.keywordSearchButton.Name = "keywordSearchButton";
            this.keywordSearchButton.Size = new System.Drawing.Size(101, 32);
            this.keywordSearchButton.TabIndex = 3;
            this.keywordSearchButton.Text = "Search";
            this.keywordSearchButton.UseVisualStyleBackColor = true;
            this.keywordSearchButton.Click += new System.EventHandler(this.keywordSearchButton_Click);
            // 
            // analysisTabs
            // 
            this.analysisTabs.Controls.Add(this.tabPage1);
            this.analysisTabs.Controls.Add(this.tabPage2);
            this.analysisTabs.Controls.Add(this.tabPage3);
            this.analysisTabs.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisTabs.Location = new System.Drawing.Point(15, 291);
            this.analysisTabs.Name = "analysisTabs";
            this.analysisTabs.SelectedIndex = 0;
            this.analysisTabs.Size = new System.Drawing.Size(981, 377);
            this.analysisTabs.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.topHundredWords);
            this.tabPage1.Controls.Add(this.countButton);
            this.tabPage1.Controls.Add(this.specificWordTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.specificWordCount);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description Analysis";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Most Common Words:";
            // 
            // topHundredWords
            // 
            this.topHundredWords.Location = new System.Drawing.Point(34, 33);
            this.topHundredWords.Multiline = true;
            this.topHundredWords.Name = "topHundredWords";
            this.topHundredWords.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.topHundredWords.Size = new System.Drawing.Size(366, 300);
            this.topHundredWords.TabIndex = 8;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(851, 15);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(95, 44);
            this.countButton.TabIndex = 7;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // specificWordTextBox
            // 
            this.specificWordTextBox.Location = new System.Drawing.Point(431, 33);
            this.specificWordTextBox.Name = "specificWordTextBox";
            this.specificWordTextBox.Size = new System.Drawing.Size(405, 26);
            this.specificWordTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count specific words/phrases:";
            // 
            // specificWordCount
            // 
            this.specificWordCount.Location = new System.Drawing.Point(431, 75);
            this.specificWordCount.Multiline = true;
            this.specificWordCount.Name = "specificWordCount";
            this.specificWordCount.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.specificWordCount.Size = new System.Drawing.Size(515, 258);
            this.specificWordCount.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 459);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 119);
            this.textBox1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Job Analysis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(973, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Company Analysis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resultsListView
            // 
            this.resultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.resultsListView.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListView.FullRowSelect = true;
            this.resultsListView.GridLines = true;
            this.resultsListView.Location = new System.Drawing.Point(19, 127);
            this.resultsListView.Name = "resultsListView";
            this.resultsListView.Size = new System.Drawing.Size(973, 149);
            this.resultsListView.TabIndex = 0;
            this.resultsListView.UseCompatibleStateImageBehavior = false;
            this.resultsListView.View = System.Windows.Forms.View.Details;
            this.resultsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultsListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Job ID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Job Title";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Job Description";
            this.columnHeader3.Width = 619;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(15, 86);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(123, 20);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Search Results:";
            // 
            // jobsFoundLabel
            // 
            this.jobsFoundLabel.AutoSize = true;
            this.jobsFoundLabel.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsFoundLabel.Location = new System.Drawing.Point(134, 86);
            this.jobsFoundLabel.Name = "jobsFoundLabel";
            this.jobsFoundLabel.Size = new System.Drawing.Size(101, 20);
            this.jobsFoundLabel.TabIndex = 4;
            this.jobsFoundLabel.Text = "0 jobs found.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.jobsFoundLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.analysisTabs);
            this.Controls.Add(this.keywordSearchButton);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.resultsListView);
            this.Controls.Add(this.keywordSearchLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Advertisement Filtering and Analysis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.analysisTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearResultTSMI;
        private System.Windows.Forms.ToolStripMenuItem instructionsTSMI;
        private System.Windows.Forms.ToolStripMenuItem aboutTSMI;
        private System.Windows.Forms.Label keywordSearchLabel;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Button keywordSearchButton;
        private System.Windows.Forms.TabControl analysisTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView resultsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label jobsFoundLabel;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox specificWordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox specificWordCount;
        private System.Windows.Forms.TextBox topHundredWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exitTSMI;
    }
}

