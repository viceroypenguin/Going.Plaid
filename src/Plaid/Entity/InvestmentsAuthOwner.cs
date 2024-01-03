namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information on the ownership of an investments account</para>
/// </summary>
public record InvestmentsAuthOwner
{
	/// <summary>
	/// <para>The ID of the account that this identity information pertains to</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>A list of names associated with the account by the financial institution. In the case of a joint account, Plaid will make a best effort to report the names of all account holders.</para>
	/// <para>If an Item contains multiple accounts with different owner names, some institutions will report all names associated with the Item in each account's <c>names</c> array.</para>
	/// </summary>
	[JsonPropertyName("names")]
	public IReadOnlyList<string>? Names { get; init; } = default!;

}
