namespace Going.Plaid.Entity;

/// <summary>
/// <para>Status of the overall business verification</para>
/// </summary>
public enum BusinessVerificationStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "active")]
	Active,

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
