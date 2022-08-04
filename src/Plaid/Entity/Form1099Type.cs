namespace Going.Plaid.Entity;

/// <summary>
/// <para>Form 1099 Type</para>
/// </summary>
public enum Form1099Type
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FORM_1099_TYPE_UNKNOWN")]
	Form1099TypeUnknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FORM_1099_TYPE_MISC")]
	Form1099TypeMisc,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FORM_1099_TYPE_K")]
	Form1099TypeK,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}