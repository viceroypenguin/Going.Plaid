namespace Going.Plaid.Entity;

/// <summary>
/// <para>A sweep returned from the <c>/sandbox/transfer/sweep/simulate</c> endpoint.</para>
/// <para>Can be null if there are no transfers to include in a sweep.</para>
/// </summary>
public record SimulatedTransferSweep
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

	/// <summary>
	/// <para>The date when the sweep settled, in the YYYY-MM-DD format.</para>
	/// </summary>
	[JsonPropertyName("settled")]
	public DateOnly? Settled { get; init; } = default!;
}