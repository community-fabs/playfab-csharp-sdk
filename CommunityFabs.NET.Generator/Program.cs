using CommunityFabs.NET.Generator;
using Razor.Templating.Core;

var outPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Sdk");
var staticPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Generator.Templates", "Static");

Utils.RecursiveDelete(outPath, "*.cs");

Utils.RecursiveCopy(staticPath, outPath);

var toc = await ApiDetails.GetTableOfContents();
var combinedSdkApiRefs = toc.Documents!
    .Where(docRef => docRef.SdkGenMakeMethods != null && docRef.SdkGenMakeMethods.Contains("makeCombinedAPI"));
Console.WriteLine("Fetched Table of Contents with {0} documents to process", combinedSdkApiRefs.Count());

var apiData = await Task.WhenAll(combinedSdkApiRefs.Select(docRef => ApiDetails.GetLegacyDocument(docRef.RelPath!)));

foreach (var apiDoc in apiData)
{
    Console.WriteLine("Processing PlayFab{0}Api with {1} methods and {2} data types", apiDoc.Name, apiDoc.Calls!.Count, apiDoc.Datatypes!.Count);

    var modelsFileName = $"PlayFab{apiDoc.Name}ApiModels";
    var renderedModel = await RazorTemplateEngine.RenderAsync("/Views/Models/ApiModel.cshtml", apiDoc);

    var modelFilePath = Path.Combine(outPath, "Models", $"{modelsFileName}.cs");
    await File.WriteAllTextAsync(modelFilePath, renderedModel);

    var interfaceFileName = $"IPlayFab{apiDoc.Name}Api";
    var renderedInterface = await RazorTemplateEngine.RenderAsync("/Views/Interface.cshtml", apiDoc);

    var interfaceFilePath = Path.Combine(outPath, "Interfaces", $"{interfaceFileName}.cs");
    await File.WriteAllTextAsync(interfaceFilePath, renderedInterface);

    var instanceFileName = $"PlayFab{apiDoc.Name}InstanceApi";
    var renderedInstance = await RazorTemplateEngine.RenderAsync("/Views/InstanceApi.cshtml", apiDoc);

    var instanceFilePath = Path.Combine(outPath, $"{instanceFileName}.cs");
    await File.WriteAllTextAsync(instanceFilePath, renderedInstance);
}

var renderedErrors = await RazorTemplateEngine.RenderAsync("/Views/PlayFabErrors.cshtml", apiData.First());

var errorsFilePath = Path.Combine(outPath, "PlayFabErrors.cs");
await File.WriteAllTextAsync(errorsFilePath, renderedErrors);