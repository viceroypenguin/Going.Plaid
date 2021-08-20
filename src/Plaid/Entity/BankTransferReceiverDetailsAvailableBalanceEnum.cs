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
}