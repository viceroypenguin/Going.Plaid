namespace Going.Plaid.Entity;

/// <summary>
/// <para>A string representing the event that has just occurred in the Link flow.</para>
/// </summary>
public enum LinkEventName
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_INSIGHTS_COMPLETED")]
	BankIncomeInsightsCompleted,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CLOSE_OAUTH")]
	CloseOauth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ERROR")]
	Error,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EXIT")]
	Exit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FAIL_OAUTH")]
	FailOauth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HANDOFF")]
	Handoff,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OPEN")]
	Open,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OPEN_MY_PLAID")]
	OpenMyPlaid,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OPEN_OAUTH")]
	OpenOauth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SEARCH_INSTITUTION")]
	SearchInstitution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SELECT_AUTH_TYPE")]
	SelectAuthType,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SELECT_BRAND")]
	SelectBrand,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SELECT_DEGRADED_INSTITUTION")]
	SelectDegradedInstitution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SELECT_DOWN_INSTITUTION")]
	SelectDownInstitution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SELECT_INSTITUTION")]
	SelectInstitution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUBMIT_ACCOUNT_NUMBER")]
	SubmitAccountNumber,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUBMIT_CREDENTIALS")]
	SubmitCredentials,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUBMIT_DOCUMENTS")]
	SubmitDocuments,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUBMIT_DOCUMENTS_ERROR")]
	SubmitDocumentsError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUBMIT_DOCUMENTS_SUCCESS")]
	SubmitDocumentsSuccess,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUBMIT_MFA")]
	SubmitMfa,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUBMIT_ROUTING_NUMBER")]
	SubmitRoutingNumber,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSITION_VIEW")]
	TransitionView,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VIEW_DATA_TYPES")]
	ViewDataTypes,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}