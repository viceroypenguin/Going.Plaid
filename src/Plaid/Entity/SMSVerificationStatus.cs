namespace Going.Plaid.Entity;

/// <summary>
/// <para>The outcome status for the individual SMS verification.</para>
/// </summary>
public enum SMSVerificationStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending")]
	Pending,

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
	[EnumMember(Value = "canceled")]
	Canceled,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
