namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/ledger/distribute</c></para>
/// </summary>
public partial class TransferLedgerDistributeRequest : RequestBase
{
	/// <summary>
	/// <para>The Ledger to pull money from.</para>
	/// </summary>
	[JsonPropertyName("from_ledger_id")]
	public string FromLedgerId { get; set; } = default!;

	/// <summary>
	/// <para>The Ledger to credit money to.</para>
	/// </summary>
	[JsonPropertyName("to_ledger_id")]
	public string ToLedgerId { get; set; } = default!;

	/// <summary>
	/// <para>The amount to move (decimal string with two digits of precision e.g. "10.00"). Amount must be positive.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>A unique key provided by the client, per unique ledger distribute. Maximum of 50 characters.</para>
	/// <para>The API supports idempotency for safely retrying the request without accidentally performing the same operation twice. For example, if a request to create a ledger distribute fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single distribute is created.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string IdempotencyKey { get; set; } = default!;

	/// <summary>
	/// <para>An optional description for the ledger distribute operation.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; set; } = default!;

}
