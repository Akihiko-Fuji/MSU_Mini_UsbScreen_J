using System.IO;
using System.Reflection;

namespace UsbScreen.Utils;

public static class FontHelper
{
    public const string JapaneseFontFileName = "JF-Dot-MPlusH12.ttf";

    public static Stream? GetDefaultFontStream()
    {
        var externalFontPath = ResolveJapaneseFontPath();
        if (externalFontPath != null)
        {
            return File.OpenRead(externalFontPath);
        }

        // Keep the original embedded font as a compatibility fallback.
        var assembly = Assembly.GetExecutingAssembly();
        return assembly.GetManifestResourceStream("UsbScreen.Core.Fonts.SourceHanSansSC-Normal-Min.ttf");
    }

    public static string? ResolveJapaneseFontPath()
    {
        var configuredPath = Environment.GetEnvironmentVariable("USBSCREEN_FONT_PATH");
        if (!string.IsNullOrWhiteSpace(configuredPath) && File.Exists(configuredPath))
        {
            return Path.GetFullPath(configuredPath);
        }

        var candidates = new[]
        {
            Path.Combine(AppContext.BaseDirectory, "Fonts", JapaneseFontFileName),
            Path.Combine(AppContext.BaseDirectory, JapaneseFontFileName),
            Path.Combine(Directory.GetCurrentDirectory(), "Fonts", JapaneseFontFileName)
        };

        foreach (var candidate in candidates)
        {
            if (File.Exists(candidate))
            {
                return Path.GetFullPath(candidate);
            }
        }

        return null;
    }
}
