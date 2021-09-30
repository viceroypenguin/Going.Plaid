namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing information about a distribution from the paycheck (for example, the amount distributed to a specific checking account, or to a retirement plan).</para>
/// </summary>
public record DistributionDetails
{
	/// <summary>
	/// <para>The account number of the account being deposited to.</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string? AccountNumber { get; init; } = default!;

	/// <summary>
	/// <para>The type of bank account (e.g. Checking or Savings)</para>
	/// </summary>
	[JsonPropertyName("bank_account_type")]
	public string? BankAccountType { get; init; } = default!;

	/// <summary>
	/// <para>The name of the bank that the payment is being deposited to.</para>
	/// </summary>
	[JsonPropertyName("bank_name")]
	public string? BankName { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a monetary amount.</para>
	/// </summary>
	[JsonPropertyName("current_pay")]
	public Entity.Pay CurrentPay { get; init; } = default!;

	/// <summary>
	/// <para>A description of the distribution type.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; init; } = default!;
}