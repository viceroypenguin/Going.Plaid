namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the income source.</para>
/// </summary>
public enum CraVerificationIncomeStatus
{
	/// <summary>
	/// <para>The income source is active.</para>
	/// </summary>
	[EnumMember(Value = "ACTIVE")]
	Active,

	/// <summary>
	/// <para>The income source is inactive.</para>
	/// </summary>
	[EnumMember(Value = "INACTIVE")]
	Inactive,

	/// <summary>
	/// <para>The income source status is unknown.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
