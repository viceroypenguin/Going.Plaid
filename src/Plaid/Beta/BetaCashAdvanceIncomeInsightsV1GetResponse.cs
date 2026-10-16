namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaCashAdvanceIncomeInsightsV1GetResponse defines the response schema for <c>/beta/cash_advance/income_insights/v1/get</c></para>
/// </summary>
public record BetaCashAdvanceIncomeInsightsV1GetResponse : ResponseBase
{
	/// <summary>
	/// <para>The next payment date of the highest-ranked income stream, in ISO 8601 format (YYYY-MM-DD). <c>null</c> if the user has no income streams.</para>
	/// </summary>
	[JsonPropertyName("next_payment_date")]
	public DateOnly? NextPaymentDate { get; init; } = default!;

	/// <summary>
	/// <para>The historical net monthly income of the highest-ranked income stream. <c>null</c> if the user has no income streams.</para>
	/// </summary>
	[JsonPropertyName("next_payment_amount")]
	public decimal? NextPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of <c>next_payment_amount</c>. Always <c>USD</c> when <c>next_payment_amount</c> is set, and <c>null</c> otherwise.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The user's top income streams, ranked by historical net monthly income. Contains at most three streams, and is empty if the user has no income.</para>
	/// </summary>
	[JsonPropertyName("income_streams")]
	public IReadOnlyList<Entity.CashAdvanceIncomeStream> IncomeStreams { get; init; } = default!;

}
