namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for transferring money to or from a UK bank account via BACS.</para>
/// </summary>
public record NumbersBacs
{
	/// <summary>
	/// <para>The Plaid account ID associated with the account numbers</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The BACS account number for the account</para>
	/// </summary>
	[JsonPropertyName("account")]
	public string Account { get; init; } = default!;

	/// <summary>
	/// <para>The BACS sort code for the account</para>
	/// </summary>
	[JsonPropertyName("sort_code")]
	public string SortCode { get; init; } = default!;

}
