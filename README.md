[![](https://img.shields.io/nuget/v/soenneker.paddle.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.paddle.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.paddle.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.paddle.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.paddle.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.paddle.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.paddle.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.paddle.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Paddle.OpenApiClient

Typed request builders and models for working with Paddle billing data from .NET.

## Installation

```bash
dotnet add package Soenneker.Paddle.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Paddle.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", apiKey);
httpClient.DefaultRequestHeaders.Add("Paddle-Version", "1");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);
adapter.BaseUrl = "https://sandbox-api.paddle.com";

var client = new PaddleOpenApiClient(adapter);
var eventTypes = await client.EventTypes.GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to Paddle's sandbox API. Set the adapter base URL to `https://api.paddle.com` when using a live API key. Keep the `Paddle-Version` header pinned to the API version your integration targets.

For configuration-based credentials, environment selection, and managed client reuse, use [`Soenneker.Paddle.OpenApiClientUtil`](https://github.com/soenneker/soenneker.paddle.openapiclientutil).
