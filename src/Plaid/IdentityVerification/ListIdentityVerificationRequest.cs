namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Request input for listing identity verifications</para>
/// </summary>
public partial class ListIdentityVerificationRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Identity Verification template.</para>
	/// </summary>
	[JsonPropertyName("template_id")]
	public string TemplateId { get; set; } = default!;

	/// <summary>
	/// <para>An identifier to help you connect this object to your internal systems. For example, your database ID corresponding to this object.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;
}