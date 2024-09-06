namespace Going.Plaid.Entity;

/// <summary>
/// <para>The file type for risk signal analysis</para>
/// </summary>
public enum RiskSignalFileType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IMAGE_PDF")]
	ImagePdf,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SCAN_OCR")]
	ScanOcr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRUE_PDF")]
	TruePdf,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IMAGE")]
	Image,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MIXED_PAGE_PDF")]
	MixedPagePdf,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EMPTY_PDF")]
	EmptyPdf,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FLATTENED_PDF")]
	FlattenedPdf,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
