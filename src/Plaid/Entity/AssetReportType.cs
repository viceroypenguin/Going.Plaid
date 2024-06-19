namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates either a Fast Asset Report, which will contain only current identity and balance information, or a Full Asset Report, which will also contain historical balance information and transaction data.</para>
/// </summary>
public enum AssetReportType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FULL")]
	Full,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FAST")]
	Fast,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
