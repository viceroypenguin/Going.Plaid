namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/ledger/event/list</c></para>
/// </summary>
public partial class TransferLedgerEventListRequest : RequestBase
{
	/// <summary>
	/// <para>Filter transfer events to only those with the specified originator client. (This field is specifically for resellers. Caller's client ID will be used if this field is not specified.)</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>The start created datetime of transfers to list. This should be in RFC 3339 format (i.e. 2019-12-06T22:35:49Z)</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateTimeOffset? StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The end created datetime of transfers to list. This should be in RFC 3339 format (i.e. 2019-12-06T22:35:49Z)</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateTimeOffset? EndDate { get; set; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for a Plaid Ledger Balance.</para>
	/// </summary>
	[JsonPropertyName("ledger_id")]
	public string? LedgerId { get; set; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for the ledger event.</para>
	/// </summary>
	[JsonPropertyName("ledger_event_id")]
	public string? LedgerEventId { get; set; } = default!;

	/// <summary>
	/// <para>Source of the ledger event.</para>
	/// </summary>
	[JsonPropertyName("source_type")]
	public Entity.LedgerEventSourceType? SourceType { get; set; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for a transfer, sweep, or refund.</para>
	/// </summary>
	[JsonPropertyName("source_id")]
	public string? SourceId { get; set; } = default!;

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

}
