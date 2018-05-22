namespace FileFinder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnGetCurrentPath = new System.Windows.Forms.Button();
            this.grbPath = new System.Windows.Forms.GroupBox();
            this.lblOption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgrList = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.rdbFileGreaterThenSize = new System.Windows.Forms.RadioButton();
            this.rdbFileLessThenSize = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbFolderGreaterThenSize = new System.Windows.Forms.RadioButton();
            this.rdbFolderLessThenSize = new System.Windows.Forms.RadioButton();
            this.rdbByFolderName = new System.Windows.Forms.RadioButton();
            this.rdbByFileExt = new System.Windows.Forms.RadioButton();
            this.rdbByFileName = new System.Windows.Forms.RadioButton();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnDelRows = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.grbPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrList)).BeginInit();
            this.grbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPath.Location = new System.Drawing.Point(10, 30);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(335, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnGetCurrentPath
            // 
            this.btnGetCurrentPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGetCurrentPath.Location = new System.Drawing.Point(361, 30);
            this.btnGetCurrentPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetCurrentPath.Name = "btnGetCurrentPath";
            this.btnGetCurrentPath.Size = new System.Drawing.Size(142, 23);
            this.btnGetCurrentPath.TabIndex = 2;
            this.btnGetCurrentPath.Text = "Get Current Path";
            this.btnGetCurrentPath.UseVisualStyleBackColor = true;
            this.btnGetCurrentPath.Click += new System.EventHandler(this.btnGetCurrentPath_Click);
            // 
            // grbPath
            // 
            this.grbPath.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.grbPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbPath.BackgroundImage")));
            this.grbPath.Controls.Add(this.lblOption);
            this.grbPath.Controls.Add(this.label1);
            this.grbPath.Controls.Add(this.txtSearch);
            this.grbPath.Controls.Add(this.btnSearch);
            this.grbPath.Controls.Add(this.btnGetCurrentPath);
            this.grbPath.Controls.Add(this.txtPath);
            this.grbPath.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grbPath.Location = new System.Drawing.Point(12, 160);
            this.grbPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbPath.Name = "grbPath";
            this.grbPath.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbPath.Size = new System.Drawing.Size(512, 149);
            this.grbPath.TabIndex = 3;
            this.grbPath.TabStop = false;
            this.grbPath.Text = "Path  and  Search options";
            this.grbPath.UseCompatibleTextRendering = true;
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.BackColor = System.Drawing.Color.Transparent;
            this.lblOption.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblOption.Location = new System.Drawing.Point(120, 106);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(187, 15);
            this.lblOption.TabIndex = 10;
            this.lblOption.Text = "file extension like mp3, psd, etc...";
            this.lblOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search pattern";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(121, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.MaxLength = 30;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 21);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearch.Location = new System.Drawing.Point(431, 74);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgrList
            // 
            this.dgrList.AllowUserToAddRows = false;
            this.dgrList.AllowUserToResizeColumns = false;
            this.dgrList.AllowUserToResizeRows = false;
            this.dgrList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgrList.Location = new System.Drawing.Point(12, 325);
            this.dgrList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgrList.Name = "dgrList";
            this.dgrList.Size = new System.Drawing.Size(512, 326);
            this.dgrList.TabIndex = 4;
            this.dgrList.Visible = false;
            this.dgrList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrList_CellContentClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(10, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // grbOptions
            // 
            this.grbOptions.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.grbOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbOptions.BackgroundImage")));
            this.grbOptions.Controls.Add(this.rdbFileGreaterThenSize);
            this.grbOptions.Controls.Add(this.rdbFileLessThenSize);
            this.grbOptions.Controls.Add(this.label3);
            this.grbOptions.Controls.Add(this.label2);
            this.grbOptions.Controls.Add(this.rdbFolderGreaterThenSize);
            this.grbOptions.Controls.Add(this.rdbFolderLessThenSize);
            this.grbOptions.Controls.Add(this.rdbByFolderName);
            this.grbOptions.Controls.Add(this.rdbByFileExt);
            this.grbOptions.Controls.Add(this.rdbByFileName);
            this.grbOptions.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grbOptions.Location = new System.Drawing.Point(12, 34);
            this.grbOptions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grbOptions.Size = new System.Drawing.Size(512, 111);
            this.grbOptions.TabIndex = 6;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Search Options";
            this.grbOptions.UseCompatibleTextRendering = true;
            // 
            // rdbFileGreaterThenSize
            // 
            this.rdbFileGreaterThenSize.AutoSize = true;
            this.rdbFileGreaterThenSize.BackColor = System.Drawing.Color.Transparent;
            this.rdbFileGreaterThenSize.Enabled = false;
            this.rdbFileGreaterThenSize.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFileGreaterThenSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbFileGreaterThenSize.Location = new System.Drawing.Point(423, 35);
            this.rdbFileGreaterThenSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbFileGreaterThenSize.Name = "rdbFileGreaterThenSize";
            this.rdbFileGreaterThenSize.Size = new System.Drawing.Size(81, 17);
            this.rdbFileGreaterThenSize.TabIndex = 21;
            this.rdbFileGreaterThenSize.Text = "> File Size";
            this.rdbFileGreaterThenSize.UseVisualStyleBackColor = false;
            this.rdbFileGreaterThenSize.CheckedChanged += new System.EventHandler(this.rdbFileGreaterThenSize_CheckedChanged);
            // 
            // rdbFileLessThenSize
            // 
            this.rdbFileLessThenSize.AutoSize = true;
            this.rdbFileLessThenSize.BackColor = System.Drawing.Color.Transparent;
            this.rdbFileLessThenSize.Enabled = false;
            this.rdbFileLessThenSize.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFileLessThenSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbFileLessThenSize.Location = new System.Drawing.Point(336, 35);
            this.rdbFileLessThenSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbFileLessThenSize.Name = "rdbFileLessThenSize";
            this.rdbFileLessThenSize.Size = new System.Drawing.Size(81, 17);
            this.rdbFileLessThenSize.TabIndex = 20;
            this.rdbFileLessThenSize.TabStop = true;
            this.rdbFileLessThenSize.Text = "< File Size";
            this.rdbFileLessThenSize.UseVisualStyleBackColor = false;
            this.rdbFileLessThenSize.CheckedChanged += new System.EventHandler(this.rdbFileLessThenSize_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Folder search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "File search";
            // 
            // rdbFolderGreaterThenSize
            // 
            this.rdbFolderGreaterThenSize.AutoSize = true;
            this.rdbFolderGreaterThenSize.BackColor = System.Drawing.Color.Transparent;
            this.rdbFolderGreaterThenSize.Enabled = false;
            this.rdbFolderGreaterThenSize.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFolderGreaterThenSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbFolderGreaterThenSize.Location = new System.Drawing.Point(333, 70);
            this.rdbFolderGreaterThenSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbFolderGreaterThenSize.Name = "rdbFolderGreaterThenSize";
            this.rdbFolderGreaterThenSize.Size = new System.Drawing.Size(104, 17);
            this.rdbFolderGreaterThenSize.TabIndex = 17;
            this.rdbFolderGreaterThenSize.Text = "> Folder Size";
            this.rdbFolderGreaterThenSize.UseVisualStyleBackColor = false;
            this.rdbFolderGreaterThenSize.CheckedChanged += new System.EventHandler(this.rdbFolderGreaterThenSize_CheckedChanged);
            // 
            // rdbFolderLessThenSize
            // 
            this.rdbFolderLessThenSize.AutoSize = true;
            this.rdbFolderLessThenSize.BackColor = System.Drawing.Color.Transparent;
            this.rdbFolderLessThenSize.Enabled = false;
            this.rdbFolderLessThenSize.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFolderLessThenSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbFolderLessThenSize.Location = new System.Drawing.Point(223, 70);
            this.rdbFolderLessThenSize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbFolderLessThenSize.Name = "rdbFolderLessThenSize";
            this.rdbFolderLessThenSize.Size = new System.Drawing.Size(104, 17);
            this.rdbFolderLessThenSize.TabIndex = 16;
            this.rdbFolderLessThenSize.TabStop = true;
            this.rdbFolderLessThenSize.Text = "< Folder Size";
            this.rdbFolderLessThenSize.UseVisualStyleBackColor = false;
            this.rdbFolderLessThenSize.CheckedChanged += new System.EventHandler(this.rdbFolderLessThenSize_CheckedChanged);
            // 
            // rdbByFolderName
            // 
            this.rdbByFolderName.AutoSize = true;
            this.rdbByFolderName.BackColor = System.Drawing.Color.Transparent;
            this.rdbByFolderName.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbByFolderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbByFolderName.Location = new System.Drawing.Point(143, 70);
            this.rdbByFolderName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbByFolderName.Name = "rdbByFolderName";
            this.rdbByFolderName.Size = new System.Drawing.Size(75, 17);
            this.rdbByFolderName.TabIndex = 15;
            this.rdbByFolderName.TabStop = true;
            this.rdbByFolderName.Text = "By Name";
            this.rdbByFolderName.UseVisualStyleBackColor = false;
            this.rdbByFolderName.CheckedChanged += new System.EventHandler(this.rdbByFolderName_CheckedChanged_1);
            // 
            // rdbByFileExt
            // 
            this.rdbByFileExt.AutoSize = true;
            this.rdbByFileExt.BackColor = System.Drawing.Color.Transparent;
            this.rdbByFileExt.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbByFileExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdbByFileExt.Location = new System.Drawing.Point(224, 35);
            this.rdbByFileExt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbByFileExt.Name = "rdbByFileExt";
            this.rdbByFileExt.Size = new System.Drawing.Size(106, 17);
            this.rdbByFileExt.TabIndex = 14;
            this.rdbByFileExt.TabStop = true;
            this.rdbByFileExt.Text = "By Extension";
            this.rdbByFileExt.UseVisualStyleBackColor = false;
            this.rdbByFileExt.CheckedChanged += new System.EventHandler(this.rdbByFileExt_CheckedChanged_1);
            // 
            // rdbByFileName
            // 
            this.rdbByFileName.AutoSize = true;
            this.rdbByFileName.BackColor = System.Drawing.Color.Transparent;
            this.rdbByFileName.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbByFileName.ForeColor = System.Drawing.Color.OrangeRed;
            this.rdbByFileName.Location = new System.Drawing.Point(143, 35);
            this.rdbByFileName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbByFileName.Name = "rdbByFileName";
            this.rdbByFileName.Size = new System.Drawing.Size(75, 17);
            this.rdbByFileName.TabIndex = 13;
            this.rdbByFileName.TabStop = true;
            this.rdbByFileName.Text = "By Name";
            this.rdbByFileName.UseVisualStyleBackColor = false;
            this.rdbByFileName.CheckedChanged += new System.EventHandler(this.rdbByFileName_CheckedChanged_1);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnDelRows
            // 
            this.btnDelRows.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRows.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelRows.Location = new System.Drawing.Point(454, 657);
            this.btnDelRows.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelRows.Name = "btnDelRows";
            this.btnDelRows.Size = new System.Drawing.Size(72, 23);
            this.btnDelRows.TabIndex = 8;
            this.btnDelRows.Text = "delete";
            this.btnDelRows.UseVisualStyleBackColor = true;
            this.btnDelRows.Click += new System.EventHandler(this.btnDelRows_Click);
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.ForeColor = System.Drawing.Color.Maroon;
            this.btnPath.Location = new System.Drawing.Point(11, 657);
            this.btnPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(72, 23);
            this.btnPath.TabIndex = 9;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(537, 804);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnDelRows);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgrList);
            this.Controls.Add(this.grbPath);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File & Folder Finder";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grbPath.ResumeLayout(false);
            this.grbPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrList)).EndInit();
            this.grbOptions.ResumeLayout(false);
            this.grbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnGetCurrentPath;
        private System.Windows.Forms.GroupBox grbPath;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrList;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.RadioButton rdbFolderGreaterThenSize;
        private System.Windows.Forms.RadioButton rdbFolderLessThenSize;
        private System.Windows.Forms.RadioButton rdbByFolderName;
        private System.Windows.Forms.RadioButton rdbByFileExt;
        private System.Windows.Forms.RadioButton rdbByFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.RadioButton rdbFileLessThenSize;
        private System.Windows.Forms.RadioButton rdbFileGreaterThenSize;
        private System.Windows.Forms.Button btnDelRows;
        private System.Windows.Forms.Button btnPath;
    }
}

