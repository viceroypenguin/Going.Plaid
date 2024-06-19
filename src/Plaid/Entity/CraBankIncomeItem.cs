namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details and metadata for an end user's Item.</para>
/// </summary>
public record CraBankIncomeItem
{
	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The Item's accounts that have Bank Income data.</para>
	/// </summary>
	[JsonPropertyName("bank_income_accounts")]
	public IReadOnlyList<Entity.CraBankIncomeAccount> BankIncomeAccounts { get; init; } = default!;

	/// <summary>
	/// <para>The income sources for this Item. Each entry in the array is a single income source.</para>
	/// </summary>
	[JsonPropertyName("bank_income_sources")]
	public IReadOnlyList<Entity.CraBankIncomeSource> BankIncomeSources { get; init; } = default!;

	/// <summary>
	/// <para>The time when this Item's data was last retrieved from the financial institution.</para>
	/// </summary>
	[JsonPropertyName("last_updated_time")]
	public DateTimeOffset? LastUpdatedTime { get; init; } = default!;

	/// <summary>
	/// <para>The unique identifier of the institution associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the institution associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string? InstitutionName { get; init; } = default!;

}
