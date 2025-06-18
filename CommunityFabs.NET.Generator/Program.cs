using CommunityFabs.NET.Generator;
using Razor.Templating.Core;

var outPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Sdk");

Utils.RecursiveDelete(outPath, "*.cs");

var toc = await ApiDetails.GetTableOfContents();
var combinedSdkApiRefs = toc.Documents!
    .Where(docRef => docRef.SdkGenMakeMethods != null && docRef.SdkGenMakeMethods.Contains("makeCombinedAPI"));

foreach (var docReference in combinedSdkApiRefs)
{
    var apiDoc = await ApiDetails.GetLegacyDocument(docReference.RelPath!);
    var modelsFileName = $"PlayFab{apiDoc.Name}ApiModels";
    var rendered = await RazorTemplateEngine.RenderAsync("/Views/Models/ApiModel.cshtml", apiDoc);

    var filePath = Path.Combine(outPath, "Models", $"{modelsFileName}.cs");
    await File.WriteAllTextAsync(filePath, rendered);
}