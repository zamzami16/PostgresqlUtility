using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgresqlUtility.Extensions;

public static class FormExtensions
{
    public static void ShowSpin(this Form form,
        Func<AntdUI.Spin.Config, Task> func,
        string text = "Loading ...")
    {
        AntdUI.Spin.open(form, text, async config =>
        {
            try
            {
                config.Text = text;
                await func(config);
            }
            catch (Exception err)
            {
                AntdUI.Message.error(form, err.Message);
            }
        });
    }
}
