namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentCreateRequest defines the request schema for <c>/payment_initiation/payment/create</c></para>
/// </summary>
public partial class PaymentInitiationPaymentCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the recipient the payment is for.</para>
	/// </summary>
	[JsonPropertyName("recipient_id")]
	public string RecipientId { get; set; } = default!;

	/// <summary>
	/// <para>A reference for the payment. This must be an alphanumeric string with at most 18 characters and must not contain any special characters (since not all institutions support them).</para>
	/// <para>In order to track settlement via Payment Confirmation, each payment must have a unique reference. If the reference provided through the API is not unique, Plaid will adjust it.</para>
	/// <para>Both the originally provided and automatically adjusted references (if any) can be found in the <c>reference</c> and <c>adjusted_reference</c> fields, respectively.</para>
	/// </summary>
	[JsonPropertyName("reference")]
	public string Reference { get; set; } = default!;

	/// <summary>
	/// <para>The amount and currency of a payment</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.PaymentAmount Amount { get; set; } = default!;

	/// <summary>
	/// <para>The schedule that the payment will be executed on. If a schedule is provided, the payment is automatically set up as a standing order. If no schedule is specified, the payment will be executed only once.</para>
	/// </summary>
	[JsonPropertyName("schedule")]
	public Entity.ExternalPaymentScheduleRequest Schedule { get; set; } = default!;

	/// <summary>
	/// <para>Additional payment options</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.PaymentOptions? Options { get; set; } = default!;
}