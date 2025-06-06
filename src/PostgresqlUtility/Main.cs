﻿using AntdUI;
using PostgresqlUtility.Connection;
using PostgresqlUtility.Domain;
using PostgresqlUtility.Pages;
using PostgresqlUtility.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FolderBrowserDialog = AntdUI.FolderBrowserDialog;
using Message = AntdUI.Message;

namespace PostgresqlUtility;

public partial class Main : Window
{
    private readonly AppConfig appConfig = AppConfig.Instance;
    private readonly DbService dbService;

    public Main()
    {
        InitializeComponent();
        dbService = new DbService(appConfig.PostgresqlBinPath, appConfig.PostgresqlConnectionContext);

        var sqlPage = new SqlPage(this, appConfig);
        PanelSqlPageBase.Controls.Add(sqlPage);
        sqlPage.Dock = DockStyle.Fill;
    }

    public AppConfig AppConfig => appConfig;

    private void BtnBrowsePostgrePath_Click(object sender, EventArgs e)
    {
        var frm = new FolderBrowserDialog();
        if (frm.ShowDialog(this) is DialogResult.OK)
        {
            InpPgBinPath.Text = frm.DirectoryPath;
        }
    }

    private async void BtnBackup_Click(object sender, EventArgs e)
    {
        BtnBackup.Enabled = false;

        var context = AppConfig.PostgresqlConnectionContext;
        var pgDumpPath = InpPgBinPath.Text;

        if (string.IsNullOrEmpty(pgDumpPath))
        {
            Message.error(this, "Please select the PostgreSQL bin path.");
        }

        var backup = new BackupDatabase(context);
        var outputPath = InpBackupSaveTo.Text;
        var dbName = SelectDbNameToBackup.Text;

        try
        {
            await backup.BackupAsync(pgDumpPath, dbName, outputPath);
            Message.success(this, $"Backup completed successfully. Output: {outputPath}");
        }
        catch (Exception)
        {
            Message.error(this, $"Backup failed");
        }
        finally
        {
            BtnBackup.Enabled = true;
        }
    }

    private async void BtnSaveSetting_Click(object sender, EventArgs e)
    {
        try
        {
            var config = CreateAppConfigFromSetting();
            var success = await DbService.TestConnectionAsync(config.PostgresqlBinPath, config.PostgresqlConnectionContext);
            if (!success)
            {
                throw new PostgresqlUtilityException("Connection failed. Please check your settings.");
            }

            config.Save();
            Message.success(this, "Setting saved successfully. Please restart the application to apply changes.");
        }
        catch (Exception err)
        {
            Message.error(this, $"Connection failed. {err.Message}");
        }
    }

    private AppConfig CreateAppConfigFromSetting()
    {
        var context = new PostgresqlConnectionContext
        {
            Port = (int)InpDbPort.Value,
            DatabaseName = InpDbName.Text,
            DatabasePassword = InpDbPassword.Text,
            DatabaseUser = InpDbUser.Text,
            Host = InpDbHost.Text,
        };

        var config = new AppConfig
        {
            PostgresqlConnectionContext = context,
            PostgresqlBinPath = InpPgBinPath.Text,
        };

        return config;
    }

    private async void BtnTestConnection_Click(object sender, EventArgs e)
    {
        try
        {
            BtnTestConnection.Enabled = false;

            var config = CreateAppConfigFromSetting();
            var success = await DbService.TestConnectionAsync(config.PostgresqlBinPath, config.PostgresqlConnectionContext);

            if (!success)
            {
                throw new PostgresqlUtilityException("Connection to database failed. Check your conncetion profiles!");
            }

            var service = new DbService(config.PostgresqlBinPath, config.PostgresqlConnectionContext);
            var db = await service.GetAllDatabaseNameAsync();
            DdDatabases.Items.Clear();
            foreach (var dbName in db)
            {
                DdDatabases.Items.Add(dbName);
            }

            Message.success(this, "Connection successful.");
        }
        catch (Exception err)
        {
            Message.error(this, err.Message);
        }
        finally
        {
            BtnTestConnection.Enabled = true;
        }
    }

    private void Main_Shown(object sender, EventArgs e)
    {
        try
        {
            InpPgBinPath.Text = AppConfig.PostgresqlBinPath;
            InpDbHost.Text = AppConfig.PostgresqlConnectionContext.Host;
            InpDbPort.Value = AppConfig.PostgresqlConnectionContext.Port;
            InpDbName.Text = AppConfig.PostgresqlConnectionContext.DatabaseName;
            InpDbUser.Text = AppConfig.PostgresqlConnectionContext.DatabaseUser;
            InpDbPassword.Text = AppConfig.PostgresqlConnectionContext.DatabasePassword;
            DdDatabases.Items.Clear();

            tabs.SelectedTab = SqlPage;
        }
        catch (Exception err)
        {
            Message.error(this, err.Message);
        }
    }

    private async void BtnRetrieveDatabaseNames_Click(object sender, EventArgs e)
    {
        try
        {
            BtnRetrieveDatabaseNames.Enabled = false;

            await RetrieveDatabaseAndSetToControl(dbService, SelectDbNameToBackup);
        }
        catch (Exception err)
        {
            Message.error(this, err.Message);
        }
        finally
        {
            BtnRetrieveDatabaseNames.Enabled = true;
        }
    }

    private void BtnbackupSaveTo_Click(object sender, EventArgs e)
    {
        try
        {
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PostgreSQL Dump (*.dump)|*.dump";
            saveFileDialog.Title = "Save PostgreSQL Backup";
            saveFileDialog.DefaultExt = "dump";
            saveFileDialog.FileName = "backup.dump";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() is DialogResult.OK)
            {
                string selectedPath = saveFileDialog.FileName;
                InpBackupSaveTo.Text = selectedPath;
            }
        }
        catch (Exception err)
        {
            Message.error(this, err.Message);
        }
    }

    private static async Task RetrieveDatabaseAndSetToControl(DbService dbService, Select control)
    {
        var db = await dbService.GetAllDatabaseNameAsync();

        static void SetDatabaseToControl(Select control, IEnumerable<string> db)
        {
            control.Items.Clear();
            control.Items.AddRange([.. db]);
            if (db.Any())
            {
                control.SelectedIndex = 0;
            }
        }

        if (control.InvokeRequired)
        {
            await control.InvokeAsync(new Action(() => SetDatabaseToControl(control, db)));
        }
        else
        {
            SetDatabaseToControl(control, db);
        }
    }

    private async void BtnRetrieveDatabaseToRestore_Click(object sender, EventArgs e)
    {
        try
        {
            await RetrieveDatabaseAndSetToControl(dbService, InpDatabaseTorestore);
        }
        catch (Exception err)
        {
            Message.error(this, err.Message);
        }
    }

    private void BtnBrowseBackupFileToRestore_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = new OpenFileDialog();
            frm.Filter = "PostgreSQL Dump (*.dump)|*.dump";
            frm.Title = "Select PostgreSQL Backup File";
            frm.CheckFileExists = true;
            frm.CheckPathExists = true;
            frm.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (frm.ShowDialog(this) is DialogResult.OK)
            {
                string selectedPath = frm.FileName;
                InptBackupFileToRestore.Text = selectedPath;
            }
        }
        catch (Exception err)
        {
            Message.error(this, err.Message);
        }
    }

    private async void BtnRestore_Click(object sender, EventArgs e)
    {
        try
        {
            BtnRestore.Enabled = false;

            using var cts = new CancellationTokenSource();
            var dbName = InpDatabaseTorestore.Text;

            if (string.IsNullOrEmpty(dbName))
            {
                Message.error(this, "Please select the database to restore.");
                return;
            }

            var db = await dbService.GetAllDatabaseNameAsync();
            if (db.Any(d => d.Equals(dbName, StringComparison.OrdinalIgnoreCase)))
            {
                var result = AntdUI.Modal.open(new Modal.Config(this,
                     "Database Already Exists.",
                     $"Database '{dbName}' already exists. Do you want to process it? {Environment.NewLine}{Environment.NewLine}(It will drop the database {dbName}. Ensure you already has the backup file!)",
                     TType.Warn)
                {
                    CancelText = "Cancel",
                    OkText = "Yes",
                });

                if (result is not DialogResult.OK)
                {
                    return;
                }
            }

            var restore = new RestoreDatabase(appConfig.PostgresqlConnectionContext);
            await restore.RestoreAsync(InpPgBinPath.Text, InptBackupFileToRestore.Text, dbName, cts.Token);

            Message.info(this, $"Database \"{dbName}\" successfully restored.");
        }
        catch (Exception err)
        {
            Message.error(this, $"Restore Database gagal. {Environment.NewLine}{err.Message}");
        }
        finally
        {
            BtnRestore.Enabled = true;
        }
    }

    private void BtnMode_Click(object sender, EventArgs e)
    {
        try
        {
            if (setcolor)
            {
                var color = Style.Db.Primary;
                Config.IsDark = !Config.IsDark;
                Dark = Config.IsDark;
                Style.SetPrimary(color);
            }
            else
            {
                Config.IsDark = !Config.IsDark;
                Dark = Config.IsDark;
            }

            BtnMode.Toggle = Dark;
            if (Dark)
            {
                BackColor = Color.Black;
                ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
            OnSizeChanged(e);
        }
        catch (Exception err)
        {
            Message.error(this, err.Message);
        }
    }

    bool setcolor = false;
    private void ColorTheme_ValueChanged(object sender, ColorEventArgs e)
    {
        setcolor = true;
        Style.SetPrimary(e.Value);
        Refresh();
    }
}
