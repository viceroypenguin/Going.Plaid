namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>Defines the request schema for <c>/bank_transfer/event/list</c></para>
/// </summary>
public class BankTransferEventListRequest : RequestBase
{
	/// <summary>
	/// <para>The start datetime of bank transfers to list. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateTimeOffset? StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The end datetime of bank transfers to list. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateTimeOffset? EndDate { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a bank transfer.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_id")]
	public string? BankTransferId { get; set; } = default!;

	/// <summary>
	/// <para>The account ID to get events for all transactions to/from an account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; set; } = default!;

	/// <summary>
	/// <para>The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into your origination account; a <c>credit</c> indicates a transfer of money out of your origination account.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_type")]
	public Entity.BankTransferType? BankTransferType { get; set; } = default!;

	/// <summary>
	/// <para>Filter events by event type.</para>
	/// </summary>
	[JsonPropertyName("event_types")]
	public IReadOnlyList<Entity.BankTransferEventType> EventTypes { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of bank transfer events to return. If the number of events matching the above parameters is greater than <c>count</c>, the most recent events will be returned.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The offset into the list of bank transfer events. When <c>count</c>=25 and <c>offset</c>=0, the first 25 events will be returned. When <c>count</c>=25 and <c>offset</c>=25, the next 25 bank transfer events will be returned.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; } = default!;

	/// <summary>
	/// <para>The origination account ID to get events for transfers from a specific origination account.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;

	/// <summary>
	/// <para>Indicates the direction of the transfer: <c>outbound</c>: for API-initiated transfers</para>
	/// </summary>
	[JsonPropertyName("direction")]
	public Entity.BankTransferDirection? Direction { get; set; } = default!;
}