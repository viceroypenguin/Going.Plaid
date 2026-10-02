namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum IdentityVerificationLanguage
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "en-US")]
	EnUs,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "es-ES")]
	EsEs,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "es-US")]
	EsUs,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "fr-CA")]
	FrCa,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ja-JP")]
	JaJp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pt-BR")]
	PtBr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pt-PT")]
	PtPt,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
