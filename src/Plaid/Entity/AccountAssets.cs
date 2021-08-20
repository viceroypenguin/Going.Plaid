namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record AccountAssets : Entity.Account
{
	/// <summary>
	/// <para>The duration of transaction history available for this Item, typically defined as the time since the date of the earliest transaction in that account. Only returned by Assets endpoints.</para>
	/// </summary>
	[JsonPropertyName("days_available")]
	public decimal DaysAvailable { get; init; } = default!;

	/// <summary>
	/// <para>Transaction history associated with the account. Only returned by Assets endpoints. Transaction history returned by endpoints such as <c>/transactions/get</c> or <c>/investments/transactions/get</c> will be returned in the top-level <c>transactions</c> field instead.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.AssetReportTransaction> Transactions { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by the financial institution about the account owner or owners. Only returned by Identity or Assets endpoints. Multiple owners on a single account will be represented in the same <c>owner</c> object, not in multiple owner objects within the array.</para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner> Owners { get; init; } = default!;

	/// <summary>
	/// <para>Calculated data about the historical balances on the account. Only returned by Assets endpoints.</para>
	/// </summary>
	[JsonPropertyName("historical_balances")]
	public IReadOnlyList<Entity.HistoricalBalance> HistoricalBalances { get; init; } = default!;
}