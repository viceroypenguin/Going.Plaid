namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/investments/holdings/get</c> results. If provided, must not be <c>null</c>.</para>
/// </summary>
public class InvestmentHoldingsGetRequestOptions
{
	/// <summary>
	/// <para>An array of <c>account_id</c>s to retrieve for the Item. An error will be returned if a provided <c>account_id</c> is not associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;

}
