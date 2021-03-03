# Going.Plaid
[![Build status](https://ci.appveyor.com/api/projects/status/ff2ciq6rfn7225oi?svg=true)](https://ci.appveyor.com/project/viceroypenguin/going-plaid-net)
[![NuGet](https://img.shields.io/nuget/v/Going.Plaid.svg?style=plastic)](https://www.nuget.org/packages/Going.Plaid/)
---

## What is Going.Plaid?
Going.Plaid is a .netstandard library for interacting with [Plaid's](https://plaid.com/) banking APIs. See their documentation [here](https://plaid.com/docs/api/).

### Where can I get it?
Going.Plaid is available at [nuget.org](https://www.nuget.org/packages/Going.Plaid).

Package Manager `PM > Install-Package Going.Plaid`

### How it works?
You can make all calls to Plaid's API via the `Going.Plaid.PlaidClient` class.

```c#
var client = new PlaidClient(
	Environment.Sandbox);

// Retrieving a user's recent transactions.
var result = await client.FetchTransactionsAsync(
	new GetTransactionsRequest()
	{
		Secret = "<secret>",
		ClientId = "<client_id>",
		AccessToken = "<access_token>",
	});
```

#### Usage
You may provide `secret` and `clientId` to the constructor as follows:
```c#
var client = new PlaidClient(
	Environment.Sandbox,
	secret: "<secret>",
	clientId: "<client_id>");

// Retrieving a user's recent transactions.
var result = await client.FetchTransactionsAsync(
	new GetTransactionsRequest()
	{
		AccessToken = "<access_token>",
	});
```

This will allow you to save a single `PlaidClient` in the DI system without tracking `secret` and `clientId` separately.
`PlaidClient` is comfortable being used as a single-instance class in this manner.

### .NET Core Configuration Options

#### Easy to use:
Call `services.AddPlaid(IConfigurationRoot)` or `services.AddPlaid(IConfiguration)`. This will automatically bind options
from the provided configuration section or the `Plaid` section of the root; configure a named `HttpClient` for Going.Plaid;
and configure `PlaidClient` as a singleton. 

#### IHttpClientFactory

Going.Plaid supports the `IHttpClientFactory` for correct usage of `HttpClient`, as described [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests).
If you choose not to call `.AddPlaid()`, because you need to customize your DI structure, it is recommended that you call
`services.AddPlaidClient()` to properly configure the `IHttpClientFactory` for Going.Plaid usage.

#### `IOptions` Support

Going.Plaid supports configuration from any configuration source via the `IOptions` pattern.
You can provide any configuration section to `.AddPlaid()` and the options will be automatically bound.
Alternatively, you may call `services.Configure<PlaidOptions>();` to configure the `PlaidOption` manually.
Once done, you can then add `PlaidClient` as a singleton by calling `services.AddSingleton<PlaidClient>()`.

## API Version
Going.Plaid currently targets Plaid API version `2020-09-14` only.
