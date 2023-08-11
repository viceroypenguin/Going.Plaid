namespace Going.Plaid.Entity;

/// <summary>
/// <para>Shorthand identifier for a specific screening list for entities.</para>
/// </summary>
public enum EntityWatchlistCode
{
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
	/// <para>State Owned Enterprise List</para>
	/// </summary>
	[EnumMember(Value = "IZ_SOE")]
	IzSoe,

	/// <summary>
	/// <para>United Nations Consolidated Sanctions</para>
	/// </summary>
	[EnumMember(Value = "IZ_UNC")]
	IzUnc,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IZ_WBK")]
	IzWbk,

	/// <summary>
	/// <para>US OFAC Correspondent Account or Payable-Through Account Sanctions</para>
	/// </summary>
	[EnumMember(Value = "US_CAP")]
	UsCap,

	/// <summary>
	/// <para>US OFAC Foreign Sanctions Evaders</para>
	/// </summary>
	[EnumMember(Value = "US_FSE")]
	UsFse,

	/// <summary>
	/// <para>US Non-SDN Menu-Based Sanctions</para>
	/// </summary>
	[EnumMember(Value = "US_MBS")]
	UsMbs,

	/// <summary>
	/// <para>US Specially Designated Nationals List</para>
	/// </summary>
	[EnumMember(Value = "US_SDN")]
	UsSdn,

	/// <summary>
	/// <para>US OFAC Sectoral Sanctions Identifications</para>
	/// </summary>
	[EnumMember(Value = "US_SSI")]
	UsSsi,

	/// <summary>
	/// <para>US OFAC Non-SDN Chinese Military-Industrial Complex List</para>
	/// </summary>
	[EnumMember(Value = "US_CMC")]
	UsCmc,

	/// <summary>
	/// <para>Bureau of Industry and Security Unverified List</para>
	/// </summary>
	[EnumMember(Value = "US_UVL")]
	UsUvl,

	/// <summary>
	/// <para>Australia Department of Foreign Affairs and Trade Consolidated List</para>
	/// </summary>
	[EnumMember(Value = "AU_CON")]
	AuCon,

	/// <summary>
	/// <para>UK HM Treasury Consolidated List</para>
	/// </summary>
	[EnumMember(Value = "UK_HMC")]
	UkHmc,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}