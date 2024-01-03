namespace Going.Plaid.Entity;

/// <summary>
/// <para>The report type. It can be <c>asset</c>. Income report types are not yet supported.</para>
/// </summary>
public enum ReportType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "asset")]
	Asset,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
