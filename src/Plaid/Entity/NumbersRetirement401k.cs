namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for transferring holdings from a 401k account to another 401k account or IRA via the manual 401k rollover process.</para>
/// </summary>
public record NumbersRetirement401k
{
	/// <summary>
	/// <para>The Plaid account ID associated with the account numbers</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The plan number for the employer's 401k retirement plan</para>
	/// </summary>
	[JsonPropertyName("plan")]
	public string? Plan { get; init; } = default!;

	/// <summary>
	/// <para>The full account number for the account</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string? Account { get; init; } = default!;

}
