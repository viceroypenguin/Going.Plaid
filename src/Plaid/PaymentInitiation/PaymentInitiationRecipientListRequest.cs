namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationRecipientListRequest defines the request schema for <c>/payment_initiation/recipient/list</c></para>
/// </summary>
public partial class PaymentInitiationRecipientListRequest : RequestBase
{
	/// <summary>
	/// <para>The maximum number of recipients to return. If <c>count</c> is not specified, a maximum of 100 recipients will be returned, beginning with the recipient at the cursor (if specified).</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>A value representing the latest recipient to be included in the response. Set this from <c>next_cursor</c> received from the previous <c>/payment_initiation/recipient/list</c> request. If provided, the response will only contain that recipient and recipients created before it. If omitted, the response will contain recipients starting from the most recent, and in descending order by the <c>created_at</c> time.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

}
