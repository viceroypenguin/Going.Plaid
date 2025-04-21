namespace Going.Plaid.Entity;

/// <summary>
/// <para>Add-ons that should be included in the Asset Report.</para>
/// </summary>
public enum AssetReportAddOns
{
	/// <summary>
	/// <para>The Investments add-on</para>
	/// </summary>
	[EnumMember(Value = "investments")]
	Investments,

	/// <summary>
	/// <para>The Fast Assets add-on</para>
	/// </summary>
	[EnumMember(Value = "fast_assets")]
	FastAssets,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
