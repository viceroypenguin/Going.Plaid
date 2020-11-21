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

#### .NET Core Configuration Options

You can also provide options via your configuration file by configuring a `PlaidOptions` object
by calling `services.Configure<PlaidOptions>(_config.GetSection(PlaidOptions.SectionKey));` in your
`ConfigureServices(IServiceCollection services)` method. This expects the options to be created
under the `"Plaid"` section key. However, you may choose to configure from any section that provides
the values used by the `PlaidOptions` object.

Once done, you can then add `PlaidClient` as a singleton by calling `services.AddSingleton<PlaidClient>()`.

### IHttpClientFactory

Going.Plaid supports the `IHttpClientFactory` for correct usage of `HttpClient`, as described [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests).
You may provide an instance of `IHttpClientFactory` from the DI system, provide your own, or let Going.Plaid create it's own instance of the factory.

## API Version
Going.Plaid currently targets Plaid API version `2020-09-14` only.
