namespace Going.Plaid.Entity;

/// <summary>
/// <para>The name of a field that can be reset back to null</para>
/// </summary>
public enum UpdateIndividualScreeningRequestResettableField
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "assignee")]
	Assignee,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}