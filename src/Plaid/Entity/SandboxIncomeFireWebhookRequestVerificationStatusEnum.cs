namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum SandboxIncomeFireWebhookRequestVerificationStatusEnum
{
	/// <summary>
	/// <para>The income verification status processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/paystubs/get</c> endpoint and check the document metadata to see which documents were successfully parsed.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_PROCESSING_COMPLETE")]
	VerificationStatusProcessingComplete,

	/// <summary>
	/// <para>A failure occurred when attempting to process the verification documentation.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_PROCESSING_FAILED")]
	VerificationStatusProcessingFailed,

	/// <summary>
	/// <para>The income verification has been sent to the user for review.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_PENDING_APPROVAL")]
	VerificationStatusPendingApproval,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}