namespace Going.Plaid.Entity;

/// <summary>
/// <para>An instruction specifying what steps the new Identity Verification attempt should require the user to complete:</para>
/// </summary>
public enum Strategy
{
	/// <summary>
	/// <para>Restart the user at the beginning of the session, regardless of whether they successfully completed part of their previous session.</para>
	/// </summary>
	[EnumMember(Value = "reset")]
	Reset,

	/// <summary>
	/// <para>Start the new session at the step that the user failed in the previous session, skipping steps that have already been successfully completed.</para>
	/// </summary>
	[EnumMember(Value = "incomplete")]
	Incomplete,

	/// <summary>
	/// <para>If the most recent Identity Verification attempt associated with the given <c>customer_reference</c> has a status of <c>failed</c> or <c>expired</c>, retry using the <c>incomplete</c> strategy. Otherwise, use the <c>reset</c> strategy.</para>
	/// </summary>
	[EnumMember(Value = "infer")]
	Infer,

	/// <summary>
	/// <para>Start the new session with a custom configuration, specified by the value of the <c>steps</c> field</para>
	/// </summary>
	[EnumMember(Value = "custom")]
	Custom,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}