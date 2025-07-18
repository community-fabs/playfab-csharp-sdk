namespace CommunityFabs.NET.Sdk.Common;

public static class Constants
{
    public const string SdkVersion = "1.204.250704";
    public const string BuildIdentifier = "custom_community-playfab-csharp-sdk";
    public const string SdkVersionString = "CSharpSDK-1.204.250704";
    public const string DefaultProductionEnvironmentUrl = "playfabapi.com";

    public struct EnvVars
    {
        public const string PLAYFAB_DEV_SECRET_KEY = "PLAYFAB_DEV_SECRET_KEY";
        public const string PLAYFAB_TITLE_ID = "PLAYFAB_TITLE_ID";
        public const string PLAYFAB_CLOUD_NAME = "PLAYFAB_CLOUD_NAME";
    }
}