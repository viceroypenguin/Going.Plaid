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
}