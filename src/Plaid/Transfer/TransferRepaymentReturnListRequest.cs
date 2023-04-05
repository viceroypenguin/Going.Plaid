namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/repayment/return/list</c></para>
/// </summary>
public partial class TransferRepaymentReturnListRequest : RequestBase
{
	/// <summary>
	/// <para>Identifier of the repayment to query.</para>
	/// </summary>
	[JsonPropertyName("repayment_id")]
	public string RepaymentId { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of repayments to return.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of repayments to skip before returning results.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; } = default!;
}