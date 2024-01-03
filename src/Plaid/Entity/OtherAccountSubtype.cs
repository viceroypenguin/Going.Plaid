namespace Going.Plaid.Entity;

/// <summary>
/// <para>Valid account subtypes for other accounts. For a list containing descriptions of each subtype, see [Account schemas](https://plaid.com/docs/api/accounts/#StandaloneAccountType-other).</para>
/// </summary>
public enum OtherAccountSubtype
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "all")]
	All,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
