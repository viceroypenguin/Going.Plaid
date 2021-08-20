namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum SandboxIncomeFireWebhookRequestVerificationStatusEnum
{
	/// <summary>
	/// <para>The income verification status processing has completed.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_PROCESSING_COMPLETE")]
	VerificationStatusProcessingComplete,

	/// <summary>
	/// <para>The documentation uploaded by the end user was recognized as a supported file format, but not recognized as a valid paystub.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_DOCUMENT_REJECTED")]
	VerificationStatusDocumentRejected,

	/// <summary>
	/// <para>A failure occurred when attempting to process the verification documentation.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_PROCESSING_FAILED")]
	VerificationStatusProcessingFailed,
}