namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/event/sync</c></para>
/// </summary>
public class TransferEventSyncRequest : RequestBase
{
	/// <summary>
	/// <para>The latest (largest) <c>event_id</c> fetched via the sync endpoint, or 0 initially.</para>
	/// </summary>
	[JsonPropertyName("after_id")]
	public int AfterId { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of transfer events to return.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;
}