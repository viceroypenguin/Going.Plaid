namespace Going.Plaid.Entity;

/// <summary>
/// <para>A specific use case for a limited purpose checking account. Limited purpose checking accounts will reject or return ACH transactions that aren't for eligible use cases. For example, a <c>RENT_MORTGAGE</c> limited purpose checking account will reject ACH transactions that are not specifically rent or mortgage payments.</para>
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
