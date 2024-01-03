namespace Going.Plaid.Entity;

/// <summary>
/// <para>Detailed information for the bank employment.</para>
/// </summary>
public record CreditBankEmployment
{
	/// <summary>
	/// <para>A unique identifier for the bank employment.</para>
	/// </summary>
	[JsonPropertyName("bank_employment_id")]
	public string BankEmploymentId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Object containing employer data.</para>
	/// </summary>
	[JsonPropertyName("employer")]
	public Entity.CreditBankEmployer Employer { get; init; } = default!;

	/// <summary>
	/// <para>The date of the most recent deposit from this employer.</para>
	/// </summary>
	[JsonPropertyName("latest_deposit_date")]
	public DateOnly LatestDepositDate { get; init; } = default!;

	/// <summary>
	/// <para>The date of the earliest deposit from this employer from within the period of the days requested.</para>
	/// </summary>
	[JsonPropertyName("earliest_deposit_date")]
	public DateOnly EarliestDepositDate { get; init; } = default!;

}
