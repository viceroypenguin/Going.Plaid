namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/investments/auth/get</c> results.</para>
/// </summary>
public class InvestmentsAuthGetRequestOptions
{
	/// <summary>
	/// <para>An array of <c>account_id</c>s to retrieve for the Item. An error will be returned if a provided <c>account_id</c> is not associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;

}
