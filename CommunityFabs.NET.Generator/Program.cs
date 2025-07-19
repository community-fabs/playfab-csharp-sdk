using CommunityFabs.NET.Generator;
using CommunityFabs.NET.Generator.Templates.Models;

var arguments = CommandArguments.Parse(args);

var commonOutPath = Path.Combine(arguments.OutputDirectory, "CommunityFabs.NET.Common");
var instanceOutPath = Path.Combine(arguments.OutputDirectory, "CommunityFabs.NET.Instance");

var sharedStaticPath = Path.Combine(arguments.OutputDirectory, "CommunityFabs.NET.Generator.Templates", "Static", "Shared");
var commonStaticPath = Path.Combine(arguments.OutputDirectory, "CommunityFabs.NET.Generator.Templates", "Static", "Common");

Utils.RecursiveDelete(instanceOutPath, "*.cs");
Utils.RecursiveDelete(commonOutPath, "*.cs");

Utils.RecursiveCopy(sharedStaticPath, commonOutPath);
Utils.RecursiveCopy(sharedStaticPath, instanceOutPath);
Utils.RecursiveCopy(commonStaticPath, commonOutPath);

var toc = await ApiDetails.GetTableOfContents();
var sdkNotesRef = toc.Documents!.Where(docRef => docRef.Format?.Equals("SdkManualNotes") ?? false).Single();
var sdkNotes = await ApiDetails.GetSdkManualNotes(sdkNotesRef.RelPath!);
Console.WriteLine("Fetched SDK Manual Notes");

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

    var instanceFilePath = Path.Combine(instanceOutPath, $"PlayFab{apiDoc.Name}InstanceApi.cs");
    await Utils.RenderToFile(instanceFilePath, "/Views/InstanceApi.cshtml", apiDoc);
}

var errorsFilePath = Path.Combine(commonOutPath, "PlayFabErrors.cs");
await Utils.RenderToFile(errorsFilePath, "/Views/PlayFabErrors.cshtml", apiData.First());

var sdkConstants = new SdkConstants()
{
    BuildIdentifier = "custom_community-playfab-csharp-sdk",
    SdkVersion = sdkNotes.SdkVersion!["csharp"],
    BuildSuffix = arguments.BuildSuffix
};
var constantsFilePath = Path.Combine(commonOutPath, "Constants.cs");
await Utils.RenderToFile(constantsFilePath, "/Views/Constants.cshtml", sdkConstants);

var buildPropsFilePath = Path.Combine(arguments.OutputDirectory, "Directory.Build.props");
await Utils.RenderToFile(buildPropsFilePath, "/Views/Directory.Build.props.cshtml", sdkConstants);