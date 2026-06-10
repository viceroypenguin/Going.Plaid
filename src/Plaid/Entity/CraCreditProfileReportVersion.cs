namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of the credit profile report to retrieve.</para>
/// </summary>
public enum CraCreditProfileReportVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "v1")]
	V1,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
