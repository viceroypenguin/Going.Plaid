namespace Going.Plaid.Entity;

/// <summary>
/// <para>The warning code identifies a specific kind of warning. <c>OWNERS_UNAVAILABLE</c> indicates that account-owner information is not available. <c>INVESTMENTS_UNAVAILABLE</c> indicates that Investments specific information is not available. <c>TRANSACTIONS_UNAVAILABLE</c> indicates that transactions information associated with Credit and Depository accounts are unavailable. The <c>BANK_INCOME_INSIGHTS_*</c> codes apply to the Bank Income add-on: <c>BANK_INCOME_INSIGHTS_INSUFFICIENT_DATA</c> indicates there was not enough data to compute Bank Income Insights; <c>BANK_INCOME_INSIGHTS_INCOMPLETE</c> indicates the Bank Income Insights flow was not completed; <c>BANK_INCOME_INSIGHTS_STATUS_IN_PROGRESS</c> indicates Bank Income Insights are still being computed; <c>BANK_INCOME_INSIGHTS_INTERNAL_ERROR</c> indicates an internal error occurred while computing Bank Income Insights; <c>BANK_INCOME_INSIGHTS_MISMATCHED_DAYS_REQUESTED</c> indicates the days requested for Bank Income Insights did not match that of the Asset Report.</para>
/// </summary>
public enum WarningWarningCodeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OWNERS_UNAVAILABLE")]
	OwnersUnavailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVESTMENTS_UNAVAILABLE")]
	InvestmentsUnavailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_UNAVAILABLE")]
	TransactionsUnavailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_INSIGHTS_INSUFFICIENT_DATA")]
	BankIncomeInsightsInsufficientData,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_INSIGHTS_INCOMPLETE")]
	BankIncomeInsightsIncomplete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_INSIGHTS_STATUS_IN_PROGRESS")]
	BankIncomeInsightsStatusInProgress,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_INSIGHTS_INTERNAL_ERROR")]
	BankIncomeInsightsInternalError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_INSIGHTS_MISMATCHED_DAYS_REQUESTED")]
	BankIncomeInsightsMismatchedDaysRequested,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
