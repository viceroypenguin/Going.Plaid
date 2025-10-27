namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of the Check Score. New integrations should use <c>/cra/check_report/lend_score/get</c> and the LendScore instead.</para>
/// </summary>
public enum PlaidCheckScoreVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "v1.0")]
	V10,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "v2.0")]
	V20,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
