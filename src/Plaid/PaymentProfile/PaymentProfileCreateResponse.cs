namespace Going.Plaid.PaymentProfile;

/// <summary>
/// <para>PaymentProfileCreateResponse defines the response schema for <c>/payment_profile/create</c></para>
/// </summary>
public record PaymentProfileCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A payment profile token associated with the Payment Profile data that is being requested.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_token")]
	public string PaymentProfileToken { get; init; } = default!;
}