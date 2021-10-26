namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the refund.</para>
/// </summary>
public enum PaymentInitiationPaymentReverseResponseStatusEnum
{
	/// <summary>
	/// <para>The refund is currently being processed. The refund will automatically exit this state when processing is complete.</para>
	/// </summary>
	[EnumMember(Value = "PROCESSING")]
	Processing,

	/// <summary>
	/// <para>Indicates that the refund has been successfully executed.</para>
	/// </summary>
	[EnumMember(Value = "EXECUTED")]
	Executed,

	/// <summary>
	/// <para>The refund has been successfully initiated.</para>
	/// </summary>
	[EnumMember(Value = "INITIATED")]
	Initiated,

	/// <summary>
	/// <para>The refund has failed to be executed. This error is retryable once the root cause is resolved.</para>
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}