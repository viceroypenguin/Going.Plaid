namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/accounts/get</c> results.</para>
/// </summary>
public class AccountsGetRequestOptions
{
	/// <summary>
	/// <para>An array of <c>account_ids</c> to retrieve for the Account.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;
}