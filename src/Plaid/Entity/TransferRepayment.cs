namespace Going.Plaid.Entity;

/// <summary>
/// <para>A repayment is created automatically after one or more guaranteed transactions receive a return. If there are multiple eligible returns in a day, they are batched together into a single repayment.</para>
/// <para>Repayments are sent over ACH, with funds typically available on the next banking day.</para>
/// </summary>
public record TransferRepayment
{
	/// <summary>
	/// <para>Identifier of the repayment.</para>
	/// </summary>
	[JsonPropertyName("repayment_id")]
	public string RepaymentId { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when the repayment occurred, in RFC 3339 format.</para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;

	/// <summary>
	/// <para>Decimal amount of the repayment as it appears on your account ledger.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the repayment, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

}
