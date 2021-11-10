namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing details that can be found on the paystub.</para>
/// </summary>
public record PaystubDetails
{
	/// <summary>
	/// <para>Beginning date of the pay period on the paystub in the 'YYYY-MM-DD' format.</para>
	/// </summary>
	[JsonPropertyName("pay_period_start_date")]
	public DateOnly? PayPeriodStartDate { get; init; } = default!;

	/// <summary>
	/// <para>Ending date of the pay period on the paystub in the 'YYYY-MM-DD' format.</para>
	/// </summary>
	[JsonPropertyName("pay_period_end_date")]
	public DateOnly? PayPeriodEndDate { get; init; } = default!;

	/// <summary>
	/// <para>Pay date on the paystub in the 'YYYY-MM-DD' format.</para>
	/// </summary>
	[JsonPropertyName("pay_date")]
	public DateOnly? PayDate { get; init; } = default!;

	/// <summary>
	/// <para>The name of the payroll provider that generated the paystub, e.g. ADP</para>
	/// </summary>
	[JsonPropertyName("paystub_provider")]
	public string? PaystubProvider { get; init; } = default!;

	/// <summary>
	/// <para>The frequency at which the employee is paid. Possible values: <c>MONTHLY</c>, <c>BI-WEEKLY</c>, <c>WEEKLY</c>, <c>SEMI-MONTHLY</c>.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public Entity.PaystubPayFrequency? PayFrequency { get; init; } = default!;
}