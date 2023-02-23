namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of a transactions category rule.</para>
/// </summary>
public record TransactionsCategoryRule
{
	/// <summary>
	/// <para>A unique identifier of the rule created</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>A unique identifier of the Item the rule was created for.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Date and time when a rule was created in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>Personal finance category unique identifier.</para>
	/// <para>In the personal finance category taxonomy, this field is represented by the detailed category field.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category")]
	public string PersonalFinanceCategory { get; init; } = default!;

	/// <summary>
	/// <para>A representation of transactions rule details.</para>
	/// </summary>
	[JsonPropertyName("rule_details")]
	public Entity.TransactionsRuleDetails RuleDetails { get; init; } = default!;
}