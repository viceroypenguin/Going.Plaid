namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of incident being reported.</para>
/// </summary>
public enum ProtectReportType
{
	/// <summary>
	/// <para>Indicates that a legitimate user's account was accessed or controlled by an unauthorized party.</para>
	/// </summary>
	[EnumMember(Value = "USER_ACCOUNT_TAKEOVER")]
	UserAccountTakeover,

	/// <summary>
	/// <para>Indicates that a user created an account using stolen or fabricated identity information.</para>
	/// </summary>
	[EnumMember(Value = "FALSE_IDENTITY")]
	FalseIdentity,

	/// <summary>
	/// <para>Indicates that a user created an account using identity information belonging to a real individual without their consent.</para>
	/// </summary>
	[EnumMember(Value = "STOLEN_IDENTITY")]
	StolenIdentity,

	/// <summary>
	/// <para>Indicates that a user created an account using a fake or partially fabricated identity (e.g., combining real and fake information to form a new persona).</para>
	/// </summary>
	[EnumMember(Value = "SYNTHETIC_IDENTITY")]
	SyntheticIdentity,

	/// <summary>
	/// <para>Indicates that the same individual is operating multiple accounts in violation of policy.</para>
	/// </summary>
	[EnumMember(Value = "MULTIPLE_USER_ACCOUNTS")]
	MultipleUserAccounts,

	/// <summary>
	/// <para>Indicates that the user was tricked into authorizing or sending funds as part of a scam.</para>
	/// </summary>
	[EnumMember(Value = "SCAM_VICTIM")]
	ScamVictim,

	/// <summary>
	/// <para>Indicates that a user's linked bank account was accessed or misused by an unauthorized party.</para>
	/// </summary>
	[EnumMember(Value = "BANK_ACCOUNT_TAKEOVER")]
	BankAccountTakeover,

	/// <summary>
	/// <para>Indicates that a linked bank account connection was revoked by the financial institution, often due to suspected misuse, fraud, or security concerns.</para>
	/// </summary>
	[EnumMember(Value = "BANK_CONNECTION_REVOKED")]
	BankConnectionRevoked,

	/// <summary>
	/// <para>Indicates that a card was used in small or repeated transactions to test its validity.</para>
	/// </summary>
	[EnumMember(Value = "CARD_TESTING")]
	CardTesting,

	/// <summary>
	/// <para>Indicates that a transaction was made without the user's consent or authorization.</para>
	/// </summary>
	[EnumMember(Value = "UNAUTHORIZED_TRANSACTION")]
	UnauthorizedTransaction,

	/// <summary>
	/// <para>Indicates that a card transaction was reversed via a chargeback claim.</para>
	/// </summary>
	[EnumMember(Value = "CARD_CHARGEBACK")]
	CardChargeback,

	/// <summary>
	/// <para>Indicates that an ACH transaction was returned or reversed by the bank.</para>
	/// </summary>
	[EnumMember(Value = "ACH_RETURN")]
	AchReturn,

	/// <summary>
	/// <para>Indicates that a user filed a dispute regarding a transaction or account activity.</para>
	/// </summary>
	[EnumMember(Value = "DISPUTE")]
	Dispute,

	/// <summary>
	/// <para>Indicates that a user intentionally misrepresented themselves or their actions for financial gain.</para>
	/// </summary>
	[EnumMember(Value = "FIRST_PARTY_FRAUD")]
	FirstPartyFraud,

	/// <summary>
	/// <para>Indicates that a user failed to make a required payment on time.</para>
	/// </summary>
	[EnumMember(Value = "MISSED_PAYMENT")]
	MissedPayment,

	/// <summary>
	/// <para>Indicates that a user applied for or took out multiple loans simultaneously beyond their ability to repay.</para>
	/// </summary>
	[EnumMember(Value = "LOAN_STACKING")]
	LoanStacking,

	/// <summary>
	/// <para>Indicates that funds are being moved through accounts to obscure their illicit origin.</para>
	/// </summary>
	[EnumMember(Value = "MONEY_LAUNDERING")]
	MoneyLaundering,

	/// <summary>
	/// <para>Indicates that an investigation determined no fraudulent activity occurred on user/event (positive label)</para>
	/// </summary>
	[EnumMember(Value = "NO_FRAUD")]
	NoFraud,

	/// <summary>
	/// <para>Indicates that the case involves fraud or financial risk not covered by other report types. Requires notes describing the report.</para>
	/// </summary>
	[EnumMember(Value = "OTHER")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
