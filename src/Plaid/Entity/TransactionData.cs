namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the matched direct deposit transaction used to verify a user's payroll information.</para>
/// </summary>
public record TransactionData
{
	/// <summary>
	/// <para>The description of the transaction.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the transaction.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>The date of the transaction, in ISO 8601 format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; init; } = default!;

	/// <summary>
	/// <para>A unique identifier for the end user's account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>A unique identifier for the transaction.</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;
}