namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of a removed transaction</para>
/// </summary>
public record RemovedTransaction
{
	/// <summary>
	/// <para>The ID of the removed transaction.</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string? TransactionId { get; init; } = default!;
}