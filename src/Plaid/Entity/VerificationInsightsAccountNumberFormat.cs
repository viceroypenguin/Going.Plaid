namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicator of account number format validity for institution.</para>
/// </summary>
public enum VerificationInsightsAccountNumberFormat
{
	/// <summary>
	/// <para>indicates that the account number has a correct format for the institution.</para>
	/// </summary>
	[EnumMember(Value = "valid")]
	Valid,

	/// <summary>
	/// <para>indicates that the account number has an incorrect format for the institution.</para>
	/// </summary>
	[EnumMember(Value = "invalid")]
	Invalid,

	/// <summary>
	/// <para>indicates that there was not enough information to determine whether the format is correct for the institution.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
