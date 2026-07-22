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
	[EnumMember(Value = "BASE_REPORT_ERROR")]
	BaseReportError,

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
	/// 
	/// </summary>
	[EnumMember(Value = "USER_ERROR")]
	UserError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IDEMPOTENCY_ERROR")]
	IdempotencyError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ASSETS_ERROR")]
	AssetsError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CRA_MONITORING_ERROR")]
	CraMonitoringError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CREDIT_PROFILE_REPORT_ERROR")]
	CreditProfileReportError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ENCOMPASS_ERROR")]
	EncompassError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ENRICH_ERROR")]
	EnrichError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FRAUD_INSIGHTS_ERROR")]
	FraudInsightsError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FREDDIE_MAC_ERROR")]
	FreddieMacError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LINK_DELIVERY_ERROR")]
	LinkDeliveryError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PROFILE_ERROR")]
	ProfileError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECURRING_TRANSACTIONS_ERROR")]
	RecurringTransactionsError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "STATEMENTS_ERROR")]
	StatementsError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSFER_RECURRING_ERROR")]
	TransferRecurringError,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSFER_REFUND_ERROR")]
	TransferRefundError,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
