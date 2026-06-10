namespace Going.Plaid.Entity;

/// <summary>
/// <para>The inquiry type of credit profile report.</para>
/// </summary>
public enum CraCreditProfileInquiryType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SOFT_INQUIRY")]
	SoftInquiry,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "STANDARD_INQUIRY")]
	StandardInquiry,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
