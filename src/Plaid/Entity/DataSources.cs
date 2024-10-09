namespace Going.Plaid.Entity;

/// <summary>
/// <para>A description of the source of data for a given product/data type.</para>
/// </summary>
public enum DataSources
{
	/// <summary>
	/// <para>The institution supports this product, and the data was provided by the institution.</para>
	/// </summary>
	[EnumMember(Value = "INSTITUTION")]
	Institution,

	/// <summary>
	/// <para>The user manually provided the full account number, which was matched to the account mask provided by the institution. Only applicable to the <c>numbers</c> data type.</para>
	/// </summary>
	[EnumMember(Value = "INSTITUTION_MASK")]
	InstitutionMask,

	/// <summary>
	/// <para>The institution does not support this product, and the data was manually provided by the user.</para>
	/// </summary>
	[EnumMember(Value = "USER")]
	User,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
