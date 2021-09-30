namespace Going.Plaid.Entity;

/// <summary>
/// <para>The account where the funds are swept to.</para>
/// </summary>
public record BankTransferSweepAccount
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("account_number")]
	public string AccountNumber { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string RoutingNumber { get; init; } = default!;
}