namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of loan the user applied for.</para>
/// </summary>
public enum CraLoanType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PERSONAL")]
	Personal,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CREDIT_CARD")]
	CreditCard,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BUSINESS")]
	Business,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MORTGAGE")]
	Mortgage,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AUTO")]
	Auto,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYDAY")]
	Payday,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "STUDENT")]
	Student,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HOME_EQUITY")]
	HomeEquity,

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
