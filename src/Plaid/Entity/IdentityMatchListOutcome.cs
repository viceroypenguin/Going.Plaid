namespace Going.Plaid.Entity;

/// <summary>
/// <para>Link outcome for the Identity Match attempt.</para>
/// </summary>
public enum IdentityMatchListOutcome
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PASS")]
	Pass,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FAIL")]
	Fail,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
