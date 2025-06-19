using CommunityFabs.NET.Generator;
using Razor.Templating.Core;

var outPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Sdk");
var staticPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Generator.Templates", "Static");

Utils.RecursiveDelete(outPath, "*.cs");

Utils.RecursiveCopy(staticPath, outPath);

var toc = await ApiDetails.GetTableOfContents();
var combinedSdkApiRefs = toc.Documents!
    .Where(docRef => docRef.SdkGenMakeMethods != null && docRef.SdkGenMakeMethods.Contains("makeCombinedAPI"));
Console.WriteLine("Fetched Table of Contents with {0} documents to process", toc.Documents!.Count);

foreach (var docReference in combinedSdkApiRefs)
{
    var apiDoc = await ApiDetails.GetLegacyDocument(docReference.RelPath!);
    Console.WriteLine("Fetched {0} with {1} methods and {2} data types", docReference.RelPath!, apiDoc.Calls!.Count, apiDoc.Datatypes!.Count);

    var modelsFileName = $"PlayFab{apiDoc.Name}ApiModels";
    var rendered = await RazorTemplateEngine.RenderAsync("/Views/Models/ApiModel.cshtml", apiDoc);

    var filePath = Path.Combine(outPath, "Models", $"{modelsFileName}.cs");
    await File.WriteAllTextAsync(filePath, rendered);
}