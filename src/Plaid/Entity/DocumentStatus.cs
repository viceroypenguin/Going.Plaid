namespace Going.Plaid.Entity;

/// <summary>
/// <para>An outcome status for this specific document submission. Distinct from the overall <c>documentary_verification.status</c> that summarizes the verification outcome from one or more documents.</para>
/// </summary>
public enum DocumentStatus
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
	/// 
	/// </summary>
	[EnumMember(Value = "manually_approved")]
	ManuallyApproved,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}