namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/ledger/get</c></para>
/// </summary>
public record TransferLedgerGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Information about the balance of the ledger held with Plaid.</para>
	/// </summary>
	[JsonPropertyName("balance")]
	public Entity.TransferLedgerBalance Balance { get; init; } = default!;

}
