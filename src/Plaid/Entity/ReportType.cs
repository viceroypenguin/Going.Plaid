namespace Going.Plaid.Entity;

/// <summary>
/// <para>The report type. It can be <c>assets</c> or <c>income</c>.</para>
/// </summary>
public enum ReportType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "assets")]
	Assets,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income")]
	Income,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}