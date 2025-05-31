using PostgresqlUtility.Domain;
using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostgresqlUtility.Services;

public sealed class ShellExecutor
{
    private readonly ProcessStartInfo startInfo;
    private readonly Action<string> outputHandler;

    public ShellExecutor(ProcessStartInfo startInfo, Action<string> outputHandler = null)
    {
        this.startInfo = startInfo ?? throw new ArgumentNullException(nameof(startInfo));
        this.outputHandler = outputHandler ?? new Action<string>((s) => { });
    }

    public async Task<(string stdOut, string stdErr)> RunAsync(CancellationToken token)
    {
        var tcs = new TaskCompletionSource<bool>();
        using var process = new Process()
        {
            StartInfo = startInfo,
        };

        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.EnableRaisingEvents = true;
        process.StartInfo.CreateNoWindow = true;

        using (token.Register(() =>
        {
            try
            {
                if (!process.HasExited)
                    process.Kill();
            }
            catch { /* Ignore exceptions if process already exited */ }

            tcs.TrySetCanceled(token);
        }))
        {
            var errBuilder = new StringBuilder();
            var outputBuilder = new StringBuilder();

            process.Exited += (sender, args) =>
            {
                tcs.TrySetResult(true);
            };

            process.OutputDataReceived += (s, e) =>
            {
                if (string.IsNullOrEmpty(e.Data))
                    return;

                outputHandler.Invoke(e.Data);
                outputBuilder.AppendLine(e.Data);
            };

            process.ErrorDataReceived += (s, e) =>
            {
                if (string.IsNullOrEmpty(e.Data))
                    return;

                outputHandler.Invoke(e.Data);
                errBuilder.AppendLine(e.Data);
            };

            process.Start();

            process.BeginOutputReadLine();
            process.BeginErrorReadLine();

            await tcs.Task;

            if (process.ExitCode != 0)
            {
                throw new PostgresqlUtilityException($"Recreate database failed. {errBuilder}");
            }

            return (outputBuilder.ToString(), errBuilder.ToString());
        }
    }
}
