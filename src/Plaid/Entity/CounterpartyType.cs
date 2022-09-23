namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum CounterpartyType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "merchant")]
	Merchant,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "financial_institution")]
	FinancialInstitution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "payment_app")]
	PaymentApp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "delivery_marketplace")]
	DeliveryMarketplace,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}