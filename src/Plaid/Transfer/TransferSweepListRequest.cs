namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/sweep/list</c></para>
/// </summary>
public partial class TransferSweepListRequest : RequestBase
{
	/// <summary>
	/// <para>The start <c>created</c> datetime of sweeps to return (RFC 3339 format).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateTimeOffset? StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The end <c>created</c> datetime of sweeps to return (RFC 3339 format).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateTimeOffset? EndDate { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of sweeps to return.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of sweeps to skip before returning results.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; } = default!;

	/// <summary>
	/// <para>Filter sweeps to only those with the specified amount.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string? Amount { get; set; } = default!;

	/// <summary>
	/// <para>The status of a sweep transfer</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.SweepStatus? Status { get; set; } = default!;

	/// <summary>
	/// <para>Filter sweeps to only those with the specified originator client.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>Filter sweeps to only those with the specified <c>funding_account_id</c>.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string? FundingAccountId { get; set; } = default!;

	/// <summary>
	/// <para>Filter sweeps to only those with the included <c>transfer_id</c>.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string? TransferId { get; set; } = default!;

	/// <summary>
	/// <para>The trigger of the sweep</para>
	/// </summary>
	[JsonPropertyName("trigger")]
	public Entity.SweepTrigger? Trigger { get; set; } = default!;

}
