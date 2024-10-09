namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/ledger/get</c></para>
/// </summary>
public record TransferLedgerGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The unique identifier of the Ledger that was returned.</para>
	/// </summary>
	[JsonPropertyName("ledger_id")]
	public string LedgerId { get; init; } = default!;

	/// <summary>
	/// <para>Information about the balance of the ledger held with Plaid.</para>
	/// </summary>
	[JsonPropertyName("balance")]
	public Entity.TransferLedgerBalance Balance { get; init; } = default!;

	/// <summary>
	/// <para>The name of the Ledger</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>Whether this Ledger is the client's default ledger.</para>
	/// </summary>
	[JsonPropertyName("is_default")]
	public bool IsDefault { get; init; } = default!;

}
