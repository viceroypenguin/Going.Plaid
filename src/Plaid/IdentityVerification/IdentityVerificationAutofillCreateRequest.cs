namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Request input to autofill an Identity Verification</para>
/// </summary>
public partial class IdentityVerificationAutofillCreateRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Identity Verification attempt.</para>
	/// </summary>
	[JsonPropertyName("identity_verification_id")]
	public string IdentityVerificationId { get; set; } = default!;

}
