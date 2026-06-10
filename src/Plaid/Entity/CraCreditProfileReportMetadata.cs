namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata about the CRA Credit Profile Report.</para>
/// </summary>
public record CraCreditProfileReportMetadata
{
	/// <summary>
	/// <para>The number of items used to calculate the report.</para>
	/// </summary>
	[JsonPropertyName("item_count")]
	public int ItemCount { get; init; } = default!;

	/// <summary>
	/// <para>The institution IDs associated with the report.</para>
	/// </summary>
	[JsonPropertyName("institution_ids")]
	public IReadOnlyList<string> InstitutionIds { get; init; } = default!;

	/// <summary>
	/// <para>The total number of accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("account_count")]
	public int AccountCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of primary accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("primary_account_count")]
	public int PrimaryAccountCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of depository accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("depository_account_type_count")]
	public int DepositoryAccountTypeCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of credit accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("credit_account_type_count")]
	public int CreditAccountTypeCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of other accounts in the report.</para>
	/// </summary>
	[JsonPropertyName("other_account_type_count")]
	public int OtherAccountTypeCount { get; init; } = default!;

	/// <summary>
	/// <para>The number of accounts with multiple owners in the report.</para>
	/// </summary>
	[JsonPropertyName("multiple_owner_account_count")]
	public int MultipleOwnerAccountCount { get; init; } = default!;

	/// <summary>
	/// <para>The time when the report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_at")]
	public DateTimeOffset GeneratedAt { get; init; } = default!;

	/// <summary>
	/// <para>The date of the oldest transaction in the report.</para>
	/// </summary>
	[JsonPropertyName("oldest_transaction_date")]
	public DateOnly OldestTransactionDate { get; init; } = default!;

	/// <summary>
	/// <para>The date of the most recent transaction in the report.</para>
	/// </summary>
	[JsonPropertyName("most_recent_transaction_date")]
	public DateOnly MostRecentTransactionDate { get; init; } = default!;

}
