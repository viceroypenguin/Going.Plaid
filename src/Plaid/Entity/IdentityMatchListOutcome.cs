namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Identity Match decision for the attempt.</para>
/// </summary>
public enum IdentityMatchListOutcome
{
	/// <summary>
	/// <para>The decision was to allow the user to continue.</para>
	/// </summary>
	[EnumMember(Value = "PASS")]
	Pass,

	/// <summary>
	/// <para>The decision was to block the user.</para>
	/// </summary>
	[EnumMember(Value = "FAIL")]
	Fail,

	/// <summary>
	/// <para>The attempt's decision is unavailable or unrecognized.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
