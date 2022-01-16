namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional options that will be used to filter institutions by various Payment Initiation configurations.</para>
/// </summary>
public class InstitutionsSearchPaymentInitiationOptions
{
	/// <summary>
	/// <para>A unique ID identifying the payment</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string? PaymentId { get; set; } = default!;
}