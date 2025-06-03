namespace Going.Plaid.Entity;

/// <summary>
/// <para>The types of GSE Reports supported by the Plaid API</para>
/// </summary>
public enum GSEReportType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VOA")]
	Voa,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VOE")]
	Voe,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
