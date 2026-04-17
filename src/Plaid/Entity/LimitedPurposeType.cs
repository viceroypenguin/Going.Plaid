namespace Going.Plaid.Entity;

/// <summary>
/// <para>A limited purpose type identifying the specific use case for limited purpose checking accounts.</para>
/// </summary>
public enum LimitedPurposeType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RENT_MORTGAGE")]
	RentMortgage,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
