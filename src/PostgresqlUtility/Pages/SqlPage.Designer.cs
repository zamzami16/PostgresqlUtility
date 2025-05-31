namespace PostgresqlUtility.Pages;

partial class SqlPage
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new AntdUI.Panel();
        panel2 = new AntdUI.Panel();
        panel4 = new AntdUI.Panel();
        input1 = new AntdUI.Input();
        panel3 = new AntdUI.Panel();
        panel5 = new AntdUI.Panel();
        select1 = new AntdUI.Select();
        label1 = new AntdUI.Label();
        BtnExecute = new AntdUI.Button();
        PnlBackupSaveTo = new AntdUI.Panel();
        InpSqlFile = new AntdUI.Input();
        BtnSqlFile = new AntdUI.Button();
        lblbackupSaveTo = new AntdUI.Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel4.SuspendLayout();
        panel3.SuspendLayout();
        panel5.SuspendLayout();
        PnlBackupSaveTo.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(PnlBackupSaveTo);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(820, 414);
        panel1.TabIndex = 0;
        panel1.Text = "panel1";
        // 
        // panel2
        // 
        panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        panel2.Controls.Add(panel4);
        panel2.Controls.Add(panel3);
        panel2.Location = new System.Drawing.Point(10, 68);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(799, 333);
        panel2.TabIndex = 9;
        panel2.Text = "panel2";
        // 
        // panel4
        // 
        panel4.Controls.Add(input1);
        panel4.Dock = System.Windows.Forms.DockStyle.Fill;
        panel4.Location = new System.Drawing.Point(0, 43);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(799, 290);
        panel4.TabIndex = 10;
        panel4.Text = "panel4";
        // 
        // input1
        // 
        input1.AllowClear = true;
        input1.AutoScroll = true;
        input1.Dock = System.Windows.Forms.DockStyle.Fill;
        input1.Font = new System.Drawing.Font("Segoe UI", 12F);
        input1.Location = new System.Drawing.Point(0, 0);
        input1.Margin = new System.Windows.Forms.Padding(0);
        input1.MaxLength = -1;
        input1.Multiline = true;
        input1.Name = "input1";
        input1.Size = new System.Drawing.Size(799, 290);
        input1.TabIndex = 8;
        // 
        // panel3
        // 
        panel3.Controls.Add(panel5);
        panel3.Controls.Add(BtnExecute);
        panel3.Dock = System.Windows.Forms.DockStyle.Top;
        panel3.Location = new System.Drawing.Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(799, 43);
        panel3.TabIndex = 9;
        panel3.Text = "panel3";
        // 
        // panel5
        // 
        panel5.BorderWidth = 1F;
        panel5.Controls.Add(select1);
        panel5.Controls.Add(label1);
        panel5.Dock = System.Windows.Forms.DockStyle.Fill;
        panel5.Location = new System.Drawing.Point(0, 0);
        panel5.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
        panel5.Name = "panel5";
        panel5.Size = new System.Drawing.Size(711, 43);
        panel5.TabIndex = 11;
        panel5.Text = "panel1";
        // 
        // select1
        // 
        select1.Dock = System.Windows.Forms.DockStyle.Fill;
        select1.DropDownArrow = true;
        select1.List = true;
        select1.ListAutoWidth = true;
        select1.Location = new System.Drawing.Point(76, 1);
        select1.MaxCount = 10;
        select1.Name = "select1";
        select1.PlaceholderText = "Select Database";
        select1.Size = new System.Drawing.Size(634, 41);
        select1.TabIndex = 1;
        select1.Click += Select1_Click;
        // 
        // label1
        // 
        label1.Dock = System.Windows.Forms.DockStyle.Left;
        label1.Location = new System.Drawing.Point(1, 1);
        label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(75, 41);
        label1.Suffix = ":";
        label1.TabIndex = 0;
        label1.Text = "DATABASE";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // BtnExecute
        // 
        BtnExecute.Dock = System.Windows.Forms.DockStyle.Right;
        BtnExecute.Location = new System.Drawing.Point(711, 0);
        BtnExecute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        BtnExecute.Name = "BtnExecute";
        BtnExecute.Size = new System.Drawing.Size(88, 43);
        BtnExecute.TabIndex = 10;
        BtnExecute.Text = "Run";
        BtnExecute.Type = AntdUI.TTypeMini.Success;
        BtnExecute.Click += BtnExecute_Click;
        // 
        // PnlBackupSaveTo
        // 
        PnlBackupSaveTo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        PnlBackupSaveTo.BorderWidth = 1F;
        PnlBackupSaveTo.Controls.Add(InpSqlFile);
        PnlBackupSaveTo.Controls.Add(BtnSqlFile);
        PnlBackupSaveTo.Controls.Add(lblbackupSaveTo);
        PnlBackupSaveTo.Location = new System.Drawing.Point(10, 20);
        PnlBackupSaveTo.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
        PnlBackupSaveTo.Name = "PnlBackupSaveTo";
        PnlBackupSaveTo.Size = new System.Drawing.Size(800, 42);
        PnlBackupSaveTo.TabIndex = 7;
        PnlBackupSaveTo.Text = "panel1";
        // 
        // InpSqlFile
        // 
        InpSqlFile.Dock = System.Windows.Forms.DockStyle.Fill;
        InpSqlFile.Location = new System.Drawing.Point(76, 1);
        InpSqlFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        InpSqlFile.Name = "InpSqlFile";
        InpSqlFile.Size = new System.Drawing.Size(635, 40);
        InpSqlFile.TabIndex = 3;
        // 
        // BtnSqlFile
        // 
        BtnSqlFile.Dock = System.Windows.Forms.DockStyle.Right;
        BtnSqlFile.Location = new System.Drawing.Point(711, 1);
        BtnSqlFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        BtnSqlFile.Name = "BtnSqlFile";
        BtnSqlFile.Size = new System.Drawing.Size(88, 40);
        BtnSqlFile.TabIndex = 2;
        BtnSqlFile.Text = "Browse";
        BtnSqlFile.Type = AntdUI.TTypeMini.Primary;
        BtnSqlFile.Click += BtnSqlFile_Click;
        // 
        // lblbackupSaveTo
        // 
        lblbackupSaveTo.Dock = System.Windows.Forms.DockStyle.Left;
        lblbackupSaveTo.Location = new System.Drawing.Point(1, 1);
        lblbackupSaveTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        lblbackupSaveTo.Name = "lblbackupSaveTo";
        lblbackupSaveTo.Size = new System.Drawing.Size(75, 40);
        lblbackupSaveTo.Suffix = ":";
        lblbackupSaveTo.TabIndex = 0;
        lblbackupSaveTo.Text = "SQL FILE";
        lblbackupSaveTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SqlPage
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(panel1);
        Name = "SqlPage";
        Size = new System.Drawing.Size(820, 414);
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel4.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel5.ResumeLayout(false);
        PnlBackupSaveTo.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private AntdUI.Panel panel1;
    private AntdUI.Panel PnlBackupSaveTo;
    private AntdUI.Input InpSqlFile;
    private AntdUI.Button BtnSqlFile;
    private AntdUI.Label lblbackupSaveTo;
    private AntdUI.Input input1;
    private AntdUI.Panel panel2;
    private AntdUI.Panel panel3;
    private AntdUI.Button BtnExecute;
    private AntdUI.Panel panel4;
    private AntdUI.Panel panel5;
    private AntdUI.Label label1;
    private AntdUI.Select select1;
}
