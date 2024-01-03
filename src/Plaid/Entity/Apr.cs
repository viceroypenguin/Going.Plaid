namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the APR on the account.</para>
/// </summary>
public record Apr
{
	/// <summary>
	/// <para>Annual Percentage Rate applied.</para>
	/// </summary>
	[JsonPropertyName("apr_percentage")]
	public decimal AprPercentage { get; init; } = default!;

	/// <summary>
	/// <para>The type of balance to which the APR applies.</para>
	/// </summary>
	[JsonPropertyName("apr_type")]
	public Entity.AprAprTypeEnum AprType { get; init; } = default!;

	/// <summary>
	/// <para>Amount of money that is subjected to the APR if a balance was carried beyond payment due date. How it is calculated can vary by card issuer. It is often calculated as an average daily balance.</para>
	/// </summary>
	[JsonPropertyName("balance_subject_to_apr")]
	public decimal? BalanceSubjectToApr { get; init; } = default!;

	/// <summary>
	/// <para>Amount of money charged due to interest from last statement.</para>
	/// </summary>
	[JsonPropertyName("interest_charge_amount")]
	public decimal? InterestChargeAmount { get; init; } = default!;

}
