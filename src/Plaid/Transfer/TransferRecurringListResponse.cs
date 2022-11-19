namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/recurring/list</c></para>
/// </summary>
public record TransferRecurringListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("recurring_transfers")]
	public IReadOnlyList<Entity.RecurringTransfer> RecurringTransfers { get; init; } = default!;
}