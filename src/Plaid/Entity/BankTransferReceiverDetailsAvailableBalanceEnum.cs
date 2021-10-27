namespace Going.Plaid.Entity;

/// <summary>
/// <para>The sign of the available balance for the receiver bank account associated with the receiver event at the time the matching transaction was found. Can be <c>positive</c>, <c>negative</c>, or null if the balance was not available at the time.</para>
/// </summary>
public enum BankTransferReceiverDetailsAvailableBalanceEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "positive")]
	Positive,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "negative")]
	Negative,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}