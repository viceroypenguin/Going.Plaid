namespace Going.Plaid.Entity;

/// <summary>
/// <para>The product type for the credit profile report request.</para>
/// </summary>
public enum CraCreditProfileReportType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "QUALIFY")]
	Qualify,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
