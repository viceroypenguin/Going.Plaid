namespace Going.Plaid.Entity;

/// <summary>
/// <para>The account type. This will always be <c>depository</c>.</para>
/// </summary>
public enum CreditBankIncomeAccountType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "depository")]
	Depository,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
