namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum LinkSessionSuccessMetadataTransferStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "COMPLETE")]
	Complete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INCOMPLETE")]
	Incomplete,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
