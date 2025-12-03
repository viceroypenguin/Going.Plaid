namespace Going.Plaid.BusinessVerification;

/// <summary>
/// <para>Request input for fetching a business verification</para>
/// </summary>
public partial class BusinessVerificationGetRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated business verification.</para>
	/// </summary>
	[JsonPropertyName("business_verification_id")]
	public string BusinessVerificationId { get; set; } = default!;

}
