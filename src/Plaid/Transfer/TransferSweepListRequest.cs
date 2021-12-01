namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/sweep/list</c></para>
/// </summary>
public partial class TransferSweepListRequest : RequestBase
{
	/// <summary>
	/// <para>The start datetime of sweeps to return (RFC 3339 format).</para>
	/// </summary>
	[JsonPropertyName("start_time")]
	public DateTimeOffset? StartTime { get; set; } = default!;

	/// <summary>
	/// <para>The end datetime of sweeps to return (RFC 3339 format).</para>
	/// </summary>
	[JsonPropertyName("end_time")]
	public DateTimeOffset? EndTime { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of sweeps to return.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; set; } = default!;

	/// <summary>
	/// <para>The number of sweeps to skip before returning results.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int Offset { get; set; } = default!;
}