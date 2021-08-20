namespace Going.Plaid.Entity;

/// <summary>
/// <para>Value is one of the following:</para>
/// </summary>
public enum InvestmentTransactionTypeEnum
{
	/// <summary>
	/// <para>Buying an investment</para>
	/// </summary>
	[EnumMember(Value = "buy")]
	Buy,

	/// <summary>
	/// <para>Selling an investment</para>
	/// </summary>
	[EnumMember(Value = "sell")]
	Sell,

	/// <summary>
	/// <para>A cancellation of a pending transaction</para>
	/// </summary>
	[EnumMember(Value = "cancel")]
	Cancel,

	/// <summary>
	/// <para>Activity that modifies a cash position</para>
	/// </summary>
	[EnumMember(Value = "cash")]
	Cash,

	/// <summary>
	/// <para>A fee on the account</para>
	/// </summary>
	[EnumMember(Value = "fee")]
	Fee,

	/// <summary>
	/// <para>Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer</para>
	/// </summary>
	[EnumMember(Value = "transfer")]
	Transfer,
}