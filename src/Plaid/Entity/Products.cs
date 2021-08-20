namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.</para>
/// </summary>
public enum Products
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "assets")]
	Assets,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "auth")]
	Auth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "balance")]
	Balance,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "identity")]
	Identity,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "investments")]
	Investments,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "liabilities")]
	Liabilities,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "payment_initiation")]
	PaymentInitiation,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transactions")]
	Transactions,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "credit_details")]
	CreditDetails,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income")]
	Income,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "income_verification")]
	IncomeVerification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "deposit_switch")]
	DepositSwitch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "standing_orders")]
	StandingOrders,
}