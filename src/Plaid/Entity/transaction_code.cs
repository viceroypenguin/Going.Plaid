namespace Going.Plaid.Entity;

/// <summary>
/// <para>An identifier classifying the transaction type.</para>
/// </summary>
public enum transaction_code
{
	/// <summary>
	/// <para>Bank adjustment</para>
	/// </summary>
	[EnumMember(Value = "adjustment")]
	Adjustment,

	/// <summary>
	/// <para>Cash deposit or withdrawal via an automated teller machine</para>
	/// </summary>
	[EnumMember(Value = "atm")]
	Atm,

	/// <summary>
	/// <para>Charge or fee levied by the institution</para>
	/// </summary>
	[EnumMember(Value = "bank charge")]
	BankCharge,

	/// <summary>
	/// <para>Payment of a bill</para>
	/// </summary>
	[EnumMember(Value = "bill payment")]
	BillPayment,

	/// <summary>
	/// <para>Cash deposit or withdrawal</para>
	/// </summary>
	[EnumMember(Value = "cash")]
	Cash,

	/// <summary>
	/// <para>Cash withdrawal while making a debit card purchase</para>
	/// </summary>
	[EnumMember(Value = "cashback")]
	Cashback,

	/// <summary>
	/// <para>Document ordering the payment of money to another person or organization</para>
	/// </summary>
	[EnumMember(Value = "cheque")]
	Cheque,

	/// <summary>
	/// <para>Automatic withdrawal of funds initiated by a third party at a regular interval</para>
	/// </summary>
	[EnumMember(Value = "direct debit")]
	DirectDebit,

	/// <summary>
	/// <para>Interest earned or incurred</para>
	/// </summary>
	[EnumMember(Value = "interest")]
	Interest,

	/// <summary>
	/// <para>Purchase made with a debit or credit card</para>
	/// </summary>
	[EnumMember(Value = "purchase")]
	Purchase,

	/// <summary>
	/// <para>Payment instructed by the account holder to a third party at a regular interval</para>
	/// </summary>
	[EnumMember(Value = "standing order")]
	StandingOrder,

	/// <summary>
	/// <para>Transfer of money between accounts</para>
	/// </summary>
	[EnumMember(Value = "transfer")]
	Transfer,
}