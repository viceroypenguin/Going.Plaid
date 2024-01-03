namespace Going.Plaid.PaymentProfile;

/// <summary>
/// <para>PaymentProfileRemoveRequest defines the request schema for <c>/payment_profile/remove</c></para>
/// </summary>
public partial class PaymentProfileRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>A payment profile token associated with the Payment Profile data that is being requested.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_token")]
	public string PaymentProfileToken { get; set; } = default!;

}
