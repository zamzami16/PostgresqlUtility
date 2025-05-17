namespace PostgresqlUtility
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
            AntdUI.Tabs.StyleLine styleLine2 = new AntdUI.Tabs.StyleLine();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pageHeader = new AntdUI.PageHeader();
            colorTheme = new AntdUI.ColorPicker();
            BtnMode = new AntdUI.Button();
            pnlMain = new AntdUI.Panel();
            panel1 = new AntdUI.Panel();
            panel2 = new AntdUI.Panel();
            tabs = new AntdUI.Tabs();
            BackupPage = new AntdUI.TabPage();
            pnlBaseBackupPage = new AntdUI.Panel();
            PnlBackupSaveTo = new AntdUI.Panel();
            InpBackupSaveTo = new AntdUI.Input();
            BtnbackupSaveTo = new AntdUI.Button();
            lblbackupSaveTo = new AntdUI.Label();
            PnlBackupListDatabase = new AntdUI.Panel();
            SelectDbNameToBackup = new AntdUI.Select();
            BtnRetrieveDatabaseNames = new AntdUI.Button();
            lblBackupdatabaseNames = new AntdUI.Label();
            BtnBackup = new AntdUI.Button();
            RestorePage = new AntdUI.TabPage();
            PnlRestorePage = new AntdUI.Panel();
            BtnRestore = new AntdUI.Button();
            PnlBackupFileToRestore = new AntdUI.Panel();
            InptBackupFileToRestore = new AntdUI.Input();
            BtnBrowseBackupFileToRestore = new AntdUI.Button();
            lblBackupFile = new AntdUI.Label();
            pnlDatabaseToRestore = new AntdUI.Panel();
            InpDatabaseTorestore = new AntdUI.Select();
            BtnRetrieveDatabaseToRestore = new AntdUI.Button();
            LblDatabaseToRestore = new AntdUI.Label();
            SettingPage = new AntdUI.TabPage();
            pnlBaseSettingPage = new AntdUI.Panel();
            BtnSaveSetting = new AntdUI.Button();
            PnlConnectionProfiles = new AntdUI.Panel();
            panel5 = new AntdUI.Panel();
            InpDbUser = new AntdUI.Input();
            label6 = new AntdUI.Label();
            panel3 = new AntdUI.Panel();
            DdDatabases = new AntdUI.Select();
            label5 = new AntdUI.Label();
            BtnTestConnection = new AntdUI.Button();
            pnlDbPassword = new AntdUI.Panel();
            InpDbPassword = new AntdUI.Input();
            label4 = new AntdUI.Label();
            pnlHost = new AntdUI.Panel();
            InpDbHost = new AntdUI.Input();
            label3 = new AntdUI.Label();
            pnlDbPort = new AntdUI.Panel();
            InpDbPort = new AntdUI.InputNumber();
            label1 = new AntdUI.Label();
            PnlDbname = new AntdUI.Panel();
            InpDbName = new AntdUI.Input();
            lblDbName = new AntdUI.Label();
            label2 = new AntdUI.Label();
            pnlPgBinPath = new AntdUI.Panel();
            InpPgBinPath = new AntdUI.Input();
            BtnBrowsePostgrePath = new AntdUI.Button();
            lblPgBinPath = new AntdUI.Label();
            SqlPage = new AntdUI.TabPage();
            PanelSqlPageBase = new AntdUI.Panel();
            pageHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabs.SuspendLayout();
            BackupPage.SuspendLayout();
            pnlBaseBackupPage.SuspendLayout();
            PnlBackupSaveTo.SuspendLayout();
            PnlBackupListDatabase.SuspendLayout();
            RestorePage.SuspendLayout();
            PnlRestorePage.SuspendLayout();
            PnlBackupFileToRestore.SuspendLayout();
            pnlDatabaseToRestore.SuspendLayout();
            SettingPage.SuspendLayout();
            pnlBaseSettingPage.SuspendLayout();
            PnlConnectionProfiles.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            pnlDbPassword.SuspendLayout();
            pnlHost.SuspendLayout();
            pnlDbPort.SuspendLayout();
            PnlDbname.SuspendLayout();
            pnlPgBinPath.SuspendLayout();
            SqlPage.SuspendLayout();
            SuspendLayout();
            // 
            // pageHeader
            // 
            pageHeader.Controls.Add(colorTheme);
            pageHeader.Controls.Add(BtnMode);
            pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            pageHeader.Icon = Properties.Resource.logo;
            pageHeader.Location = new System.Drawing.Point(0, 0);
            pageHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pageHeader.MaximizeBox = false;
            pageHeader.MinimizeBox = false;
            pageHeader.Name = "pageHeader";
            pageHeader.ShowButton = true;
            pageHeader.ShowIcon = true;
            pageHeader.Size = new System.Drawing.Size(821, 40);
            pageHeader.SubText = "(by mohyusuf)";
            pageHeader.TabIndex = 1;
            pageHeader.Text = "Postgresql Utility";
            // 
            // colorTheme
            // 
            colorTheme.Dock = System.Windows.Forms.DockStyle.Right;
            colorTheme.Location = new System.Drawing.Point(691, 0);
            colorTheme.Name = "colorTheme";
            colorTheme.Padding = new System.Windows.Forms.Padding(5);
            colorTheme.Size = new System.Drawing.Size(40, 40);
            colorTheme.TabIndex = 9;
            colorTheme.Value = System.Drawing.Color.FromArgb(22, 119, 255);
            colorTheme.ValueChanged += ColorTheme_ValueChanged;
            // 
            // BtnMode
            // 
            BtnMode.Dock = System.Windows.Forms.DockStyle.Right;
            BtnMode.Ghost = true;
            BtnMode.IconSvg = "SunOutlined";
            BtnMode.Location = new System.Drawing.Point(731, 0);
            BtnMode.Name = "BtnMode";
            BtnMode.Radius = 0;
            BtnMode.Size = new System.Drawing.Size(50, 40);
            BtnMode.TabIndex = 7;
            BtnMode.ToggleIconSvg = "MoonOutlined";
            BtnMode.WaveSize = 0;
            BtnMode.Click += BtnMode_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(panel1);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 40);
            pnlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(821, 477);
            pnlMain.TabIndex = 2;
            pnlMain.Text = "panel1";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(821, 477);
            panel1.TabIndex = 3;
            panel1.Text = "panel1";
            // 
            // panel2
            // 
            panel2.Controls.Add(tabs);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(821, 477);
            panel2.TabIndex = 2;
            panel2.Text = "panel2";
            // 
            // tabs
            // 
            tabs.Controls.Add(SqlPage);
            tabs.Controls.Add(BackupPage);
            tabs.Controls.Add(RestorePage);
            tabs.Controls.Add(SettingPage);
            tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            tabs.Location = new System.Drawing.Point(0, 0);
            tabs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabs.Name = "tabs";
            tabs.Pages.Add(SqlPage);
            tabs.Pages.Add(BackupPage);
            tabs.Pages.Add(RestorePage);
            tabs.Pages.Add(SettingPage);
            tabs.Size = new System.Drawing.Size(821, 477);
            tabs.Style = styleLine2;
            tabs.TabIndex = 0;
            tabs.Text = "tabs1";
            // 
            // BackupPage
            // 
            BackupPage.Controls.Add(pnlBaseBackupPage);
            BackupPage.Location = new System.Drawing.Point(-813, -445);
            BackupPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BackupPage.Name = "BackupPage";
            BackupPage.Size = new System.Drawing.Size(813, 445);
            BackupPage.TabIndex = 0;
            BackupPage.Text = "BACKUP";
            // 
            // pnlBaseBackupPage
            // 
            pnlBaseBackupPage.Controls.Add(PnlBackupSaveTo);
            pnlBaseBackupPage.Controls.Add(PnlBackupListDatabase);
            pnlBaseBackupPage.Controls.Add(BtnBackup);
            pnlBaseBackupPage.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBaseBackupPage.Location = new System.Drawing.Point(0, 0);
            pnlBaseBackupPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlBaseBackupPage.Name = "pnlBaseBackupPage";
            pnlBaseBackupPage.Size = new System.Drawing.Size(813, 445);
            pnlBaseBackupPage.TabIndex = 0;
            pnlBaseBackupPage.Text = "panel3";
            // 
            // PnlBackupSaveTo
            // 
            PnlBackupSaveTo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PnlBackupSaveTo.BorderWidth = 1F;
            PnlBackupSaveTo.Controls.Add(InpBackupSaveTo);
            PnlBackupSaveTo.Controls.Add(BtnbackupSaveTo);
            PnlBackupSaveTo.Controls.Add(lblbackupSaveTo);
            PnlBackupSaveTo.Location = new System.Drawing.Point(10, 70);
            PnlBackupSaveTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PnlBackupSaveTo.Name = "PnlBackupSaveTo";
            PnlBackupSaveTo.Size = new System.Drawing.Size(792, 42);
            PnlBackupSaveTo.TabIndex = 6;
            PnlBackupSaveTo.Text = "panel1";
            // 
            // InpBackupSaveTo
            // 
            InpBackupSaveTo.Dock = System.Windows.Forms.DockStyle.Fill;
            InpBackupSaveTo.Location = new System.Drawing.Point(136, 1);
            InpBackupSaveTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InpBackupSaveTo.Name = "InpBackupSaveTo";
            InpBackupSaveTo.Size = new System.Drawing.Size(567, 40);
            InpBackupSaveTo.TabIndex = 3;
            // 
            // BtnbackupSaveTo
            // 
            BtnbackupSaveTo.Dock = System.Windows.Forms.DockStyle.Right;
            BtnbackupSaveTo.Location = new System.Drawing.Point(703, 1);
            BtnbackupSaveTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnbackupSaveTo.Name = "BtnbackupSaveTo";
            BtnbackupSaveTo.Size = new System.Drawing.Size(88, 40);
            BtnbackupSaveTo.TabIndex = 2;
            BtnbackupSaveTo.Text = "Browse";
            BtnbackupSaveTo.Type = AntdUI.TTypeMini.Primary;
            BtnbackupSaveTo.Click += BtnbackupSaveTo_Click;
            // 
            // lblbackupSaveTo
            // 
            lblbackupSaveTo.Dock = System.Windows.Forms.DockStyle.Left;
            lblbackupSaveTo.Location = new System.Drawing.Point(1, 1);
            lblbackupSaveTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lblbackupSaveTo.Name = "lblbackupSaveTo";
            lblbackupSaveTo.Size = new System.Drawing.Size(135, 40);
            lblbackupSaveTo.Suffix = ":";
            lblbackupSaveTo.TabIndex = 0;
            lblbackupSaveTo.Text = "SAVE TO";
            lblbackupSaveTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlBackupListDatabase
            // 
            PnlBackupListDatabase.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PnlBackupListDatabase.BorderWidth = 1F;
            PnlBackupListDatabase.Controls.Add(SelectDbNameToBackup);
            PnlBackupListDatabase.Controls.Add(BtnRetrieveDatabaseNames);
            PnlBackupListDatabase.Controls.Add(lblBackupdatabaseNames);
            PnlBackupListDatabase.Location = new System.Drawing.Point(10, 22);
            PnlBackupListDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PnlBackupListDatabase.Name = "PnlBackupListDatabase";
            PnlBackupListDatabase.Size = new System.Drawing.Size(792, 42);
            PnlBackupListDatabase.TabIndex = 5;
            PnlBackupListDatabase.Text = "panel1";
            // 
            // SelectDbNameToBackup
            // 
            SelectDbNameToBackup.AllowClear = true;
            SelectDbNameToBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectDbNameToBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SelectDbNameToBackup.ListAutoWidth = true;
            SelectDbNameToBackup.Location = new System.Drawing.Point(136, 1);
            SelectDbNameToBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SelectDbNameToBackup.MaxCount = 8;
            SelectDbNameToBackup.Name = "SelectDbNameToBackup";
            SelectDbNameToBackup.PlaceholderText = "No Entry Selected";
            SelectDbNameToBackup.Size = new System.Drawing.Size(567, 40);
            SelectDbNameToBackup.TabIndex = 1;
            // 
            // BtnRetrieveDatabaseNames
            // 
            BtnRetrieveDatabaseNames.Dock = System.Windows.Forms.DockStyle.Right;
            BtnRetrieveDatabaseNames.Location = new System.Drawing.Point(703, 1);
            BtnRetrieveDatabaseNames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnRetrieveDatabaseNames.Name = "BtnRetrieveDatabaseNames";
            BtnRetrieveDatabaseNames.Size = new System.Drawing.Size(88, 40);
            BtnRetrieveDatabaseNames.TabIndex = 2;
            BtnRetrieveDatabaseNames.Text = "Retrieve";
            BtnRetrieveDatabaseNames.Type = AntdUI.TTypeMini.Primary;
            BtnRetrieveDatabaseNames.Click += BtnRetrieveDatabaseNames_Click;
            // 
            // lblBackupdatabaseNames
            // 
            lblBackupdatabaseNames.Dock = System.Windows.Forms.DockStyle.Left;
            lblBackupdatabaseNames.Location = new System.Drawing.Point(1, 1);
            lblBackupdatabaseNames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lblBackupdatabaseNames.Name = "lblBackupdatabaseNames";
            lblBackupdatabaseNames.Size = new System.Drawing.Size(135, 40);
            lblBackupdatabaseNames.Suffix = ":";
            lblBackupdatabaseNames.TabIndex = 0;
            lblBackupdatabaseNames.Text = "DATABASES ";
            lblBackupdatabaseNames.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnBackup
            // 
            BtnBackup.Location = new System.Drawing.Point(681, 393);
            BtnBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnBackup.Name = "BtnBackup";
            BtnBackup.Size = new System.Drawing.Size(125, 46);
            BtnBackup.TabIndex = 0;
            BtnBackup.Text = "BACKUP";
            BtnBackup.Type = AntdUI.TTypeMini.Primary;
            BtnBackup.Click += BtnBackup_Click;
            // 
            // RestorePage
            // 
            RestorePage.Controls.Add(PnlRestorePage);
            RestorePage.Location = new System.Drawing.Point(-813, -445);
            RestorePage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RestorePage.Name = "RestorePage";
            RestorePage.Size = new System.Drawing.Size(813, 445);
            RestorePage.TabIndex = 1;
            RestorePage.Text = "RESTORE";
            // 
            // PnlRestorePage
            // 
            PnlRestorePage.Controls.Add(BtnRestore);
            PnlRestorePage.Controls.Add(PnlBackupFileToRestore);
            PnlRestorePage.Controls.Add(pnlDatabaseToRestore);
            PnlRestorePage.Dock = System.Windows.Forms.DockStyle.Fill;
            PnlRestorePage.Location = new System.Drawing.Point(0, 0);
            PnlRestorePage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PnlRestorePage.Name = "PnlRestorePage";
            PnlRestorePage.Size = new System.Drawing.Size(813, 445);
            PnlRestorePage.TabIndex = 0;
            PnlRestorePage.Text = "panel6";
            // 
            // BtnRestore
            // 
            BtnRestore.Location = new System.Drawing.Point(681, 393);
            BtnRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnRestore.Name = "BtnRestore";
            BtnRestore.Size = new System.Drawing.Size(125, 46);
            BtnRestore.TabIndex = 9;
            BtnRestore.Text = "RESTORE";
            BtnRestore.Type = AntdUI.TTypeMini.Primary;
            BtnRestore.Click += BtnRestore_Click;
            // 
            // PnlBackupFileToRestore
            // 
            PnlBackupFileToRestore.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PnlBackupFileToRestore.BorderWidth = 1F;
            PnlBackupFileToRestore.Controls.Add(InptBackupFileToRestore);
            PnlBackupFileToRestore.Controls.Add(BtnBrowseBackupFileToRestore);
            PnlBackupFileToRestore.Controls.Add(lblBackupFile);
            PnlBackupFileToRestore.Location = new System.Drawing.Point(10, 22);
            PnlBackupFileToRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PnlBackupFileToRestore.Name = "PnlBackupFileToRestore";
            PnlBackupFileToRestore.Size = new System.Drawing.Size(792, 42);
            PnlBackupFileToRestore.TabIndex = 8;
            PnlBackupFileToRestore.Text = "panel1";
            // 
            // InptBackupFileToRestore
            // 
            InptBackupFileToRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            InptBackupFileToRestore.Location = new System.Drawing.Point(136, 1);
            InptBackupFileToRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InptBackupFileToRestore.Name = "InptBackupFileToRestore";
            InptBackupFileToRestore.Size = new System.Drawing.Size(567, 40);
            InptBackupFileToRestore.TabIndex = 3;
            // 
            // BtnBrowseBackupFileToRestore
            // 
            BtnBrowseBackupFileToRestore.Dock = System.Windows.Forms.DockStyle.Right;
            BtnBrowseBackupFileToRestore.Location = new System.Drawing.Point(703, 1);
            BtnBrowseBackupFileToRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnBrowseBackupFileToRestore.Name = "BtnBrowseBackupFileToRestore";
            BtnBrowseBackupFileToRestore.Size = new System.Drawing.Size(88, 40);
            BtnBrowseBackupFileToRestore.TabIndex = 2;
            BtnBrowseBackupFileToRestore.Text = "Browse";
            BtnBrowseBackupFileToRestore.Type = AntdUI.TTypeMini.Primary;
            BtnBrowseBackupFileToRestore.Click += BtnBrowseBackupFileToRestore_Click;
            // 
            // lblBackupFile
            // 
            lblBackupFile.Dock = System.Windows.Forms.DockStyle.Left;
            lblBackupFile.Location = new System.Drawing.Point(1, 1);
            lblBackupFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lblBackupFile.Name = "lblBackupFile";
            lblBackupFile.Size = new System.Drawing.Size(135, 40);
            lblBackupFile.Suffix = ":";
            lblBackupFile.TabIndex = 0;
            lblBackupFile.Text = "BACKUP FILE";
            lblBackupFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDatabaseToRestore
            // 
            pnlDatabaseToRestore.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlDatabaseToRestore.BorderWidth = 1F;
            pnlDatabaseToRestore.Controls.Add(InpDatabaseTorestore);
            pnlDatabaseToRestore.Controls.Add(BtnRetrieveDatabaseToRestore);
            pnlDatabaseToRestore.Controls.Add(LblDatabaseToRestore);
            pnlDatabaseToRestore.Location = new System.Drawing.Point(10, 70);
            pnlDatabaseToRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlDatabaseToRestore.Name = "pnlDatabaseToRestore";
            pnlDatabaseToRestore.Size = new System.Drawing.Size(792, 42);
            pnlDatabaseToRestore.TabIndex = 7;
            pnlDatabaseToRestore.Text = "panel1";
            // 
            // InpDatabaseTorestore
            // 
            InpDatabaseTorestore.AllowClear = true;
            InpDatabaseTorestore.Dock = System.Windows.Forms.DockStyle.Fill;
            InpDatabaseTorestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            InpDatabaseTorestore.ListAutoWidth = true;
            InpDatabaseTorestore.Location = new System.Drawing.Point(136, 1);
            InpDatabaseTorestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InpDatabaseTorestore.MaxCount = 8;
            InpDatabaseTorestore.Name = "InpDatabaseTorestore";
            InpDatabaseTorestore.PlaceholderText = "No Entry Selected";
            InpDatabaseTorestore.Size = new System.Drawing.Size(567, 40);
            InpDatabaseTorestore.TabIndex = 1;
            // 
            // BtnRetrieveDatabaseToRestore
            // 
            BtnRetrieveDatabaseToRestore.Dock = System.Windows.Forms.DockStyle.Right;
            BtnRetrieveDatabaseToRestore.Location = new System.Drawing.Point(703, 1);
            BtnRetrieveDatabaseToRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnRetrieveDatabaseToRestore.Name = "BtnRetrieveDatabaseToRestore";
            BtnRetrieveDatabaseToRestore.Size = new System.Drawing.Size(88, 40);
            BtnRetrieveDatabaseToRestore.TabIndex = 2;
            BtnRetrieveDatabaseToRestore.Text = "Retrieve";
            BtnRetrieveDatabaseToRestore.Type = AntdUI.TTypeMini.Primary;
            BtnRetrieveDatabaseToRestore.Click += BtnRetrieveDatabaseToRestore_Click;
            // 
            // LblDatabaseToRestore
            // 
            LblDatabaseToRestore.Dock = System.Windows.Forms.DockStyle.Left;
            LblDatabaseToRestore.Location = new System.Drawing.Point(1, 1);
            LblDatabaseToRestore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LblDatabaseToRestore.Name = "LblDatabaseToRestore";
            LblDatabaseToRestore.Size = new System.Drawing.Size(135, 40);
            LblDatabaseToRestore.Suffix = ":";
            LblDatabaseToRestore.TabIndex = 0;
            LblDatabaseToRestore.Text = "DATABASES ";
            LblDatabaseToRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingPage
            // 
            SettingPage.Controls.Add(pnlBaseSettingPage);
            SettingPage.Location = new System.Drawing.Point(-813, -445);
            SettingPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SettingPage.Name = "SettingPage";
            SettingPage.Size = new System.Drawing.Size(813, 445);
            SettingPage.TabIndex = 2;
            SettingPage.Text = "SETTING";
            // 
            // pnlBaseSettingPage
            // 
            pnlBaseSettingPage.Controls.Add(BtnSaveSetting);
            pnlBaseSettingPage.Controls.Add(PnlConnectionProfiles);
            pnlBaseSettingPage.Controls.Add(pnlPgBinPath);
            pnlBaseSettingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBaseSettingPage.Location = new System.Drawing.Point(0, 0);
            pnlBaseSettingPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlBaseSettingPage.Name = "pnlBaseSettingPage";
            pnlBaseSettingPage.Size = new System.Drawing.Size(813, 445);
            pnlBaseSettingPage.TabIndex = 2;
            pnlBaseSettingPage.Text = "panel3";
            // 
            // BtnSaveSetting
            // 
            BtnSaveSetting.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            BtnSaveSetting.Location = new System.Drawing.Point(677, 388);
            BtnSaveSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnSaveSetting.Name = "BtnSaveSetting";
            BtnSaveSetting.Size = new System.Drawing.Size(125, 46);
            BtnSaveSetting.TabIndex = 3;
            BtnSaveSetting.Text = "SAVE";
            BtnSaveSetting.Type = AntdUI.TTypeMini.Primary;
            BtnSaveSetting.Click += BtnSaveSetting_Click;
            // 
            // PnlConnectionProfiles
            // 
            PnlConnectionProfiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PnlConnectionProfiles.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            PnlConnectionProfiles.BorderWidth = 0.5F;
            PnlConnectionProfiles.Controls.Add(panel5);
            PnlConnectionProfiles.Controls.Add(panel3);
            PnlConnectionProfiles.Controls.Add(BtnTestConnection);
            PnlConnectionProfiles.Controls.Add(pnlDbPassword);
            PnlConnectionProfiles.Controls.Add(pnlHost);
            PnlConnectionProfiles.Controls.Add(pnlDbPort);
            PnlConnectionProfiles.Controls.Add(PnlDbname);
            PnlConnectionProfiles.Controls.Add(label2);
            PnlConnectionProfiles.Location = new System.Drawing.Point(12, 80);
            PnlConnectionProfiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PnlConnectionProfiles.Name = "PnlConnectionProfiles";
            PnlConnectionProfiles.Size = new System.Drawing.Size(790, 302);
            PnlConnectionProfiles.TabIndex = 2;
            PnlConnectionProfiles.Text = "panel4";
            // 
            // panel5
            // 
            panel5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel5.BorderWidth = 0.5F;
            panel5.Controls.Add(InpDbUser);
            panel5.Controls.Add(label6);
            panel5.Location = new System.Drawing.Point(13, 143);
            panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(765, 42);
            panel5.TabIndex = 3;
            panel5.Text = "panel1";
            // 
            // InpDbUser
            // 
            InpDbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            InpDbUser.Location = new System.Drawing.Point(136, 1);
            InpDbUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InpDbUser.Name = "InpDbUser";
            InpDbUser.Size = new System.Drawing.Size(628, 40);
            InpDbUser.TabIndex = 2;
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Left;
            label6.Location = new System.Drawing.Point(1, 1);
            label6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(135, 40);
            label6.Suffix = ":";
            label6.TabIndex = 0;
            label6.Text = "USER NAME";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel3.BorderWidth = 0.5F;
            panel3.Controls.Add(DdDatabases);
            panel3.Controls.Add(label5);
            panel3.Location = new System.Drawing.Point(13, 238);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(765, 42);
            panel3.TabIndex = 4;
            panel3.Text = "panel1";
            // 
            // DdDatabases
            // 
            DdDatabases.AllowClear = true;
            DdDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            DdDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            DdDatabases.ListAutoWidth = true;
            DdDatabases.Location = new System.Drawing.Point(136, 1);
            DdDatabases.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DdDatabases.MaxCount = 8;
            DdDatabases.Name = "DdDatabases";
            DdDatabases.PlaceholderText = "Test Connection to retrieve databases names";
            DdDatabases.Size = new System.Drawing.Size(628, 40);
            DdDatabases.TabIndex = 1;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Left;
            label5.Location = new System.Drawing.Point(1, 1);
            label5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(135, 40);
            label5.Suffix = ":";
            label5.TabIndex = 0;
            label5.Text = "DATABASES";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnTestConnection
            // 
            BtnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            BtnTestConnection.Location = new System.Drawing.Point(600, 192);
            BtnTestConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnTestConnection.Name = "BtnTestConnection";
            BtnTestConnection.Size = new System.Drawing.Size(176, 40);
            BtnTestConnection.TabIndex = 4;
            BtnTestConnection.Text = "Test Connection";
            BtnTestConnection.Type = AntdUI.TTypeMini.Primary;
            BtnTestConnection.Click += BtnTestConnection_Click;
            // 
            // pnlDbPassword
            // 
            pnlDbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlDbPassword.BorderWidth = 0.5F;
            pnlDbPassword.Controls.Add(InpDbPassword);
            pnlDbPassword.Controls.Add(label4);
            pnlDbPassword.Location = new System.Drawing.Point(12, 190);
            pnlDbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlDbPassword.Name = "pnlDbPassword";
            pnlDbPassword.Size = new System.Drawing.Size(583, 42);
            pnlDbPassword.TabIndex = 3;
            pnlDbPassword.Text = "panel1";
            // 
            // InpDbPassword
            // 
            InpDbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            InpDbPassword.Location = new System.Drawing.Point(136, 1);
            InpDbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InpDbPassword.Name = "InpDbPassword";
            InpDbPassword.PasswordChar = '*';
            InpDbPassword.Size = new System.Drawing.Size(446, 40);
            InpDbPassword.TabIndex = 2;
            InpDbPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Left;
            label4.Location = new System.Drawing.Point(1, 1);
            label4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(135, 40);
            label4.Suffix = ":";
            label4.TabIndex = 0;
            label4.Text = "PASSWORD";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlHost
            // 
            pnlHost.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlHost.BorderWidth = 0.5F;
            pnlHost.Controls.Add(InpDbHost);
            pnlHost.Controls.Add(label3);
            pnlHost.Location = new System.Drawing.Point(12, 47);
            pnlHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlHost.Name = "pnlHost";
            pnlHost.Size = new System.Drawing.Size(583, 42);
            pnlHost.TabIndex = 3;
            pnlHost.Text = "panel1";
            // 
            // InpDbHost
            // 
            InpDbHost.Dock = System.Windows.Forms.DockStyle.Fill;
            InpDbHost.Location = new System.Drawing.Point(136, 1);
            InpDbHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InpDbHost.Name = "InpDbHost";
            InpDbHost.Size = new System.Drawing.Size(446, 40);
            InpDbHost.TabIndex = 2;
            InpDbHost.Text = "localhost";
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Left;
            label3.Location = new System.Drawing.Point(1, 1);
            label3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 40);
            label3.Suffix = ":";
            label3.TabIndex = 0;
            label3.Text = "HOST";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDbPort
            // 
            pnlDbPort.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pnlDbPort.BorderWidth = 1F;
            pnlDbPort.Controls.Add(InpDbPort);
            pnlDbPort.Controls.Add(label1);
            pnlDbPort.Location = new System.Drawing.Point(602, 48);
            pnlDbPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlDbPort.Name = "pnlDbPort";
            pnlDbPort.Size = new System.Drawing.Size(176, 42);
            pnlDbPort.TabIndex = 3;
            pnlDbPort.Text = "panel1";
            // 
            // InpDbPort
            // 
            InpDbPort.Dock = System.Windows.Forms.DockStyle.Fill;
            InpDbPort.Location = new System.Drawing.Point(69, 1);
            InpDbPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InpDbPort.Name = "InpDbPort";
            InpDbPort.Size = new System.Drawing.Size(106, 40);
            InpDbPort.TabIndex = 1;
            InpDbPort.Text = "5432";
            InpDbPort.Value = new decimal(new int[] { 5432, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Left;
            label1.Location = new System.Drawing.Point(1, 1);
            label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 40);
            label1.Suffix = ":";
            label1.TabIndex = 0;
            label1.Text = "PORT";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlDbname
            // 
            PnlDbname.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PnlDbname.BorderWidth = 0.5F;
            PnlDbname.Controls.Add(InpDbName);
            PnlDbname.Controls.Add(lblDbName);
            PnlDbname.Location = new System.Drawing.Point(12, 96);
            PnlDbname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PnlDbname.Name = "PnlDbname";
            PnlDbname.Size = new System.Drawing.Size(765, 42);
            PnlDbname.TabIndex = 2;
            PnlDbname.Text = "panel1";
            // 
            // InpDbName
            // 
            InpDbName.Dock = System.Windows.Forms.DockStyle.Fill;
            InpDbName.Location = new System.Drawing.Point(136, 1);
            InpDbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InpDbName.Name = "InpDbName";
            InpDbName.Size = new System.Drawing.Size(628, 40);
            InpDbName.TabIndex = 2;
            // 
            // lblDbName
            // 
            lblDbName.Dock = System.Windows.Forms.DockStyle.Left;
            lblDbName.Location = new System.Drawing.Point(1, 1);
            lblDbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lblDbName.Name = "lblDbName";
            lblDbName.Size = new System.Drawing.Size(135, 40);
            lblDbName.Suffix = ":";
            lblDbName.TabIndex = 0;
            lblDbName.Text = "DATABASE NAME";
            lblDbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 14);
            label2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(244, 27);
            label2.Suffix = ":";
            label2.TabIndex = 0;
            label2.Text = "CONNECTION PROFILE";
            // 
            // pnlPgBinPath
            // 
            pnlPgBinPath.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlPgBinPath.BorderWidth = 0.5F;
            pnlPgBinPath.Controls.Add(InpPgBinPath);
            pnlPgBinPath.Controls.Add(BtnBrowsePostgrePath);
            pnlPgBinPath.Controls.Add(lblPgBinPath);
            pnlPgBinPath.Location = new System.Drawing.Point(10, 17);
            pnlPgBinPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pnlPgBinPath.Name = "pnlPgBinPath";
            pnlPgBinPath.Size = new System.Drawing.Size(792, 42);
            pnlPgBinPath.TabIndex = 1;
            pnlPgBinPath.Text = "panel1";
            // 
            // InpPgBinPath
            // 
            InpPgBinPath.Dock = System.Windows.Forms.DockStyle.Fill;
            InpPgBinPath.Location = new System.Drawing.Point(197, 1);
            InpPgBinPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            InpPgBinPath.Name = "InpPgBinPath";
            InpPgBinPath.Size = new System.Drawing.Size(506, 40);
            InpPgBinPath.TabIndex = 2;
            // 
            // BtnBrowsePostgrePath
            // 
            BtnBrowsePostgrePath.Dock = System.Windows.Forms.DockStyle.Right;
            BtnBrowsePostgrePath.Location = new System.Drawing.Point(703, 1);
            BtnBrowsePostgrePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BtnBrowsePostgrePath.Name = "BtnBrowsePostgrePath";
            BtnBrowsePostgrePath.Size = new System.Drawing.Size(88, 40);
            BtnBrowsePostgrePath.TabIndex = 1;
            BtnBrowsePostgrePath.Text = "Browse";
            BtnBrowsePostgrePath.Type = AntdUI.TTypeMini.Primary;
            BtnBrowsePostgrePath.Click += BtnBrowsePostgrePath_Click;
            // 
            // lblPgBinPath
            // 
            lblPgBinPath.Dock = System.Windows.Forms.DockStyle.Left;
            lblPgBinPath.Location = new System.Drawing.Point(1, 1);
            lblPgBinPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lblPgBinPath.Name = "lblPgBinPath";
            lblPgBinPath.Size = new System.Drawing.Size(196, 40);
            lblPgBinPath.Suffix = ":";
            lblPgBinPath.TabIndex = 0;
            lblPgBinPath.Text = "POSTGRESQL BIN FOLDER";
            lblPgBinPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SqlPage
            // 
            SqlPage.Controls.Add(PanelSqlPageBase);
            SqlPage.Location = new System.Drawing.Point(4, 29);
            SqlPage.Name = "SqlPage";
            SqlPage.Size = new System.Drawing.Size(813, 445);
            SqlPage.TabIndex = 0;
            SqlPage.Text = "SQL";
            // 
            // PanelSqlPageBase
            // 
            PanelSqlPageBase.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelSqlPageBase.Location = new System.Drawing.Point(0, 0);
            PanelSqlPageBase.Name = "PanelSqlPageBase";
            PanelSqlPageBase.Size = new System.Drawing.Size(813, 445);
            PanelSqlPageBase.TabIndex = 0;
            PanelSqlPageBase.Text = "panel4";
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(821, 517);
            Controls.Add(pnlMain);
            Controls.Add(pageHeader);
            Dark = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Mode = AntdUI.TAMode.Dark;
            Name = "Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PostgresqlUtility";
            Shown += Main_Shown;
            pageHeader.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabs.ResumeLayout(false);
            BackupPage.ResumeLayout(false);
            pnlBaseBackupPage.ResumeLayout(false);
            PnlBackupSaveTo.ResumeLayout(false);
            PnlBackupListDatabase.ResumeLayout(false);
            RestorePage.ResumeLayout(false);
            PnlRestorePage.ResumeLayout(false);
            PnlBackupFileToRestore.ResumeLayout(false);
            pnlDatabaseToRestore.ResumeLayout(false);
            SettingPage.ResumeLayout(false);
            pnlBaseSettingPage.ResumeLayout(false);
            PnlConnectionProfiles.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnlDbPassword.ResumeLayout(false);
            pnlHost.ResumeLayout(false);
            pnlDbPort.ResumeLayout(false);
            PnlDbname.ResumeLayout(false);
            pnlPgBinPath.ResumeLayout(false);
            SqlPage.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private AntdUI.PageHeader pageHeader;
        private AntdUI.Panel pnlMain;
        private AntdUI.Panel pnlPgBinPath;
        private AntdUI.Label lblPgBinPath;
        private AntdUI.Button BtnBrowsePostgrePath;
        private AntdUI.Input InpPgBinPath;
        private AntdUI.Panel panel1;
        private AntdUI.Panel panel2;
        private AntdUI.Tabs tabs;
        private AntdUI.TabPage BackupPage;
        private AntdUI.TabPage RestorePage;
        private AntdUI.TabPage SettingPage;
        private AntdUI.Panel pnlBaseBackupPage;
        private AntdUI.Panel pnlBaseSettingPage;
        private AntdUI.Panel PnlConnectionProfiles;
        private AntdUI.Label label2;
        private AntdUI.Button BtnSaveSetting;
        private AntdUI.Button BtnBackup;
        private AntdUI.Panel PnlDbname;
        private AntdUI.Input InpDbName;
        private AntdUI.Label lblDbName;
        private AntdUI.Panel pnlDbPort;
        private AntdUI.InputNumber InpDbPort;
        private AntdUI.Label label1;
        private AntdUI.Panel pnlHost;
        private AntdUI.Input InpDbHost;
        private AntdUI.Label label3;
        private AntdUI.Panel pnlDbPassword;
        private AntdUI.Input InpDbPassword;
        private AntdUI.Label label4;
        private AntdUI.Button BtnTestConnection;
        private AntdUI.Panel panel3;
        private AntdUI.Label label5;
        private AntdUI.Panel panel5;
        private AntdUI.Input InpDbUser;
        private AntdUI.Label label6;
        private AntdUI.Select DdDatabases;
        private AntdUI.Panel PnlBackupListDatabase;
        private AntdUI.Select SelectDbNameToBackup;
        private AntdUI.Label lblBackupdatabaseNames;
        private AntdUI.Button BtnRetrieveDatabaseNames;
        private AntdUI.Panel PnlBackupSaveTo;
        private AntdUI.Input InpBackupSaveTo;
        private AntdUI.Button BtnbackupSaveTo;
        private AntdUI.Label lblbackupSaveTo;
        private AntdUI.Panel PnlRestorePage;
        private AntdUI.Button BtnRestore;
        private AntdUI.Panel PnlBackupFileToRestore;
        private AntdUI.Input InptBackupFileToRestore;
        private AntdUI.Button BtnBrowseBackupFileToRestore;
        private AntdUI.Label lblBackupFile;
        private AntdUI.Panel pnlDatabaseToRestore;
        private AntdUI.Select InpDatabaseTorestore;
        private AntdUI.Button BtnRetrieveDatabaseToRestore;
        private AntdUI.Label LblDatabaseToRestore;
        private AntdUI.Button BtnMode;
        private AntdUI.ColorPicker colorTheme;
        private AntdUI.TabPage SqlPage;
        private AntdUI.Panel PanelSqlPageBase;
    }
}

