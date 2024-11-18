namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies option for initializing Link for use with the Identity Verification product.</para>
/// </summary>
public class LinkTokenCreateRequestIdentityVerification
{
	/// <summary>
	/// <para>ID of the associated Identity Verification template.</para>
	/// </summary>
	[JsonPropertyName("template_id")]
	public string TemplateId { get; set; } = default!;

	/// <summary>
	/// <para>A flag specifying whether the end user has already agreed to a privacy policy specifying that their data will be shared with Plaid for verification purposes.</para>
	/// <para>If <c>gave_consent</c> is set to <c>true</c>, the <c>accept_tos</c> step will be marked as <c>skipped</c> and the end user's session will start at the next step requirement.</para>
	/// </summary>
	[JsonPropertyName("consent")]
	public Entity.LinkTokenCreateRequestIdentityVerificationConsentObject? Consent { get; set; } = default!;

	/// <summary>
	/// <para>A flag specifying whether the end user has already agreed to a privacy policy specifying that their data will be shared with Plaid for verification purposes.</para>
	/// <para>If <c>gave_consent</c> is set to <c>true</c>, the <c>accept_tos</c> step will be marked as <c>skipped</c> and the end user's session will start at the next step requirement.</para>
	/// </summary>
	[JsonPropertyName("gave_consent")]
	public bool? GaveConsent { get; set; } = default!;

}
