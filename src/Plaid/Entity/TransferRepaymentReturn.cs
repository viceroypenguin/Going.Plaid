namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a return on a Guaranteed ACH transfer that is included in the specified repayment.</para>
/// </summary>
public record TransferRepaymentReturn
{
	/// <summary>
	/// <para>The unique identifier of the guaranteed transfer that was returned.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; init; } = default!;

	/// <summary>
	/// <para>The unique identifier of the corresponding <c>returned</c> transfer event.</para>
	/// </summary>
	[JsonPropertyName("event_id")]
	public int EventId { get; init; } = default!;

	/// <summary>
	/// <para>The value of the returned transfer.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the repayment, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

}
