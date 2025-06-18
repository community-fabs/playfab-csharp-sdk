using CommunityFabs.NET.Generator;
using Razor.Templating.Core;

var outPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Sdk");

Utils.RecursiveDelete(outPath, "*.cs");

for (int i = 1; i <= 10; i++)
{
    var className = $"GeneratedClass{i}";
    var rendered = await RazorTemplateEngine.RenderAsync("/Views/Model.cshtml", className);

    var filePath = Path.Combine(outPath, "Models", $"{className}.cs");
    await File.WriteAllTextAsync(filePath, rendered);
}