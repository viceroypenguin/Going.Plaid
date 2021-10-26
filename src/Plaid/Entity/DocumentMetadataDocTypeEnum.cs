namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of document</para>
/// </summary>
public enum DocumentMetadataDocTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_PAYSTUB")]
	DocumentTypePaystub,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_BANK_STATEMENT")]
	DocumentTypeBankStatement,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_US_TAX_W2")]
	DocumentTypeUsTaxW2,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_US_MILITARY_ERAS")]
	DocumentTypeUsMilitaryEras,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_US_MILITARY_LES")]
	DocumentTypeUsMilitaryLes,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_US_MILITARY_CLES")]
	DocumentTypeUsMilitaryCles,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_GIG")]
	DocumentTypeGig,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}