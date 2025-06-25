using Razor.Templating.Core;
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

    public static void RecursiveCopy(string source, string target)
    {
        if (!Directory.Exists(source))
        {
            throw new Exception($"Source directory '{source}' does not exist.");
        }

        var sourceFiles = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories);
        foreach (var file in sourceFiles)
        {
            var relativePath = Path.GetRelativePath(source, file);
            var destinationPath = Path.Combine(target, relativePath);
            Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);
            File.Copy(file, destinationPath, true);
        }
    }

    public static async Task RenderToFile<T>(string filePath, string templatePath, T model) where T : class
    {
        if (string.IsNullOrEmpty(filePath))
        {
            throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
        }
        if (string.IsNullOrEmpty(templatePath))
        {
            throw new ArgumentException("Template path cannot be null or empty.", nameof(templatePath));
        }
        var renderedContent = await RazorTemplateEngine.RenderAsync(templatePath, model);
        await File.WriteAllTextAsync(filePath, renderedContent);
    }
}
