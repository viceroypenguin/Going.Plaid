namespace Going.Plaid.Entity;

/// <summary>
/// <para>Shorthand identifier for a specific screening list for individuals.</para>
/// </summary>
public enum IndividualWatchlistCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AU_CON")]
	AuCon,

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
	[EnumMember(Value = "IZ_CIA")]
	IzCia,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IZ_IPL")]
	IzIpl,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IZ_PEP")]
	IzPep,

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
	[EnumMember(Value = "UK_HMC")]
	UkHmc,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_DPL")]
	UsDpl,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_DTC")]
	UsDtc,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_FBI")]
	UsFbi,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_FSE")]
	UsFse,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_ISN")]
	UsIsn,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_MBS")]
	UsMbs,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_PLC")]
	UsPlc,

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
	[EnumMember(Value = "SG_SOF")]
	SgSof,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TR_TWL")]
	TrTwl,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TR_DFD")]
	TrDfd,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TR_FOR")]
	TrFor,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TR_WMD")]
	TrWmd,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TR_CMB")]
	TrCmb,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}