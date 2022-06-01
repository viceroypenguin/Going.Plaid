namespace Going.Plaid.Entity;

/// <summary>
/// <para>The <c>account_filters</c> specified in the original call to <c>/link/token/create</c>.</para>
/// </summary>
public record AccountFiltersResponse
{
	/// <summary>
	/// <para>A filter to apply to <c>depository</c>-type accounts</para>
	/// </summary>
	[JsonPropertyName("depository")]
	public Entity.DepositoryFilter Depository { get; init; } = default!;

	/// <summary>
	/// <para>A filter to apply to <c>credit</c>-type accounts</para>
	/// </summary>
	[JsonPropertyName("credit")]
	public Entity.CreditFilter Credit { get; init; } = default!;

	/// <summary>
	/// <para>A filter to apply to <c>loan</c>-type accounts</para>
	/// </summary>
	[JsonPropertyName("loan")]
	public Entity.LoanFilter Loan { get; init; } = default!;

	/// <summary>
	/// <para>A filter to apply to <c>investment</c>-type accounts (or <c>brokerage</c>-type accounts for API versions 2018-05-22 and earlier).</para>
	/// </summary>
	[JsonPropertyName("investment")]
	public Entity.InvestmentFilter Investment { get; init; } = default!;
}