namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object with information about the status of the Item.</para>
/// </summary>
public record ItemStatus
{
	/// <summary>
	/// <para>Information about the last successful and failed investments update for the Item.</para>
	/// </summary>
	[JsonPropertyName("investments")]
	public Entity.ItemStatusInvestments? Investments { get; init; } = default!;

	/// <summary>
	/// <para>Information about the last successful and failed transactions update for the Item.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public Entity.ItemStatusTransactions? Transactions { get; init; } = default!;

	/// <summary>
	/// <para>Information about the last webhook fired for the Item.</para>
	/// </summary>
	[JsonPropertyName("last_webhook")]
	public Entity.ItemStatusLastWebhook? LastWebhook { get; init; } = default!;
}