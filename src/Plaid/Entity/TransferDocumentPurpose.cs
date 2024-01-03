namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the purpose of the uploaded file.</para>
/// </summary>
public enum TransferDocumentPurpose
{
	/// <summary>
	/// <para>The transfer due diligence document of the originator.</para>
	/// </summary>
	[EnumMember(Value = "DUE_DILIGENCE")]
	DueDiligence,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
