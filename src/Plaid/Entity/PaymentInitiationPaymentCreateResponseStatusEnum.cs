namespace Going.Plaid.Entity;

/// <summary>
/// <para>For a payment returned by this endpoint, there is only one possible value:</para>
/// </summary>
public enum PaymentInitiationPaymentCreateResponseStatusEnum
{
	/// <summary>
	/// <para>The initial phase of the payment</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INPUT_NEEDED")]
	PaymentStatusInputNeeded,
}