namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/liabilities/get</c> results. If provided, <c>options</c> cannot be null.</para>
/// </summary>
public class LiabilitiesGetRequestOptions
{
	/// <summary>
	/// <para>A list of accounts to retrieve for the Item.</para>
	/// <para>An error will be returned if a provided <c>account_id</c> is not associated with the Item</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string> AccountIds { get; set; } = default!;
}