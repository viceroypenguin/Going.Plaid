namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletListResponse defines the response schema for <c>/wallet/list</c></para>
/// </summary>
public record WalletListResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of e-wallets</para>
	/// </summary>
	[JsonPropertyName("wallets")]
	public IReadOnlyList<Entity.Wallet> Wallets { get; init; } = default!;

	/// <summary>
	/// <para>Cursor used for fetching e-wallets created before the latest e-wallet provided in this response</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;
}