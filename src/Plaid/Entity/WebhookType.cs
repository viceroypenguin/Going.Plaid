namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of supported Webhook Payload types.</para>
/// </summary>
public enum WebhookType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SCREENING")]
	Screening,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ENTITY_SCREENING")]
	EntityScreening,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IDENTITY_VERIFICATION")]
	IdentityVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS")]
	Transactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IDENTITY")]
	Identity,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AUTH")]
	Auth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM")]
	Item,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INCOME")]
	Income,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BANK_TRANSFERS")]
	BankTransfers,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSFER")]
	Transfer,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVESTMENTS_TRANSACTIONS")]
	InvestmentsTransactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HOLDINGS")]
	Holdings,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PARTNER")]
	Partner,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LIABILITIES")]
	Liabilities,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYMENT_INITIATION")]
	PaymentInitiation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WALLET")]
	Wallet,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DEPOSIT_SWITCH")]
	DepositSwitch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LINK_DELIVERY")]
	LinkDelivery,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BASE_REPORT")]
	BaseReport,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CRA_INCOME")]
	CraIncome,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LINK")]
	Link,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DASHBOARD_CONFIGURED_ALERT")]
	DashboardConfiguredAlert,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ASSETS")]
	Assets,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}