using System.Reflection;

namespace CommunityFabs.NET.Generator;

public static class Utils
{
    public static string GetProjectRoot()
    {
        string appName = Assembly.GetExecutingAssembly().GetName().Name ?? string.Empty;
        var dir = new DirectoryInfo(Environment.CurrentDirectory);
        while (dir != null && dir.Name != appName)
        {
            dir = Directory.GetParent(dir.FullName);
        }
        if (dir == null)
        {
            throw new InvalidOperationException($"Could not find the project root directory for {appName}.");
        }
        return dir.FullName;
    }

    public static void RecursiveDelete(string path, string searchPattern)
    {
        var csFiles = Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories);

        // Recursively delete all .cs files in outPath
        foreach (var file in csFiles)
        {
            File.Delete(file);
        }
    }
}
