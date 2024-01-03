namespace Going.Plaid.Entity;

/// <summary>
/// <para>Enum representing the state of the action/activity.</para>
/// </summary>
public enum ActionState
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ATTEMPT")]
	Attempt,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUCCESS")]
	Success,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FAILURE")]
	Failure,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SKIPPED")]
	Skipped,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
