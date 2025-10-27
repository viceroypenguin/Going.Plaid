namespace Going.Plaid.Entity;

/// <summary>
/// <para>A broad categorization of the error. Safe for programmatic use.</para>
/// </summary>
public enum PlaidErrorType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVALID_REQUEST")]
	InvalidRequest,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVALID_RESULT")]
	InvalidResult,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVALID_INPUT")]
	InvalidInput,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INSTITUTION_ERROR")]
	InstitutionError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RATE_LIMIT_EXCEEDED")]
	RateLimitExceeded,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "API_ERROR")]
	ApiError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_ERROR")]
	ItemError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ASSET_REPORT_ERROR")]
	AssetReportError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECAPTCHA_ERROR")]
	RecaptchaError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OAUTH_ERROR")]
	OauthError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_ERROR")]
	PaymentError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_TRANSFER_ERROR")]
	BankTransferError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INCOME_VERIFICATION_ERROR")]
	IncomeVerificationError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MICRODEPOSITS_ERROR")]
	MicrodepositsError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SANDBOX_ERROR")]
	SandboxError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PARTNER_ERROR")]
	PartnerError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SIGNAL_ERROR")]
	SignalError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_ERROR")]
	TransactionsError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTION_ERROR")]
	TransactionError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSFER_ERROR")]
	TransferError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CHECK_REPORT_ERROR")]
	CheckReportError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CONSUMER_REPORT_ERROR")]
	ConsumerReportError,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
