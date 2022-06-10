namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing account level data.</para>
/// </summary>
public record PayrollIncomeAccountData
{
	/// <summary>
	/// <para>ID of the payroll provider account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the rate at which an individual is paid.</para>
	/// </summary>
	[JsonPropertyName("rate_of_pay")]
	public Entity.PayrollIncomeRateOfPay RateOfPay { get; init; } = default!;

	/// <summary>
	/// <para>The frequency at which an individual is paid.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public string? PayFrequency { get; init; } = default!;
}