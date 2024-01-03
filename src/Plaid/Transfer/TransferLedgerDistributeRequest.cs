namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/ledger/distribute</c></para>
/// </summary>
public partial class TransferLedgerDistributeRequest : RequestBase
{
	/// <summary>
	/// <para>The client to pull money from. Must be the platform itself or its originator. One of <c>from_client_id</c> and <c>to_client_id</c> must be the platform's <c>client_id</c>.</para>
	/// </summary>
	[JsonPropertyName("from_client_id")]
	public string FromClientId { get; set; } = default!;

	/// <summary>
	/// <para>The client to credit money to. Must be the platform itself or its originator. One of <c>from_client_id</c> and <c>to_client_id</c> must be the platform's <c>client_id</c>.</para>
	/// </summary>
	[JsonPropertyName("to_client_id")]
	public string ToClientId { get; set; } = default!;

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
