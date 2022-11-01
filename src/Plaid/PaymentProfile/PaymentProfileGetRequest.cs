namespace Going.Plaid.PaymentProfile;

/// <summary>
/// <para>PaymentProfileGetRequest defines the request schema for <c>/payment_profile/get</c></para>
/// </summary>
public partial class PaymentProfileGetRequest : RequestBase
{
	/// <summary>
	/// <para>A payment profile token associated with the Payment Profile data that is being requested.</para>
	/// </summary>
	[JsonPropertyName("payment_profile_token")]
	public string PaymentProfileToken { get; set; } = default!;
}