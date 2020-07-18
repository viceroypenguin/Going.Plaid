# Plaid.NET

---

## What is Plaid.NET?
Plaid.NET is a .netstandard library for interacting with [Plaid's](https://plaid.com/) banking APIs. See their documentation [here](https://plaid.com/docs/api/).

### Where can I get it?
Plaid.NET is available at [nuget.org](https://www.nuget.org/packages/Going.Plaid.NET).

Package Manager `PM > Install-Package Going.Plaid.NET`

### How it works?
You can make all calls to Plaid's API via the `Going.Plaid.PlaidClient` class.

```c#
var client = new PlaidClient();
// Retrieving a user's recent transactions.
var result = await client.FetchTransactionsAsync(new GetTransactionsRequest()
{
    Secret = "your_secret",
    ClientId = "your_client_id",
    AccessToken = "your_token",
    ...
});
```

## API Version
Plaid.NET currently targets Plaid API version `2019-05-29`.
