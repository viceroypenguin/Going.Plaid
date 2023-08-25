namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the balance of the ledger held with Plaid.</para>
/// </summary>
public record TransferLedgerBalance
{
	/// <summary>
	/// <para>The amount of this balance available for use (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("available")]
	public string Available { get; init; } = default!;

	/// <summary>
	/// <para>The amount of pending funds that are in processing (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("pending")]
	public string Pending { get; init; } = default!;
}