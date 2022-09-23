namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/event/list</c></para>
/// </summary>
public partial class TransferEventListRequest : RequestBase
{
	/// <summary>
	/// <para>The start datetime of transfers to list. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateTimeOffset? StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The end datetime of transfers to list. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateTimeOffset? EndDate { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string? TransferId { get; set; } = default!;

	/// <summary>
	/// <para>The account ID to get events for all transactions to/from an account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; set; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into your origination account; a <c>credit</c> indicates a transfer of money out of your origination account.</para>
	/// </summary>
	[JsonPropertyName("transfer_type")]
	public Entity.TransferType? TransferType { get; set; } = default!;

	/// <summary>
	/// <para>Filter events by event type.</para>
	/// </summary>
	[JsonPropertyName("event_types")]
	public IReadOnlyList<Entity.TransferEventType> EventTypes { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a sweep.</para>
	/// </summary>
	[JsonPropertyName("sweep_id")]
	public string SweepId { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of transfer events to return. If the number of events matching the above parameters is greater than <c>count</c>, the most recent events will be returned.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The offset into the list of transfer events. When <c>count</c>=25 and <c>offset</c>=0, the first 25 events will be returned. When <c>count</c>=25 and <c>offset</c>=25, the next 25 events will be returned.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; } = default!;

	/// <summary>
	/// <para>The origination account ID to get events for transfers from a specific origination account.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;
}