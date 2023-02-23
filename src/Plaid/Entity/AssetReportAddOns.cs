namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of add-ons that should be included in the Asset Report</para>
/// </summary>
public enum AssetReportAddOns
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "investments")]
	Investments,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "fast_assets")]
	FastAssets,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}