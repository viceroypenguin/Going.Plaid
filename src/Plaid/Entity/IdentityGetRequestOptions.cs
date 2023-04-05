namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/identity/get</c> results.</para>
/// </summary>
public class IdentityGetRequestOptions
{
	/// <summary>
	/// <para>A list of <c>account_ids</c> to retrieve for the Item.</para>
	/// <para>Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;
}