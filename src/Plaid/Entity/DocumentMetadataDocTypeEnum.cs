namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of document.</para>
/// </summary>
public enum DocumentMetadataDocTypeEnum
{
	/// <summary>
	/// <para>Document type could not be determined.</para>
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>A paystub.</para>
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_PAYSTUB")]
	DocumentTypePaystub,

	/// <summary>
	/// <para>A bank statement.</para>
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_BANK_STATEMENT")]
	DocumentTypeBankStatement,

	/// <summary>
	/// <para>A W-2 wage and tax statement provided by a US employer reflecting wages earned by the employee.</para>
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_US_TAX_W2")]
	DocumentTypeUsTaxW2,

	/// <summary>
	/// <para>An electronic Retirement Account Statement (eRAS) issued by the US military.</para>
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_US_MILITARY_ERAS")]
	DocumentTypeUsMilitaryEras,

	/// <summary>
	/// <para>A Leave and Earnings Statement (LES) issued by the US military.</para>
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_US_MILITARY_LES")]
	DocumentTypeUsMilitaryLes,

	/// <summary>
	/// <para>A Civilian Leave and Earnings Statment (CLES) issued by the US military.</para>
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_US_MILITARY_CLES")]
	DocumentTypeUsMilitaryCles,

	/// <summary>
	/// <para>Used to indicate that the income is related to gig work. Does not necessarily correspond to a specific document type.</para>
	/// </summary>
	[EnumMember(Value = "DOCUMENT_TYPE_GIG")]
	DocumentTypeGig,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}