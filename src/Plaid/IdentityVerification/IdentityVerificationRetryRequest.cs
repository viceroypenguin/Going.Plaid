namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Request input for retrying an identity verification attempt</para>
/// </summary>
public partial class IdentityVerificationRetryRequest : RequestBase
{
	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the Link Token Create <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
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
	/// <para>User information collected outside of Link, most likely via your own onboarding process.</para>
	/// <para>Each of the following identity fields are optional:</para>
	/// <para><c>email_address</c></para>
	/// <para><c>phone_number</c></para>
	/// <para><c>date_of_birth</c></para>
	/// <para><c>name</c></para>
	/// <para><c>address</c></para>
	/// <para><c>id_number</c></para>
	/// <para>Specifically, these fields are optional in that they can either be fully provided (satisfying every required field in their subschema) or omitted from the request entirely by not providing the key or value.</para>
	/// <para>Providing these fields via the API will result in Link skipping the data collection process for the associated user. All verification steps enabled in the associated Identity Verification Template will still be run. Verification steps will either be run immediately, or once the user completes the <c>accept_tos</c> step, depending on the value provided to the <c>gave_consent</c> field.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.IdentityVerificationRequestUser? User { get; set; } = default!;

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