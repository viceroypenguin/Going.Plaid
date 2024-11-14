namespace Going.Plaid.Entity;

/// <summary>
/// <para>The outcome status for the associated Identity Verification attempt's <c>verify_sms</c> step. This field will always have the same value as <c>steps.verify_sms</c>.</para>
/// </summary>
public enum VerifySMSDetailsStatus
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
