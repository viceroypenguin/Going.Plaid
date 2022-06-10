namespace Going.Plaid.Entity;

/// <summary>
/// <para>This field has been deprecated in favor of <c>auth_type_select_enabled</c>.</para>
/// </summary>
public enum LinkTokenCreateRequestAuthFlowTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FLEXIBLE_AUTH")]
	FlexibleAuth,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}