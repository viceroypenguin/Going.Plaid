namespace Going.Plaid.Accounts;

/// <summary>
/// <para>AccountsGetRequest defines the request schema for <c>/accounts/get</c></para>
/// </summary>
public class AccountsGetRequest : RequestBase
{
	/// <summary>
	/// <para>An optional object to filter <c>/accounts/get</c> results.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.AccountsGetRequestOptions Options { get; set; } = default!;
}