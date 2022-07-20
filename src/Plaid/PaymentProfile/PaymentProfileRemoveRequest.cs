namespace Going.Plaid.PaymentProfile;

/// <summary>
/// <para>PaymentProfileRemoveRequest defines the request schema for <c>/payment_profile/remove</c></para>
/// </summary>
public partial class PaymentProfileRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a payment profile.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_id")]
	public string PaymentProfileId { get; set; } = default!;
}