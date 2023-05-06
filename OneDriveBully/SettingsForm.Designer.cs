namespace OneDriveBully
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            txt_OneDriveFolder = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lbl_OneDriveFolder = new System.Windows.Forms.Label();
            b_SaveSettings = new System.Windows.Forms.Button();
            lbl_Interval = new System.Windows.Forms.Label();
            txt_Interval = new System.Windows.Forms.TextBox();
            lbl_WindowsStartup = new System.Windows.Forms.Label();
            cb_LoadOnWindowsStartup = new System.Windows.Forms.CheckBox();
            fbd_OneDrivePath = new System.Windows.Forms.FolderBrowserDialog();
            b_browser = new System.Windows.Forms.Button();
            b_addSymLink = new System.Windows.Forms.Button();
            b_DeleteSymLink = new System.Windows.Forms.Button();
            b_refreshSymLinks = new System.Windows.Forms.Button();
            dgv_SymLinks = new System.Windows.Forms.DataGridView();
            fbd_SymLinks = new System.Windows.Forms.FolderBrowserDialog();
            lbl_SymbolicLinks = new System.Windows.Forms.Label();
            cb_ShowInstructions = new System.Windows.Forms.CheckBox();
            lblShowInstructions = new System.Windows.Forms.Label();
            lbl_SyncOnDirChange = new System.Windows.Forms.Label();
            cb_SyncOnDirChange = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgv_SymLinks).BeginInit();
            SuspendLayout();
            // 
            // txt_OneDriveFolder
            // 
            txt_OneDriveFolder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_OneDriveFolder.Location = new System.Drawing.Point(264, 15);
            txt_OneDriveFolder.Margin = new System.Windows.Forms.Padding(4);
            txt_OneDriveFolder.Name = "txt_OneDriveFolder";
            txt_OneDriveFolder.ReadOnly = true;
            txt_OneDriveFolder.Size = new System.Drawing.Size(1060, 30);
            txt_OneDriveFolder.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 18);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 24);
            label1.TabIndex = 1;
            // 
            // lbl_OneDriveFolder
            // 
            lbl_OneDriveFolder.AutoSize = true;
            lbl_OneDriveFolder.Location = new System.Drawing.Point(20, 20);
            lbl_OneDriveFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_OneDriveFolder.Name = "lbl_OneDriveFolder";
            lbl_OneDriveFolder.Size = new System.Drawing.Size(201, 24);
            lbl_OneDriveFolder.TabIndex = 2;
            lbl_OneDriveFolder.Text = "OneDrive Root Folder:";
            // 
            // b_SaveSettings
            // 
            b_SaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            b_SaveSettings.Location = new System.Drawing.Point(1335, 57);
            b_SaveSettings.Margin = new System.Windows.Forms.Padding(4);
            b_SaveSettings.Name = "b_SaveSettings";
            b_SaveSettings.Size = new System.Drawing.Size(103, 37);
            b_SaveSettings.TabIndex = 4;
            b_SaveSettings.Text = "Save Settings";
            b_SaveSettings.UseVisualStyleBackColor = true;
            b_SaveSettings.Click += B_SaveSettings_Click;
            // 
            // lbl_Interval
            // 
            lbl_Interval.AutoSize = true;
            lbl_Interval.Location = new System.Drawing.Point(20, 63);
            lbl_Interval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_Interval.Name = "lbl_Interval";
            lbl_Interval.Size = new System.Drawing.Size(199, 24);
            lbl_Interval.TabIndex = 5;
            lbl_Interval.Text = "Bully Every X Minutes:";
            // 
            // txt_Interval
            // 
            txt_Interval.Location = new System.Drawing.Point(264, 57);
            txt_Interval.Margin = new System.Windows.Forms.Padding(4);
            txt_Interval.Name = "txt_Interval";
            txt_Interval.Size = new System.Drawing.Size(70, 30);
            txt_Interval.TabIndex = 2;
            txt_Interval.Text = "0";
            txt_Interval.TextChanged += Txt_Interval_TextChanged;
            // 
            // lbl_WindowsStartup
            // 
            lbl_WindowsStartup.AutoSize = true;
            lbl_WindowsStartup.Location = new System.Drawing.Point(20, 107);
            lbl_WindowsStartup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_WindowsStartup.Name = "lbl_WindowsStartup";
            lbl_WindowsStartup.Size = new System.Drawing.Size(232, 24);
            lbl_WindowsStartup.TabIndex = 7;
            lbl_WindowsStartup.Text = "Load on Windows Startup";
            // 
            // cb_LoadOnWindowsStartup
            // 
            cb_LoadOnWindowsStartup.AutoSize = true;
            cb_LoadOnWindowsStartup.Location = new System.Drawing.Point(310, 110);
            cb_LoadOnWindowsStartup.Margin = new System.Windows.Forms.Padding(4);
            cb_LoadOnWindowsStartup.Name = "cb_LoadOnWindowsStartup";
            cb_LoadOnWindowsStartup.Size = new System.Drawing.Size(22, 21);
            cb_LoadOnWindowsStartup.TabIndex = 3;
            cb_LoadOnWindowsStartup.UseVisualStyleBackColor = true;
            cb_LoadOnWindowsStartup.CheckedChanged += Cb_LoadOnWindowsStartup_CheckedChanged;
            // 
            // fbd_OneDrivePath
            // 
            fbd_OneDrivePath.RootFolder = System.Environment.SpecialFolder.UserProfile;
            fbd_OneDrivePath.ShowNewFolderButton = false;
            // 
            // b_browser
            // 
            b_browser.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            b_browser.Location = new System.Drawing.Point(1335, 13);
            b_browser.Margin = new System.Windows.Forms.Padding(4);
            b_browser.Name = "b_browser";
            b_browser.Size = new System.Drawing.Size(103, 39);
            b_browser.TabIndex = 1;
            b_browser.Text = "Browse";
            b_browser.UseVisualStyleBackColor = true;
            b_browser.Click += B_browser_Click;
            // 
            // b_addSymLink
            // 
            b_addSymLink.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            b_addSymLink.Location = new System.Drawing.Point(1112, 298);
            b_addSymLink.Margin = new System.Windows.Forms.Padding(4);
            b_addSymLink.Name = "b_addSymLink";
            b_addSymLink.Size = new System.Drawing.Size(103, 39);
            b_addSymLink.TabIndex = 5;
            b_addSymLink.Text = "Add";
            b_addSymLink.UseVisualStyleBackColor = true;
            b_addSymLink.Click += B_addSymLink_Click;
            // 
            // b_DeleteSymLink
            // 
            b_DeleteSymLink.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            b_DeleteSymLink.Location = new System.Drawing.Point(1224, 298);
            b_DeleteSymLink.Margin = new System.Windows.Forms.Padding(4);
            b_DeleteSymLink.Name = "b_DeleteSymLink";
            b_DeleteSymLink.Size = new System.Drawing.Size(103, 39);
            b_DeleteSymLink.TabIndex = 6;
            b_DeleteSymLink.Text = "Delete";
            b_DeleteSymLink.UseVisualStyleBackColor = true;
            b_DeleteSymLink.Click += B_DeleteSymLink_Click;
            // 
            // b_refreshSymLinks
            // 
            b_refreshSymLinks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            b_refreshSymLinks.Location = new System.Drawing.Point(1335, 298);
            b_refreshSymLinks.Margin = new System.Windows.Forms.Padding(4);
            b_refreshSymLinks.Name = "b_refreshSymLinks";
            b_refreshSymLinks.Size = new System.Drawing.Size(103, 39);
            b_refreshSymLinks.TabIndex = 7;
            b_refreshSymLinks.Text = "Refresh";
            b_refreshSymLinks.UseVisualStyleBackColor = true;
            b_refreshSymLinks.Click += B_refreshSymLinks_Click;
            // 
            // dgv_SymLinks
            // 
            dgv_SymLinks.AllowUserToAddRows = false;
            dgv_SymLinks.AllowUserToDeleteRows = false;
            dgv_SymLinks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_SymLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SymLinks.Location = new System.Drawing.Point(24, 345);
            dgv_SymLinks.Margin = new System.Windows.Forms.Padding(4);
            dgv_SymLinks.MultiSelect = false;
            dgv_SymLinks.Name = "dgv_SymLinks";
            dgv_SymLinks.ReadOnly = true;
            dgv_SymLinks.RowHeadersWidth = 62;
            dgv_SymLinks.RowTemplate.Height = 24;
            dgv_SymLinks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dgv_SymLinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_SymLinks.Size = new System.Drawing.Size(1415, 491);
            dgv_SymLinks.TabIndex = 13;
            // 
            // fbd_SymLinks
            // 
            fbd_SymLinks.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // lbl_SymbolicLinks
            // 
            lbl_SymbolicLinks.AutoSize = true;
            lbl_SymbolicLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_SymbolicLinks.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_SymbolicLinks.Location = new System.Drawing.Point(24, 301);
            lbl_SymbolicLinks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_SymbolicLinks.Name = "lbl_SymbolicLinks";
            lbl_SymbolicLinks.Size = new System.Drawing.Size(188, 29);
            lbl_SymbolicLinks.TabIndex = 14;
            lbl_SymbolicLinks.Text = "Symbolic Links";
            // 
            // cb_ShowInstructions
            // 
            cb_ShowInstructions.AutoSize = true;
            cb_ShowInstructions.Location = new System.Drawing.Point(310, 151);
            cb_ShowInstructions.Margin = new System.Windows.Forms.Padding(4);
            cb_ShowInstructions.Name = "cb_ShowInstructions";
            cb_ShowInstructions.Size = new System.Drawing.Size(22, 21);
            cb_ShowInstructions.TabIndex = 15;
            cb_ShowInstructions.UseVisualStyleBackColor = true;
            cb_ShowInstructions.CheckedChanged += Cb_ShowInstructions_CheckedChanged;
            // 
            // lblShowInstructions
            // 
            lblShowInstructions.AutoSize = true;
            lblShowInstructions.Location = new System.Drawing.Point(18, 148);
            lblShowInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblShowInstructions.Name = "lblShowInstructions";
            lblShowInstructions.Size = new System.Drawing.Size(266, 24);
            lblShowInstructions.TabIndex = 16;
            lblShowInstructions.Text = "Show Instructions on next Exit";
            // 
            // lbl_SyncOnDirChange
            // 
            lbl_SyncOnDirChange.AutoSize = true;
            lbl_SyncOnDirChange.Location = new System.Drawing.Point(18, 187);
            lbl_SyncOnDirChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl_SyncOnDirChange.Name = "lbl_SyncOnDirChange";
            lbl_SyncOnDirChange.Size = new System.Drawing.Size(236, 24);
            lbl_SyncOnDirChange.TabIndex = 18;
            lbl_SyncOnDirChange.Text = "Sync on directory changes";
            // 
            // cb_SyncOnDirChange
            // 
            cb_SyncOnDirChange.AutoSize = true;
            cb_SyncOnDirChange.Location = new System.Drawing.Point(310, 190);
            cb_SyncOnDirChange.Margin = new System.Windows.Forms.Padding(4);
            cb_SyncOnDirChange.Name = "cb_SyncOnDirChange";
            cb_SyncOnDirChange.Size = new System.Drawing.Size(22, 21);
            cb_SyncOnDirChange.TabIndex = 17;
            cb_SyncOnDirChange.UseVisualStyleBackColor = true;
            cb_SyncOnDirChange.CheckedChanged += Cb_SyncOnDirChange_CheckedChanged;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1454, 857);
            Controls.Add(cb_SyncOnDirChange);
            Controls.Add(lbl_SyncOnDirChange);
            Controls.Add(cb_ShowInstructions);
            Controls.Add(lblShowInstructions);
            Controls.Add(lbl_SymbolicLinks);
            Controls.Add(dgv_SymLinks);
            Controls.Add(b_refreshSymLinks);
            Controls.Add(b_DeleteSymLink);
            Controls.Add(b_addSymLink);
            Controls.Add(b_browser);
            Controls.Add(cb_LoadOnWindowsStartup);
            Controls.Add(lbl_WindowsStartup);
            Controls.Add(lbl_Interval);
            Controls.Add(txt_Interval);
            Controls.Add(b_SaveSettings);
            Controls.Add(lbl_OneDriveFolder);
            Controls.Add(label1);
            Controls.Add(txt_OneDriveFolder);
            ForeColor = System.Drawing.SystemColors.ControlText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "SettingsForm";
            Text = "OneDrive Bully - Settings";
            FormClosing += MainForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgv_SymLinks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txt_OneDriveFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_OneDriveFolder;
        private System.Windows.Forms.Button b_SaveSettings;
        private System.Windows.Forms.Label lbl_Interval;
        private System.Windows.Forms.TextBox txt_Interval;
        private System.Windows.Forms.Label lbl_WindowsStartup;
        private System.Windows.Forms.CheckBox cb_LoadOnWindowsStartup;
        private System.Windows.Forms.FolderBrowserDialog fbd_OneDrivePath;
        private System.Windows.Forms.Button b_browser;
        private System.Windows.Forms.Button b_addSymLink;
        private System.Windows.Forms.Button b_DeleteSymLink;
        private System.Windows.Forms.Button b_refreshSymLinks;
        private System.Windows.Forms.DataGridView dgv_SymLinks;
        private System.Windows.Forms.FolderBrowserDialog fbd_SymLinks;
        private System.Windows.Forms.Label lbl_SymbolicLinks;
        private System.Windows.Forms.CheckBox cb_ShowInstructions;
        private System.Windows.Forms.Label lblShowInstructions;
        private System.Windows.Forms.Label lbl_SyncOnDirChange;
        private System.Windows.Forms.CheckBox cb_SyncOnDirChange;
    }
}