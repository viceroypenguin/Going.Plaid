namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditBankIncomeRefreshRequest defines the request schema for <c>/credit/bank_income/refresh</c>.</para>
/// </summary>
public partial class CreditBankIncomeRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>An optional object for <c>/credit/bank_income/refresh</c> request options.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.CreditBankIncomeRefreshRequestOptions? Options { get; set; } = default!;
}