namespace Going.Plaid.Entity;

/// <summary>
/// <para>The result of the bank income refresh report generation</para>
/// </summary>
public enum BankIncomeRefreshCompleteResult
{
	/// <summary>
	/// <para>The refreshed report was successfully generated and can be retrieved via <c>/credit/bank_income/get</c>.</para>
	/// </summary>
	[EnumMember(Value = "SUCCESS")]
	Success,

	/// <summary>
	/// <para>The refreshed report failed to be generated</para>
	/// </summary>
	[EnumMember(Value = "FAILURE")]
	Failure,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
