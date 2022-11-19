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
	/// <para>a food delivery marketplace (e.g DoorDash)</para>
	/// </summary>
	[EnumMember(Value = "delivery_marketplace")]
	DeliveryMarketplace,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}