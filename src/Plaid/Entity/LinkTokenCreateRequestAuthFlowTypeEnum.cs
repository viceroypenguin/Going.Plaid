namespace Going.Plaid.Entity;

/// <summary>
/// <para>The optional Auth flow to use. Currently only used to enable Flexible Auth.</para>
/// </summary>
public enum LinkTokenCreateRequestAuthFlowTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FLEXIBLE_AUTH")]
	FlexibleAuth,
}