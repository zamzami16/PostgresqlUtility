namespace PostgresqlUtility.Extensions;

public static class ButtonExtension
{
    const string BTN_CANCEL_TAG = "Cancel";

    public static AntdUI.Button AsCancelButton(this AntdUI.Button button)
    {
        button.Text = "Cancel";
        button.Enabled = true;
        button.Type = AntdUI.TTypeMini.Warn;
        button.Tag = BTN_CANCEL_TAG;

        return button;
    }

    public static bool IsCancelButton(this AntdUI.Button button)
    {
        return button.Tag is BTN_CANCEL_TAG;
    }

    public static AntdUI.Button AsPrimaryButton(this AntdUI.Button button, string text = "OK")
    {
        button.Text = text;
        button.Enabled = true;
        button.Type = AntdUI.TTypeMini.Primary;
        button.Tag = text;

        return button;
    }
}
