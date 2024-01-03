namespace Going.Plaid.Entity;

/// <summary>
/// <para>An outcome status for this specific selfie. Distinct from the overall <c>selfie_check.status</c> that summarizes the verification outcome from one or more selfies.</para>
/// </summary>
public enum SelfieStatus
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
