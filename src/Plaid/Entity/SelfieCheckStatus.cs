namespace Going.Plaid.Entity;

/// <summary>
/// <para>The outcome status for the associated Identity Verification attempt's <c>selfie_check</c> step. This field will be <c>success</c> if <c>steps.selfie_check</c> is <c>success</c> or <c>manually_approved</c>, and <c>failed</c> if <c>steps.selfie_check</c> is <c>failed</c> or <c>manually_rejected</c>.</para>
/// </summary>
public enum SelfieCheckStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "success")]
	Success,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
