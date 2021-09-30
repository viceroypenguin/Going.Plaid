namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing data extracted from the end user's paystub.</para>
/// </summary>
public record Paystub
{
	/// <summary>
	/// <para>An object with the deduction information found on a paystub.</para>
	/// </summary>
	[JsonPropertyName("deductions")]
	public Entity.Deductions Deductions { get; init; } = default!;

	/// <summary>
	/// <para>An identifier of the document referenced by the document metadata.</para>
	/// </summary>
	[JsonPropertyName("doc_id")]
	public string DocId { get; init; } = default!;

	/// <summary>
	/// <para>An object representing both a breakdown of earnings on a paystub and the total earnings.</para>
	/// </summary>
	[JsonPropertyName("earnings")]
	public Entity.Earnings Earnings { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("employer")]
	public Entity.Employer Employer { get; init; } = default!;

	/// <summary>
	/// <para>Data about the employee.</para>
	/// </summary>
	[JsonPropertyName("employee")]
	public Entity.Employee Employee { get; init; } = default!;

	/// <summary>
	/// <para>An object representing employment details found on a paystub.</para>
	/// </summary>
	[JsonPropertyName("employment_details")]
	public Entity.EmploymentDetails EmploymentDetails { get; init; } = default!;

	/// <summary>
	/// <para>An object representing information about the net pay amount on the paystub.</para>
	/// </summary>
	[JsonPropertyName("net_pay")]
	public Entity.NetPay NetPay { get; init; } = default!;

	/// <summary>
	/// <para>Details about the pay period.</para>
	/// </summary>
	[JsonPropertyName("pay_period_details")]
	public Entity.PayPeriodDetails PayPeriodDetails { get; init; } = default!;

	/// <summary>
	/// <para>An object representing details that can be found on the paystub.</para>
	/// </summary>
	[JsonPropertyName("paystub_details")]
	public Entity.PaystubDetails PaystubDetails { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("income_breakdown")]
	public IReadOnlyList<Entity.IncomeBreakdown> IncomeBreakdown { get; init; } = default!;

	/// <summary>
	/// <para>The amount of income earned year to date, as based on paystub data.</para>
	/// </summary>
	[JsonPropertyName("ytd_earnings")]
	public Entity.PaystubYTDDetails YtdEarnings { get; init; } = default!;
}