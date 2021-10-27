namespace Going.Plaid.Entity;

/// <summary>
/// <para>The receiver details if the type of this event is <c>reciever_pending</c> or <c>reciever_posted</c>. Null value otherwise.</para>
/// </summary>
public record BankTransferReceiverDetails
{
	/// <summary>
	/// <para>The sign of the available balance for the receiver bank account associated with the receiver event at the time the matching transaction was found. Can be <c>positive</c>, <c>negative</c>, or null if the balance was not available at the time.</para>
	/// </summary>
	[JsonPropertyName("available_balance")]
	public Entity.BankTransferReceiverDetailsAvailableBalanceEnum? AvailableBalance { get; init; } = default!;
}