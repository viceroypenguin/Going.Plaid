namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the e-wallet</para>
/// </summary>
public record Wallet
{
	/// <summary>
	/// <para>A unique ID identifying the e-wallet</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string WalletId { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the e-wallet balance</para>
	/// </summary>
	[JsonPropertyName("balance")]
	public Entity.WalletBalance Balance { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the e-wallet account numbers</para>
	/// </summary>
	[JsonPropertyName("numbers")]
	public Entity.WalletNumbers Numbers { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the recipient that corresponds to the e-wallet account numbers</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the wallet.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WalletStatus Status { get; init; } = default!;
}