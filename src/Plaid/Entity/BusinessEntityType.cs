namespace Going.Plaid.Entity;

/// <summary>
/// <para>The legal structure or type of business entity</para>
/// </summary>
public enum BusinessEntityType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sole_proprietorship")]
	SoleProprietorship,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "general_partnership")]
	GeneralPartnership,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "llc")]
	Llc,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "llp")]
	Llp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "lllp")]
	Lllp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "lp")]
	Lp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "c_corporation")]
	CCorporation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "s_corporation")]
	SCorporation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "b_corporation")]
	BCorporation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "nonprofit")]
	Nonprofit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cooperative")]
	Cooperative,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "trust")]
	Trust,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "professional_association")]
	ProfessionalAssociation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "professional_corporation")]
	ProfessionalCorporation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "trade_name")]
	TradeName,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bank")]
	Bank,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "credit_union")]
	CreditUnion,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "insurance")]
	Insurance,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
