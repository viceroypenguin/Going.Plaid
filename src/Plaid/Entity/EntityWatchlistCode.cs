namespace Going.Plaid.Entity;

/// <summary>
/// <para>Shorthand identifier for a specific screening list for entities.</para>
/// </summary>
public enum EntityWatchlistCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CA_CON")]
	CaCon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EU_CON")]
	EuCon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IZ_SOE")]
	IzSoe,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IZ_UNC")]
	IzUnc,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IZ_WBK")]
	IzWbk,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_CAP")]
	UsCap,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_FSE")]
	UsFse,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_MBS")]
	UsMbs,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_SDN")]
	UsSdn,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_SSI")]
	UsSsi,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_CMC")]
	UsCmc,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_UVL")]
	UsUvl,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AU_CON")]
	AuCon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UK_HMC")]
	UkHmc,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}