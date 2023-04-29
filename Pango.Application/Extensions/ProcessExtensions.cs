using System.Diagnostics;

namespace Pango.Application.Extensions;

public static class ProcessExtensions
{
    public static bool Failed(this Process process)
    {
        return process.ExitCode != 0;
    }
}
