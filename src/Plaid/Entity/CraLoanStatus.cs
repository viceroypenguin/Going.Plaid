namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the loan.</para>
/// </summary>
public enum CraLoanStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "APPROVED")]
	Approved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DECLINED")]
	Declined,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BOOKED")]
	Booked,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CURRENT")]
	Current,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DELINQUENT")]
	Delinquent,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DEFAULT")]
	Default,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CHARGED_OFF")]
	ChargedOff,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSFERRED")]
	Transferred,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAID_OFF")]
	PaidOff,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
