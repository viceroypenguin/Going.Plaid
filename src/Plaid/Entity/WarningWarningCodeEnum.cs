namespace Going.Plaid.Entity;

/// <summary>
/// <para>The warning code identifies a specific kind of warning. Currently, the only possible warning code is <c>OWNERS_UNAVAILABLE</c>, which indicates that account-owner information is not available.</para>
/// </summary>
public enum WarningWarningCodeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OWNERS_UNAVAILABLE")]
	OwnersUnavailable,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}