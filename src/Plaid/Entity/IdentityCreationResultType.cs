namespace Going.Plaid.Entity;

/// <summary>
/// <para>The outcome of the identity creation operation.</para>
/// </summary>
public enum IdentityCreationResultType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUCCEEDED")]
	Succeeded,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NOT_PROVIDED")]
	NotProvided,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
