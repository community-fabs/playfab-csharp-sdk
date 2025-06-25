using Microsoft.Azure.Functions.Worker.Http;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Models.Profiles;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk.Functions;

class TitleAuthenticationContext
{
    public required string Id { get; set; }

    public required string EntityToken { get; set; }
}

public class PlayFabFunctionContext<TFunctionArgument>
{
    private class FunctionContextInternal
    {
        public required TitleAuthenticationContext TitleAuthenticationContext { get; set; }

        public required EntityProfileBody CallerEntityProfile { get; set; }

        public required TFunctionArgument FunctionArgument { get; set; }
    }

    public required PlayFabApiSettings ApiSettings { get; set; }

    public required PlayFabAuthenticationContext AuthenticationContext { get; set; }

    public required EntityProfileBody CallerEntityProfile { get; set; }

    public required TFunctionArgument FunctionArgument { get; set; }

    public string? CurrentPlayerId { get; set; }

    protected PlayFabFunctionContext()
    {
    }

    public static async Task<PlayFabFunctionContext<TFunctionArgument>> From(HttpRequestData request)
    {
        var content = await request.ReadAsStringAsync();

        if (string.IsNullOrEmpty(content))
        {
            throw new ArgumentException("Request content empty", nameof(request));
        }
        return From(content);
    }

    public static PlayFabFunctionContext<TFunctionArgument> From(string requestData)
    {
        var functionContextInternal = JsonSerializer.Deserialize<FunctionContextInternal>(requestData);

        if (functionContextInternal == null)
        {
            throw new InvalidOperationException("Function context could not be deserialized from the request data.");
        }

        return new PlayFabFunctionContext<TFunctionArgument>
        {
            ApiSettings = new()
            {
                TitleId = functionContextInternal.TitleAuthenticationContext?.Id ?? "",
                DeveloperSecretKey = Environment.GetEnvironmentVariable(Constants.EnvVars.PLAYFAB_DEV_SECRET_KEY, EnvironmentVariableTarget.Process) ?? "",
                VerticalName = Environment.GetEnvironmentVariable(Constants.EnvVars.PLAYFAB_CLOUD_NAME, EnvironmentVariableTarget.Process)
            },
            CallerEntityProfile = functionContextInternal.CallerEntityProfile,
            FunctionArgument = functionContextInternal.FunctionArgument,
            AuthenticationContext = new()
            {
                EntityId = functionContextInternal.TitleAuthenticationContext?.Id,
                EntityType = functionContextInternal.CallerEntityProfile?.Entity?.Type,
                EntityToken = functionContextInternal.TitleAuthenticationContext?.EntityToken
            },
            CurrentPlayerId = functionContextInternal.CallerEntityProfile?.Lineage?.TitlePlayerAccountId
        };
    }
}
