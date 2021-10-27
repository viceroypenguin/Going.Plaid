namespace Going.Plaid.Entity;

/// <summary>
/// <para>IncomeVerificationCreateRequestOptions defines the optional arguments schema for <c>/income/verification/create</c></para>
/// </summary>
public class IncomeVerificationCreateRequestOptions
{
	/// <summary>
	/// <para>An array of access tokens corresponding to the Items that will be cross-referenced with the product data. If the <c>transactions</c> product was not initialized for the Items during link, it will be initialized after this Link session.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string> AccessTokens { get; set; } = default!;
}