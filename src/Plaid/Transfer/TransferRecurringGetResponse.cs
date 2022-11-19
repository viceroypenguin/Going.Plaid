namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/recurring/get</c></para>
/// </summary>
public record TransferRecurringGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a transfer within the Transfers API.</para>
	/// </summary>
	[JsonPropertyName("recurring_transfer")]
	public Entity.RecurringTransfer RecurringTransfer { get; init; } = default!;
}