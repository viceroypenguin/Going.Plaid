namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of supported Webhook Payload codes.</para>
/// </summary>
public enum WebhookCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "STATUS_UPDATED")]
	StatusUpdated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_STATUS_UPDATED")]
	UserStatusUpdated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "REPORT_CREATED")]
	ReportCreated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "REPORT_UPDATED")]
	ReportUpdated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "REPORT_SYNDICATION_CREATED")]
	ReportSyndicationCreated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DUPLICATE_DETECTED")]
	DuplicateDetected,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "STEP_UPDATED")]
	StepUpdated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RETRIED")]
	Retried,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_REMOVED")]
	TransactionsRemoved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DEFAULT_UPDATE")]
	DefaultUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SYNC_UPDATES_AVAILABLE")]
	SyncUpdatesAvailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECURRING_TRANSACTIONS_UPDATE")]
	RecurringTransactionsUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HISTORICAL_UPDATE")]
	HistoricalUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INITIAL_UPDATE")]
	InitialUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AUTOMATICALLY_VERIFIED")]
	AutomaticallyVerified,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VERIFICATION_EXPIRED")]
	VerificationExpired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WEBHOOK_UPDATE_ACKNOWLEDGED")]
	WebhookUpdateAcknowledged,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PENDING_EXPIRATION")]
	PendingExpiration,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ERROR")]
	Error,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LOGIN_REPAIRED")]
	LoginRepaired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PRODUCT_READY")]
	ProductReady,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PRODUCT_PERMISSIONS_REQUIRED")]
	ProductPermissionsRequired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_TRANSFERS_EVENTS_UPDATE")]
	BankTransfersEventsUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSFER_EVENTS_UPDATE")]
	TransferEventsUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECURRING_NEW_TRANSFER")]
	RecurringNewTransfer,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECURRING_TRANSFER_SKIPPED")]
	RecurringTransferSkipped,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECURRING_CANCELLED")]
	RecurringCancelled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "END_CUSTOMER_OAUTH_STATUS_UPDATED")]
	EndCustomerOauthStatusUpdated,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_STATUS_UPDATE")]
	PaymentStatusUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WALLET_TRANSACTION_STATUS_UPDATE")]
	WalletTransactionStatusUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_PERMISSION_REVOKED")]
	UserPermissionRevoked,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SWITCH_STATE_UPDATE")]
	SwitchStateUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INCOME_VERIFICATION")]
	IncomeVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INCOME_VERIFICATION_RISK_SIGNALS")]
	IncomeVerificationRiskSignals,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NEW_ACCOUNTS_AVAILABLE")]
	NewAccountsAvailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DELIVERY_STATUS")]
	DeliveryStatus,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LINK_CALLBACK")]
	LinkCallback,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_ACCOUNT_REVOKED")]
	UserAccountRevoked,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "STATEMENTS_REFRESH_COMPLETE")]
	StatementsRefreshComplete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_COMPLETE")]
	BankIncomeComplete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PARTNER_INSIGHTS_COMPLETE")]
	PartnerInsightsComplete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INCOME_VERIFICATION_REFRESH_RECONNECT_NEEDED")]
	IncomeVerificationRefreshReconnectNeeded,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_REFRESH_UPDATE")]
	BankIncomeRefreshUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_INCOME_REFRESH_COMPLETE")]
	BankIncomeRefreshComplete,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EVENTS")]
	Events,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SESSION_FINISHED")]
	SessionFinished,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SMS_MICRODEPOSITS_VERIFICATION")]
	SmsMicrodepositsVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INSTITUTION_STATUS_ALERT_TRIGGERED")]
	InstitutionStatusAlertTriggered,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
