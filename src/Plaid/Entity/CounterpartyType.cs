namespace Going.Plaid.Entity;

/// <summary>
/// <para>The counterparty type.</para>
/// </summary>
public enum CounterpartyType
{
	/// <summary>
	/// <para>a provider of goods or services for purchase</para>
	/// </summary>
	[EnumMember(Value = "merchant")]
	Merchant,

	/// <summary>
	/// <para>a financial entity (bank, credit union, BNPL, fintech)</para>
	/// </summary>
	[EnumMember(Value = "financial_institution")]
	FinancialInstitution,

	/// <summary>
	/// <para>a transfer or P2P app (e.g. Zelle)</para>
	/// </summary>
	[EnumMember(Value = "payment_app")]
	PaymentApp,

	/// <summary>
	/// <para>a marketplace (e.g DoorDash, Google Play Store)</para>
	/// </summary>
	[EnumMember(Value = "marketplace")]
	Marketplace,

	/// <summary>
	/// <para>a point-of-sale payment terminal (e.g Square, Toast)</para>
	/// </summary>
	[EnumMember(Value = "payment_terminal")]
	PaymentTerminal,

	/// <summary>
	/// <para>the payer in an income transaction (e.g., an employer, client, or government agency)</para>
	/// </summary>
	[EnumMember(Value = "income_source")]
	IncomeSource,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}