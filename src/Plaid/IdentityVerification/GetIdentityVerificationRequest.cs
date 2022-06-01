namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Request input for fetching an identity verification</para>
/// </summary>
public partial class GetIdentityVerificationRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Identity Verification attempt.</para>
	/// </summary>
	[JsonPropertyName("identity_verification_id")]
	public string IdentityVerificationId { get; set; } = default!;
}