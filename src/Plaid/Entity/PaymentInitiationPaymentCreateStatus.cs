namespace Going.Plaid.Entity;

/// <summary>
/// <para>For a payment returned by this endpoint, there is only one possible value:</para>
/// </summary>
public enum PaymentInitiationPaymentCreateStatus
{
	/// <summary>
	/// <para>The initial phase of the payment</para>
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_INPUT_NEEDED")]
	PaymentStatusInputNeeded,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}