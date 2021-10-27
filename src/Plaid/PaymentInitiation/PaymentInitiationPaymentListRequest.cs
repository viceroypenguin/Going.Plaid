namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentListRequest defines the request schema for <c>/payment_initiation/payment/list</c></para>
/// </summary>
public partial class PaymentInitiationPaymentListRequest : RequestBase
{
	/// <summary>
	/// <para>The maximum number of payments to return. If <c>count</c> is not specified, a maximum of 10 payments will be returned, beginning with the most recent payment before the cursor (if specified).</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>A string in RFC 3339 format (i.e. "2019-12-06T22:35:49Z"). Only payments created before the cursor will be returned.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public DateTimeOffset? Cursor { get; set; } = default!;
}