namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for transferring holdings to an investments account via ACATS.</para>
/// </summary>
public record NumbersACATS
{
	/// <summary>
	/// <para>The Plaid account ID associated with the account numbers</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The full account number for the account</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string Account { get; init; } = default!;

	/// <summary>
	/// <para>Identifiers for the clearinghouses that are associated with the account in order of relevance. This array will be empty if we can't provide any account level data. Institution level data can be retrieved from the institutions/get endpoints.</para>
	/// </summary>
	[JsonPropertyName("dtc_numbers")]
	public IReadOnlyList<string> DtcNumbers { get; init; } = default!;

}
