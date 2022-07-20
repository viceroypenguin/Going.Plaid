namespace Going.Plaid.PaymentProfile;

/// <summary>
/// <para>PaymentProfileCreateResponse defines the response schema for <c>/payment_profile/create</c></para>
/// </summary>
public record PaymentProfileCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a payment profile.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_id")]
	public string PaymentProfileId { get; init; } = default!;
}