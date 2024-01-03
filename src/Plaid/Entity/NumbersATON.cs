namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identifying information for transferring holdings to an investments account via ATON.</para>
/// </summary>
public record NumbersATON
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

}
