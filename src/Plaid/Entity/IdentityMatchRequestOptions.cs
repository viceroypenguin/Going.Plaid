namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter /identity/match results</para>
/// </summary>
public class IdentityMatchRequestOptions
{
	/// <summary>
	/// <para>An array of <c>account_ids</c> to perform fuzzy match</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;
}