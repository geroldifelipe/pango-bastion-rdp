using System.Runtime.InteropServices;

namespace Pango.Application.PlatformShell;

public class PlatformShellOptions
{
    private PlatformShellOptions(string shell, string shellCommandParser)
    {
        Shell = shell;
        ShellCommandParser = shellCommandParser;
    }

    public string Shell { get; private set; } = null!;
    public string ShellCommandParser { get; private set; } = null!;

    public static PlatformShellOptions GetOptions()
    {
        PlatformShellOptions options;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            options = new PlatformShellOptions(shell: "cmd", shellCommandParser: "/C");
        else
            options = new PlatformShellOptions(shell: "/bin/bash", shellCommandParser: "-c");

        return options;
    }
}
