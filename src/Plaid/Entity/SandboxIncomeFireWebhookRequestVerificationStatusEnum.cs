namespace Going.Plaid.Entity;

/// <summary>
/// <para>Required when <c>webhook_code</c> is <c>INCOME_VERIFICATION</c> or <c>USER_INCOME_VERIFICATION</c>.</para>
/// </summary>
public enum SandboxIncomeFireWebhookRequestVerificationStatusEnum
{
	/// <summary>
	/// <para>The income verification status processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/income/verification/paystubs/get</c> endpoint and check the document metadata to see which documents were successfully parsed.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_PROCESSING_COMPLETE")]
	VerificationStatusProcessingComplete,

	/// <summary>
	/// <para>A failure occurred when attempting to process the verification documentation.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_PROCESSING_FAILED")]
	VerificationStatusProcessingFailed,

	/// <summary>
	/// <para>The documentation was rejected.</para>
	/// </summary>
	[EnumMember(Value = "VERIFICATION_STATUS_DOCUMENT_REJECTED")]
	VerificationStatusDocumentRejected,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
