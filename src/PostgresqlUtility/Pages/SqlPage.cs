using PostgresqlUtility.Connection;
using PostgresqlUtility.Domain;
using PostgresqlUtility.Extensions;
using PostgresqlUtility.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Message = AntdUI.Message;

namespace PostgresqlUtility.Pages;

public partial class SqlPage : UserControl
{
    const string SQL_TEMP_FILE_NAME = "temp_sql.sql";
    private new readonly Form ParentForm;
    private readonly AppConfig appConfig;
    private string sqlString;
    private bool sqlStringTooLong = false;

    public SqlPage(Form parent, AppConfig appConfig)
    {
        InitializeComponent();
        this.ParentForm = parent;
        this.appConfig = appConfig;

        input1.MaxLength = int.MaxValue;
        input1.LostFocusClearSelection = false;
    }

    private void BtnSqlFile_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = new OpenFileDialog();
            frm.Filter = "SQL or Text Files (*.sql;*.txt)|*.sql;*.txt";
            frm.CheckFileExists = true;
            frm.CheckPathExists = true;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var file = frm.FileName;
                InpSqlFile.Text = file;
                sqlStringTooLong = false;

                var sqlFile = File.ReadAllText(file);
                sqlString = sqlFile;
                if (sqlFile.Length > input1.MaxLength)
                {
                    Message.warn(ParentForm, "File too long ...");
                    input1.Text = sqlFile[1_000..];
                    sqlStringTooLong = true;
                    return;
                }
                input1.Text = sqlFile;
            }
        }
        catch (Exception err)
        {
            Message.error(ParentForm, err.Message);
        }
    }

    private async void BtnExecute_Click(object sender, EventArgs e)
    {
        try
        {
            using var cts = new CancellationTokenSource();

            if (select1.IsTextEmpty)
            {
                Message.error(ParentForm, "No target database selected.");
                return;
            }

            if (string.IsNullOrWhiteSpace(input1.Text))
            {
                Message.error(ParentForm, "No sql are selected.");
                return;
            }

            var context = new PostgresqlConnectionContext
            {
                DatabaseName = select1.Text,
                DatabasePassword = appConfig.PostgresqlConnectionContext.DatabasePassword,
                DatabaseUser = appConfig.PostgresqlConnectionContext.DatabaseUser,
                Host = appConfig.PostgresqlConnectionContext.Host,
                Port = appConfig.PostgresqlConnectionContext.Port,
            };

            var sqlQuery = new PsqlQuery(context, PsqlQuery.PsqlOptions.Default);

            if (sqlStringTooLong
                && File.Exists(InpSqlFile.Text))
            {
                sqlQuery = new PsqlQuery(appConfig.PostgresqlConnectionContext);
                await sqlQuery.ExecuteSqlFileAsync(appConfig.PostgresqlBinPath, InpSqlFile.Text, cts.Token);
                return;
            }

            await File.WriteAllTextAsync(
                SQL_TEMP_FILE_NAME,
                string.IsNullOrWhiteSpace(input1.SelectedText)
                    ? input1.Text
                    : input1.SelectedText);

            var result = await sqlQuery.ExecuteSqlFileAsync(appConfig.PostgresqlBinPath, SQL_TEMP_FILE_NAME, cts.Token);
            Message.info(ParentForm, $"Query successfully executed{Environment.NewLine}{result}");
        }
        catch (Exception err)
        {
            Message.error(ParentForm, err.Message);
        }
    }

    private IEnumerable<string> DatabaseNames;
    private void Select1_Click(object sender, EventArgs e)
    {
        try
        {
            if (DatabaseNames is null)
            {
                ParentForm.ShowSpin(async (config) =>
                {
                    try
                    {
                        var dbService = new DbService(appConfig.PostgresqlBinPath, appConfig.PostgresqlConnectionContext);
                        DatabaseNames = [.. await dbService.GetAllDatabaseNameAsync()];
                        if (DatabaseNames is not null)
                        {
                            select1.Items.AddRange([.. DatabaseNames]);
                        }
                    }
                    catch (Exception err)
                    {
                        throw new PostgresqlUtilityException("Unable to load database names. Please check you connection settings.", err);
                    }
                });
            }
        }
        catch (Exception err)
        {
            Message.error(ParentForm, err.Message);
        }
    }
}
