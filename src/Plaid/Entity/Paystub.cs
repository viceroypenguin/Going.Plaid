namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing data extracted from the end user's paystub.</para>
/// </summary>
public record Paystub
{
	/// <summary>
	/// <para>The account identifier for the account associated with this paystub.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

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
	/// <para>Details about the pay period.</para>
	/// </summary>
	[JsonPropertyName("pay_period_details")]
	public Entity.PayPeriodDetails PayPeriodDetails { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("income_breakdown")]
	public Entity.IncomeBreakdown IncomeBreakdown { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("ytd_earnings")]
	public Entity.PaystubYtdEarningsObject YtdEarnings { get; init; } = default!;
}