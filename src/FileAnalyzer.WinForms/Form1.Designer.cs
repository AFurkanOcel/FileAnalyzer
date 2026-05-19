namespace FileAnalyzer.WinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.filePathText = new System.Windows.Forms.RichTextBox();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.analyzeText = new System.Windows.Forms.RichTextBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.txtCheckBox = new System.Windows.Forms.CheckBox();
            this.docxCheckBox = new System.Windows.Forms.CheckBox();
            this.pdfCheckBox = new System.Windows.Forms.CheckBox();
            this.fileTypeLbl = new System.Windows.Forms.Label();
            this.AnalyzeBar = new System.Windows.Forms.ProgressBar();
            this.ExTxtRdBtn = new System.Windows.Forms.RadioButton();
            this.ExJsonRdBtn = new System.Windows.Forms.RadioButton();
            this.folderPicBox = new System.Windows.Forms.PictureBox();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.selectFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectFileBtn.Location = new System.Drawing.Point(26, 88);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(303, 46);
            this.selectFileBtn.TabIndex = 10;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = false;
            this.selectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // filePathText
            // 
            this.filePathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filePathText.Location = new System.Drawing.Point(73, 148);
            this.filePathText.Name = "filePathText";
            this.filePathText.ReadOnly = true;
            this.filePathText.Size = new System.Drawing.Size(256, 32);
            this.filePathText.TabIndex = 0;
            this.filePathText.Text = "";
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AnalyzeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnalyzeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnalyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnalyzeButton.Location = new System.Drawing.Point(26, 197);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(303, 46);
            this.AnalyzeButton.TabIndex = 11;
            this.AnalyzeButton.Text = "Analyze";
            this.AnalyzeButton.UseVisualStyleBackColor = false;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.exportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exportBtn.Location = new System.Drawing.Point(26, 419);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(218, 59);
            this.exportBtn.TabIndex = 12;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // analyzeText
            // 
            this.analyzeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeText.Location = new System.Drawing.Point(-2, -2);
            this.analyzeText.Name = "analyzeText";
            this.analyzeText.ReadOnly = true;
            this.analyzeText.Size = new System.Drawing.Size(303, 142);
            this.analyzeText.TabIndex = 0;
            this.analyzeText.Text = "";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Black;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl.Controls.Add(this.analyzeText);
            this.pnl.Location = new System.Drawing.Point(26, 259);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(303, 142);
            this.pnl.TabIndex = 1;
            // 
            // txtCheckBox
            // 
            this.txtCheckBox.AutoSize = true;
            this.txtCheckBox.Checked = true;
            this.txtCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txtCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCheckBox.Location = new System.Drawing.Point(26, 53);
            this.txtCheckBox.Name = "txtCheckBox";
            this.txtCheckBox.Size = new System.Drawing.Size(59, 29);
            this.txtCheckBox.TabIndex = 13;
            this.txtCheckBox.Text = ".txt";
            this.txtCheckBox.UseVisualStyleBackColor = true;
            // 
            // docxCheckBox
            // 
            this.docxCheckBox.AutoSize = true;
            this.docxCheckBox.Checked = true;
            this.docxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.docxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.docxCheckBox.Location = new System.Drawing.Point(91, 53);
            this.docxCheckBox.Name = "docxCheckBox";
            this.docxCheckBox.Size = new System.Drawing.Size(81, 29);
            this.docxCheckBox.TabIndex = 14;
            this.docxCheckBox.Text = ".docx";
            this.docxCheckBox.UseVisualStyleBackColor = true;
            // 
            // pdfCheckBox
            // 
            this.pdfCheckBox.AutoSize = true;
            this.pdfCheckBox.Checked = true;
            this.pdfCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pdfCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pdfCheckBox.Location = new System.Drawing.Point(178, 53);
            this.pdfCheckBox.Name = "pdfCheckBox";
            this.pdfCheckBox.Size = new System.Drawing.Size(66, 29);
            this.pdfCheckBox.TabIndex = 15;
            this.pdfCheckBox.Text = ".pdf";
            this.pdfCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileTypeLbl
            // 
            this.fileTypeLbl.AutoSize = true;
            this.fileTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileTypeLbl.Location = new System.Drawing.Point(20, 18);
            this.fileTypeLbl.Name = "fileTypeLbl";
            this.fileTypeLbl.Size = new System.Drawing.Size(131, 32);
            this.fileTypeLbl.TabIndex = 16;
            this.fileTypeLbl.Text = "File Type";
            // 
            // AnalyzeBar
            // 
            this.AnalyzeBar.BackColor = System.Drawing.Color.Gainsboro;
            this.AnalyzeBar.Location = new System.Drawing.Point(26, 233);
            this.AnalyzeBar.Name = "AnalyzeBar";
            this.AnalyzeBar.Size = new System.Drawing.Size(303, 10);
            this.AnalyzeBar.Step = 100;
            this.AnalyzeBar.TabIndex = 17;
            // 
            // ExTxtRdBtn
            // 
            this.ExTxtRdBtn.AutoSize = true;
            this.ExTxtRdBtn.Checked = true;
            this.ExTxtRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExTxtRdBtn.Location = new System.Drawing.Point(255, 419);
            this.ExTxtRdBtn.Name = "ExTxtRdBtn";
            this.ExTxtRdBtn.Size = new System.Drawing.Size(58, 29);
            this.ExTxtRdBtn.TabIndex = 18;
            this.ExTxtRdBtn.TabStop = true;
            this.ExTxtRdBtn.Text = ".txt";
            this.ExTxtRdBtn.UseVisualStyleBackColor = true;
            // 
            // ExJsonRdBtn
            // 
            this.ExJsonRdBtn.AutoSize = true;
            this.ExJsonRdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExJsonRdBtn.Location = new System.Drawing.Point(255, 449);
            this.ExJsonRdBtn.Name = "ExJsonRdBtn";
            this.ExJsonRdBtn.Size = new System.Drawing.Size(74, 29);
            this.ExJsonRdBtn.TabIndex = 19;
            this.ExJsonRdBtn.Text = ".json";
            this.ExJsonRdBtn.UseVisualStyleBackColor = true;
            // 
            // folderPicBox
            // 
            this.folderPicBox.Image = global::FileAnalyzer.WinForms.Properties.Resources.Folder;
            this.folderPicBox.Location = new System.Drawing.Point(26, 144);
            this.folderPicBox.Name = "folderPicBox";
            this.folderPicBox.Size = new System.Drawing.Size(40, 36);
            this.folderPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.folderPicBox.TabIndex = 9;
            this.folderPicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(357, 498);
            this.Controls.Add(this.ExJsonRdBtn);
            this.Controls.Add(this.ExTxtRdBtn);
            this.Controls.Add(this.AnalyzeBar);
            this.Controls.Add(this.fileTypeLbl);
            this.Controls.Add(this.pdfCheckBox);
            this.Controls.Add(this.docxCheckBox);
            this.Controls.Add(this.txtCheckBox);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.folderPicBox);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Analyzer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox folderPicBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.RichTextBox filePathText;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.RichTextBox analyzeText;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.CheckBox txtCheckBox;
        private System.Windows.Forms.CheckBox docxCheckBox;
        private System.Windows.Forms.CheckBox pdfCheckBox;
        private System.Windows.Forms.Label fileTypeLbl;
        private System.Windows.Forms.ProgressBar AnalyzeBar;
        private System.Windows.Forms.RadioButton ExTxtRdBtn;
        private System.Windows.Forms.RadioButton ExJsonRdBtn;
    }
}


