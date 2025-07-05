using CommunityFabs.NET.Generator;

var outPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Sdk");
var commonOutPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Sdk.Common");
var commonStaticPath = Path.Combine(Utils.GetProjectRoot(), "..", "CommunityFabs.NET.Generator.Templates", "Static", "Common");

Utils.RecursiveDelete(outPath, "*.cs");
Utils.RecursiveDelete(commonOutPath, "*.cs");

Utils.RecursiveCopy(commonStaticPath, commonOutPath);

var toc = await ApiDetails.GetTableOfContents();
var combinedSdkApiRefs = toc.Documents!
    .Where(docRef => docRef.SdkGenMakeMethods != null && docRef.SdkGenMakeMethods.Contains("makeCombinedAPI"));
Console.WriteLine("Fetched Table of Contents with {0} documents to process", combinedSdkApiRefs.Count());

var apiData = await Task.WhenAll(combinedSdkApiRefs.Select(docRef => ApiDetails.GetLegacyDocument(docRef.RelPath!)));

foreach (var apiDoc in apiData)
{
    Console.WriteLine("Processing PlayFab{0}Api with {1} methods and {2} data types", apiDoc.Name, apiDoc.Calls!.Count, apiDoc.Datatypes!.Count);

    var modelFilePath = Path.Combine(commonOutPath, "Models", $"PlayFab{apiDoc.Name}ApiModels.cs");
    await Utils.RenderToFile(modelFilePath, "/Views/Models/ApiModel.cshtml", apiDoc);

    var interfaceFilePath = Path.Combine(commonOutPath, "Interfaces", $"IPlayFab{apiDoc.Name}Api.cs");
    await Utils.RenderToFile(interfaceFilePath, "/Views/Interface.cshtml", apiDoc);

    var instanceFilePath = Path.Combine(outPath, $"PlayFab{apiDoc.Name}InstanceApi.cs");
    await Utils.RenderToFile(instanceFilePath, "/Views/InstanceApi.cshtml", apiDoc);
}

var errorsFilePath = Path.Combine(commonOutPath, "PlayFabErrors.cs");
await Utils.RenderToFile(errorsFilePath, "/Views/PlayFabErrors.cshtml", apiData.First());