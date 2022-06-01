namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Request input for retrying a identity verification attempt</para>
/// </summary>
public partial class IdentityVerificationRetryRequest : RequestBase
{
	/// <summary>
	/// <para>An identifier to help you connect this object to your internal systems. For example, your database ID corresponding to this object.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>ID of the associated Identity Verification template.</para>
	/// </summary>
	[JsonPropertyName("template_id")]
	public string TemplateId { get; set; } = default!;

	/// <summary>
	/// <para>An instruction specifying what steps the new Identity Verification attempt should require the user to complete:</para>
	/// </summary>
	[JsonPropertyName("strategy")]
	public Entity.Strategy Strategy { get; set; } = default!;

	/// <summary>
	/// <para>Instructions for the <c>custom</c> retry strategy specifying which steps should be required or skipped.</para>
	/// <para>Note:</para>
	/// <para>This field must be provided when the retry strategy is <c>custom</c> and must be omitted otherwise.</para>
	/// <para>Custom retries override settings in your Plaid Template. For example, if your Plaid Template has <c>verify_sms</c> disabled, a custom retry with <c>verify_sms</c> enabled will still require the step.</para>
	/// <para>The <c>selfie_check</c> step is currently not supported on the sandbox server. Sandbox requests will silently disable the <c>selfie_check</c> step when provided.</para>
	/// </summary>
	[JsonPropertyName("steps")]
	public Entity.IdentityVerificationRetryRequestStepsObject? Steps { get; set; } = default!;
}