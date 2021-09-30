namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>BankTransferSweepListRequest defines the request schema for <c>/bank_transfer/sweep/list</c></para>
/// </summary>
public class BankTransferSweepListRequest : RequestBase
{
	/// <summary>
	/// <para>If multiple origination accounts are available, <c>origination_account_id</c> must be used to specify the account that the sweeps belong to.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;

	/// <summary>
	/// <para>Starting ID of sweeps to return.</para>
	/// </summary>
	[JsonPropertyName("start_id")]
	public int? StartId { get; set; } = default!;

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
}