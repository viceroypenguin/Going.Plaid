namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/recurring/cancel</c></para>
/// </summary>
public partial class TransferRecurringCancelRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a recurring transfer.</para>
	/// </summary>
	[JsonPropertyName("recurring_transfer_id")]
	public string RecurringTransferId { get; set; } = default!;

}
