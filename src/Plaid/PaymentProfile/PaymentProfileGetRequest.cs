namespace Going.Plaid.PaymentProfile;

/// <summary>
/// <para>PaymentProfileGetRequest defines the request schema for <c>/payment_profile/get</c></para>
/// </summary>
public partial class PaymentProfileGetRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a payment profile.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_id")]
	public string PaymentProfileId { get; set; } = default!;
}