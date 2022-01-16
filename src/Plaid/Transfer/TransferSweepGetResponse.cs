namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/sweep/get</c></para>
/// </summary>
public record TransferSweepGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Describes a sweep of funds to / from the sweep account.</para>
	/// <para>A sweep is associated with many sweep events (events of type <c>swept</c> or <c>reverse_swept</c>) which can be retrieved by invoking the <c>/transfer/event/list</c> endpoint with the corresponding <c>sweep_id</c>.</para>
	/// <para><c>swept</c> events occur when the transfer amount is credited or debited from your sweep account, depending on the <c>type</c> of the transfer. <c>reverse_swept</c> events occur when a transfer is reversed and Plaid undoes the credit or debit.</para>
	/// <para>The total sum of the <c>swept</c> and <c>reverse_swept</c> events is equal to the <c>amount</c> of the sweep Plaid creates and matches the amount of the entry on your sweep account ledger.</para>
	/// </summary>
	[JsonPropertyName("sweep")]
	public Entity.TransferSweep Sweep { get; init; } = default!;
}