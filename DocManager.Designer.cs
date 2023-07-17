namespace DocumentManager
{
    partial class DocManager
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
            panel1 = new Panel();
            btnCopyFile = new Button();
            txtFCto = new TextBox();
            txtFCFrom = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnDeleteFile = new Button();
            txtFDPath = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            btnQueryFiles = new Button();
            txtQFPath = new TextBox();
            label7 = new Label();
            label6 = new Label();
            lstQLView = new ListBox();
            panel4 = new Panel();
            label9 = new Label();
            txtCFFolderName = new TextBox();
            txtCFPath = new TextBox();
            btnCF = new Button();
            lblCFPath = new Label();
            label8 = new Label();
            panel5 = new Panel();
            btnSubmitWait = new Button();
            txtWait = new TextBox();
            lblWait = new Label();
            label10 = new Label();
            panel6 = new Panel();
            btnSearch = new Button();
            label11 = new Label();
            lblSearchFilePath = new Label();
            txtSearchString = new TextBox();
            txtFilePath = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyFile);
            panel1.Controls.Add(txtFCto);
            panel1.Controls.Add(txtFCFrom);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 167);
            panel1.TabIndex = 0;
            // 
            // btnCopyFile
            // 
            btnCopyFile.Location = new Point(643, 106);
            btnCopyFile.Name = "btnCopyFile";
            btnCopyFile.Size = new Size(112, 34);
            btnCopyFile.TabIndex = 5;
            btnCopyFile.Text = "Copy File";
            btnCopyFile.UseVisualStyleBackColor = true;
            btnCopyFile.Click += btnCopyFile_Click;
            // 
            // txtFCto
            // 
            txtFCto.Location = new Point(389, 106);
            txtFCto.Name = "txtFCto";
            txtFCto.Size = new Size(150, 31);
            txtFCto.TabIndex = 4;
            // 
            // txtFCFrom
            // 
            txtFCFrom.Location = new Point(58, 108);
            txtFCFrom.Name = "txtFCFrom";
            txtFCFrom.Size = new Size(150, 31);
            txtFCFrom.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 57);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 2;
            label3.Text = "To";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 57);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "From";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 3);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "File Copy";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDeleteFile);
            panel2.Controls.Add(txtFDPath);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 133);
            panel2.TabIndex = 1;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(641, 64);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(112, 34);
            btnDeleteFile.TabIndex = 3;
            btnDeleteFile.Text = "Delete File";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // txtFDPath
            // 
            txtFDPath.Location = new Point(170, 64);
            txtFDPath.Name = "txtFDPath";
            txtFDPath.Size = new Size(367, 31);
            txtFDPath.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 70);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 1;
            label5.Text = "File Path";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 8);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 0;
            label4.Text = "File Delete";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnQueryFiles);
            panel3.Controls.Add(txtQFPath);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(12, 324);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 146);
            panel3.TabIndex = 2;
            // 
            // btnQueryFiles
            // 
            btnQueryFiles.Location = new Point(641, 64);
            btnQueryFiles.Name = "btnQueryFiles";
            btnQueryFiles.Size = new Size(112, 34);
            btnQueryFiles.TabIndex = 3;
            btnQueryFiles.Text = "List Files";
            btnQueryFiles.UseVisualStyleBackColor = true;
            btnQueryFiles.Click += btnQueryFiles_Click;
            // 
            // txtQFPath
            // 
            txtQFPath.Location = new Point(170, 67);
            txtQFPath.Name = "txtQFPath";
            txtQFPath.Size = new Size(367, 31);
            txtQFPath.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 73);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 1;
            label7.Text = "File Path";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 11);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 0;
            label6.Text = "Query Folder Files";
            // 
            // lstQLView
            // 
            lstQLView.FormattingEnabled = true;
            lstQLView.ItemHeight = 25;
            lstQLView.Location = new Point(12, 476);
            lstQLView.Name = "lstQLView";
            lstQLView.Size = new Size(776, 104);
            lstQLView.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtCFFolderName);
            panel4.Controls.Add(txtCFPath);
            panel4.Controls.Add(btnCF);
            panel4.Controls.Add(lblCFPath);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(14, 586);
            panel4.Name = "panel4";
            panel4.Size = new Size(774, 150);
            panel4.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 111);
            label9.Name = "label9";
            label9.Size = new Size(154, 25);
            label9.TabIndex = 5;
            label9.Text = "New Folder Name";
            // 
            // txtCFFolderName
            // 
            txtCFFolderName.Location = new Point(253, 105);
            txtCFFolderName.Name = "txtCFFolderName";
            txtCFFolderName.Size = new Size(282, 31);
            txtCFFolderName.TabIndex = 4;
            // 
            // txtCFPath
            // 
            txtCFPath.Location = new Point(253, 55);
            txtCFPath.Name = "txtCFPath";
            txtCFPath.Size = new Size(282, 31);
            txtCFPath.TabIndex = 3;
            // 
            // btnCF
            // 
            btnCF.Location = new Point(630, 52);
            btnCF.Name = "btnCF";
            btnCF.Size = new Size(112, 34);
            btnCF.TabIndex = 2;
            btnCF.Text = "Create Folder";
            btnCF.UseVisualStyleBackColor = true;
            btnCF.Click += btnCF_Click;
            // 
            // lblCFPath
            // 
            lblCFPath.AutoSize = true;
            lblCFPath.Location = new Point(32, 61);
            lblCFPath.Name = "lblCFPath";
            lblCFPath.Size = new Size(46, 25);
            lblCFPath.TabIndex = 1;
            lblCFPath.Text = "Path";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 10);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 0;
            label8.Text = "Create Folder";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSubmitWait);
            panel5.Controls.Add(txtWait);
            panel5.Controls.Add(lblWait);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(14, 742);
            panel5.Name = "panel5";
            panel5.Size = new Size(774, 100);
            panel5.TabIndex = 6;
            // 
            // btnSubmitWait
            // 
            btnSubmitWait.Location = new Point(630, 45);
            btnSubmitWait.Name = "btnSubmitWait";
            btnSubmitWait.Size = new Size(112, 34);
            btnSubmitWait.TabIndex = 4;
            btnSubmitWait.Text = "Submit";
            btnSubmitWait.UseVisualStyleBackColor = true;
            btnSubmitWait.Click += btnSubmitWait_Click;
            // 
            // txtWait
            // 
            txtWait.Location = new Point(253, 50);
            txtWait.Name = "txtWait";
            txtWait.Size = new Size(282, 31);
            txtWait.TabIndex = 2;
            // 
            // lblWait
            // 
            lblWait.AutoSize = true;
            lblWait.Location = new Point(32, 50);
            lblWait.Name = "lblWait";
            lblWait.Size = new Size(139, 25);
            lblWait.TabIndex = 1;
            lblWait.Text = "Wait In Seconds";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 13);
            label10.Name = "label10";
            label10.Size = new Size(47, 25);
            label10.TabIndex = 0;
            label10.Text = "Wait";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSearch);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(lblSearchFilePath);
            panel6.Controls.Add(txtSearchString);
            panel6.Controls.Add(txtFilePath);
            panel6.Location = new Point(14, 848);
            panel6.Name = "panel6";
            panel6.Size = new Size(774, 120);
            panel6.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(630, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(71, 83);
            label11.Name = "label11";
            label11.Size = new Size(115, 25);
            label11.TabIndex = 3;
            label11.Text = "Search String";
            // 
            // lblSearchFilePath
            // 
            lblSearchFilePath.AutoSize = true;
            lblSearchFilePath.Location = new Point(71, 31);
            lblSearchFilePath.Name = "lblSearchFilePath";
            lblSearchFilePath.Size = new Size(77, 25);
            lblSearchFilePath.TabIndex = 2;
            lblSearchFilePath.Text = "File Path";
            // 
            // txtSearchString
            // 
            txtSearchString.Location = new Point(254, 80);
            txtSearchString.Name = "txtSearchString";
            txtSearchString.Size = new Size(278, 31);
            txtSearchString.TabIndex = 1;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(253, 25);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(279, 31);
            txtFilePath.TabIndex = 0;
            // 
            // DocManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1050);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(lstQLView);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DocManager";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCopyFile;
        private TextBox txtFCto;
        private TextBox txtFCFrom;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Button btnDeleteFile;
        private TextBox txtFDPath;
        private Label label5;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Button btnQueryFiles;
        private TextBox txtQFPath;
        private ListBox lstQLView;
        private Panel panel4;
        private TextBox txtCFPath;
        private Button btnCF;
        private Label lblCFPath;
        private Label label8;
        private Label label9;
        private TextBox txtCFFolderName;
        private Panel panel5;
        private TextBox txtWait;
        private Label lblWait;
        private Label label10;
        private Button btnSubmitWait;
        private Panel panel6;
        private Button btnSearch;
        private Label label11;
        private Label lblSearchFilePath;
        private TextBox txtSearchString;
        private TextBox txtFilePath;
    }
}