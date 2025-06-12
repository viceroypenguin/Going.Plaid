namespace Going.Plaid.Accounts;

/// <summary>
/// <para>AccountsBalanceGetRequest defines the request schema for <c>/accounts/balance/get</c></para>
/// </summary>
public partial class AccountsBalanceGetRequest : RequestBase
{
	/// <summary>
	/// <para>Optional parameters to <c>/accounts/balance/get</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.AccountsBalanceGetRequestOptions? Options { get; set; } = default!;

}
