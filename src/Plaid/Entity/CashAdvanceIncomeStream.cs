namespace Going.Plaid.Entity;

/// <summary>
/// <para>An income stream returned by <c>/beta/cash_advance/income_insights/v1/get</c>.</para>
/// </summary>
public record CashAdvanceIncomeStream
{
	/// <summary>
	/// <para>The name of the income provider, such as an employer or benefits agency. <c>null</c> if the provider could not be identified.</para>
	/// </summary>
	[JsonPropertyName("provider_name")]
	public string? ProviderName { get; init; } = default!;

	/// <summary>
	/// <para>The category of an income stream.</para>
	/// </summary>
	[JsonPropertyName("category")]
	public Entity.CashAdvanceIncomeCategory? Category { get; init; } = default!;

	/// <summary>
	/// <para>The pay cadence of an income stream. <c>DYNAMIC</c> means the income recurs, but not on a regular schedule. <c>null</c> if the pay frequency could not be determined.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public Entity.CashAdvancePayFrequency? PayFrequency { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the income stream. Always <c>USD</c>.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

}
