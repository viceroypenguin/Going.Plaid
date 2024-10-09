namespace Going.Plaid.Entity;

/// <summary>
/// <para>Decides the mode under which the payment processing should be performed, using <c>IMMEDIATE</c> as default.</para>
/// </summary>
public enum PaymentInitiationConsentProcessingMode
{
	/// <summary>
	/// <para>Will accept a payment execution request and schedule it for processing, immediately returning the new <c>payment_id</c>. Listen for webhooks or use the <a href="https://plaid.com/docs/api/products/payment-initiation/#payment_initiationpaymentget"><c>/payment_initiation/payment/get</c></a> endpoint to obtain updates on the payment status. This is ideal for non user-present flows.</para>
	/// </summary>
	[EnumMember(Value = "ASYNC")]
	Async,

	/// <summary>
	/// <para>Will immediately execute the payment, waiting for a response from the ASPSP before returning the result of the payment initiation. This is ideal for user-present flows.</para>
	/// </summary>
	[EnumMember(Value = "IMMEDIATE")]
	Immediate,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
