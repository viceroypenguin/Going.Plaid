namespace Going.Plaid.Entity;

/// <summary>
/// <para>Shorthand identifier for a specific screening list for individuals.</para>
/// </summary>
public enum IndividualWatchlistCode
{
	/// <summary>
	/// <para>Australia Department of Foreign Affairs and Trade Consolidated List</para>
	/// </summary>
	[EnumMember(Value = "AU_CON")]
	AuCon,

	/// <summary>
	/// <para>Government of Canada Consolidated List of Sanctions</para>
	/// </summary>
	[EnumMember(Value = "CA_CON")]
	CaCon,

	/// <summary>
	/// <para>European External Action Service Consolidated List</para>
	/// </summary>
	[EnumMember(Value = "EU_CON")]
	EuCon,

	/// <summary>
	/// <para>CIA List of Chiefs of State and Cabinet Members</para>
	/// </summary>
	[EnumMember(Value = "IZ_CIA")]
	IzCia,

	/// <summary>
	/// <para>Interpol Red Notices for Wanted Persons List</para>
	/// </summary>
	[EnumMember(Value = "IZ_IPL")]
	IzIpl,

	/// <summary>
	/// <para>Politically Exposed Persons List</para>
	/// </summary>
	[EnumMember(Value = "IZ_PEP")]
	IzPep,

	/// <summary>
	/// <para>United Nations Consolidated Sanctions</para>
	/// </summary>
	[EnumMember(Value = "IZ_UNC")]
	IzUnc,

	/// <summary>
	/// <para>World Bank Listing of Ineligible Firms and Individuals</para>
	/// </summary>
	[EnumMember(Value = "IZ_WBK")]
	IzWbk,

	/// <summary>
	/// <para>UK HM Treasury Consolidated List</para>
	/// </summary>
	[EnumMember(Value = "UK_HMC")]
	UkHmc,

	/// <summary>
	/// <para>Bureau of Industry and Security Denied Persons List</para>
	/// </summary>
	[EnumMember(Value = "US_DPL")]
	UsDpl,

	/// <summary>
	/// <para>US Department of State AECA Debarred</para>
	/// </summary>
	[EnumMember(Value = "US_DTC")]
	UsDtc,

	/// <summary>
	/// <para>US Department of Justice FBI Wanted List</para>
	/// </summary>
	[EnumMember(Value = "US_FBI")]
	UsFbi,

	/// <summary>
	/// <para>US OFAC Foreign Sanctions Evaders</para>
	/// </summary>
	[EnumMember(Value = "US_FSE")]
	UsFse,

	/// <summary>
	/// <para>US Department of State Nonproliferation Sanctions</para>
	/// </summary>
	[EnumMember(Value = "US_ISN")]
	UsIsn,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US_MBS")]
	UsMbs,

	/// <summary>
	/// <para>US OFAC Palestinian Legislative Council</para>
	/// </summary>
	[EnumMember(Value = "US_PLC")]
	UsPlc,

	/// <summary>
	/// <para>US OFAC Specially Designated Nationals List</para>
	/// </summary>
	[EnumMember(Value = "US_SDN")]
	UsSdn,

	/// <summary>
	/// <para>US OFAC Sectoral Sanctions Identifications</para>
	/// </summary>
	[EnumMember(Value = "US_SSI")]
	UsSsi,

	/// <summary>
	/// <para>Government of Singapore Terrorists and Terrorist Entities</para>
	/// </summary>
	[EnumMember(Value = "SG_SOF")]
	SgSof,

	/// <summary>
	/// <para>Government of Turkey Terrorist Wanted List</para>
	/// </summary>
	[EnumMember(Value = "TR_TWL")]
	TrTwl,

	/// <summary>
	/// <para>Government of Turkey Domestic Freezing Decisions</para>
	/// </summary>
	[EnumMember(Value = "TR_DFD")]
	TrDfd,

	/// <summary>
	/// <para>Government of Turkey Foreign Freezing Requests</para>
	/// </summary>
	[EnumMember(Value = "TR_FOR")]
	TrFor,

	/// <summary>
	/// <para>Government of Turkey Weapons of Mass Destruction</para>
	/// </summary>
	[EnumMember(Value = "TR_WMD")]
	TrWmd,

	/// <summary>
	/// <para>Government of Turkey Capital Markets Board</para>
	/// </summary>
	[EnumMember(Value = "TR_CMB")]
	TrCmb,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}