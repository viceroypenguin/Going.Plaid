namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes a sweep of funds to / from the sweep account.</para>
/// <para>A sweep is associated with many sweep events (events of type <c>swept</c> or <c>reverse_swept</c>) which can be retrieved by invoking the <c>/transfer/event/list</c> endpoint with the corresponding <c>sweep_id</c>.</para>
/// <para><c>swept</c> events occur when the transfer amount is credited or debited from your sweep account, depending on the <c>type</c> of the transfer. <c>reverse_swept</c> events occur when a transfer is reversed and Plaid undoes the credit or debit.</para>
/// <para>The total sum of the <c>swept</c> and <c>reverse_swept</c> events is equal to the <c>amount</c> of the sweep Plaid creates and matches the amount of the entry on your sweep account ledger.</para>
/// </summary>
public record TransferSweep
{
	/// <summary>
	/// <para>Identifier of the sweep.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when the sweep occurred, in RFC 3339 format.</para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>Signed decimal amount of the sweep as it appears on your sweep account ledger (e.g. "-10.00")</para>
	/// <para>If amount is not present, the sweep was net-settled to zero and outstanding debits and credits between the sweep account and Plaid are balanced.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the sweep, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;
}