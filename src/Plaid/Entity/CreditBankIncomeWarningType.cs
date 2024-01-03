namespace Going.Plaid.Entity;

/// <summary>
/// <para>The warning type which will always be <c>BANK_INCOME_WARNING</c>.</para>
/// </summary>
public enum CreditBankIncomeWarningType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_WARNING")]
	BankIncomeWarning,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
