namespace Going.Plaid.Entity;

/// <summary>
/// <para>IncomeVerificationCreateRequestOptions defines the optional arguments schema for <c>/income/verification/create</c></para>
/// </summary>
public class IncomeVerificationCreateRequestOptions
{
	/// <summary>
	/// <para>An array of access tokens corresponding to the Items that will be cross-referenced with the product data. Plaid will attempt to correlate transaction history from these Items with data from the user's paystub, such as date and amount. The <c>verification</c> status of the paystub as returned by <c>/income/verification/paystubs/get</c> will indicate if the verification status was successful, or, if not, why it failed. If the <c>transactions</c> product was not initialized for the Items during Link, it will be initialized after this Link session.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string> AccessTokens { get; set; } = default!;
}