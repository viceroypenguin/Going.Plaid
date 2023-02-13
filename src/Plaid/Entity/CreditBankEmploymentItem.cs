namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details and metadata for an end user's Item.</para>
/// </summary>
public record CreditBankEmploymentItem
{
	/// <summary>
	/// <para>The unique identifier for the Item.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The time when this Item's data was last retrieved from the financial institution, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("last_updated_time")]
	public DateTimeOffset LastUpdatedTime { get; init; } = default!;

	/// <summary>
	/// <para>The unique identifier of the institution associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the institution associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The bank employment information for this Item. Each entry in the array is a different employer found.</para>
	/// </summary>
	[JsonPropertyName("bank_employments")]
	public IReadOnlyList<Entity.CreditBankEmployment> BankEmployments { get; init; } = default!;

	/// <summary>
	/// <para>The Item's accounts that have Bank Employment data.</para>
	/// </summary>
	[JsonPropertyName("bank_employment_accounts")]
	public IReadOnlyList<Entity.CreditBankIncomeAccount> BankEmploymentAccounts { get; init; } = default!;
}