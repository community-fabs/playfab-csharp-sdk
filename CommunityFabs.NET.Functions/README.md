# Unofficial PlayFab C# SDK (Azure Functions helpers)

## Overview

Unofficial C# SDK for PlayFab, with helpers for Azure Functions

> ⚠️ This SDK is not officially endorsed or supported by the PlayFab team in any way, shape, or form.

## Features

- Models are now compatible with `System.Text.Json` serialization
- .NET 8 Isolated Workers are supported
- Additional documentation and usage instructions are provided

## Sample Usage
### .NET 8 Isolated Worker
```csharp
using CommunityFabs.NET.Common.Models.Admin;
using CommunityFabs.NET.Functions;
using CommunityFabs.NET.Instance;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace CommunityFabs.NET.Samples.Functions;

public class SampleFunction
{
    [Function("SampleFunction")]
    public async Task<GetPlayerProfileResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequestData req)
    {
        // Create a PlayFabFunctionContext from the HttpRequestData
        var context = await PlayFabFunctionContext<dynamic>.From(req);

        // Create a new instance of the Admin API client
        var adminApi = new PlayFabAdminInstanceApi(context.ApiSettings, context.AuthenticationContext);

        // Example: Update the user's display name
        await adminApi.UpdateUserTitleDisplayNameAsync(new UpdateUserTitleDisplayNameRequest
        {
            PlayFabId = context.CallerEntityProfile.Lineage.MasterPlayerAccountId,
            DisplayName = "Test1234"
        });

        return new() {
            PlayerProfile = new() {
                DisplayName = "Test1234",
                AvatarUrl = "https://example.com/avatar.png" // Replace with a valid image URL
            }
        };
    }
}
```

## Acknowledgements

- The PlayFab team
- The [CommunityFabs](https://github.com/community-fabs) team

## Copyright and Licensing Information:

Apache License --
Version 2.0, January 2004
http://www.apache.org/licenses/

Full details available within the LICENSE file.