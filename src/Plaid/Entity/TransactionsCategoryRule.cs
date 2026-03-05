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
	public string? Id { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid-generated unique identifier for the end user this rule belongs to.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

	/// <summary>
	/// <para>Date and time when a rule was created in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset? CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>Date and time when a rule was last updated in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).</para>
	/// </summary>
	[JsonPropertyName("updated_at")]
	public DateTimeOffset? UpdatedAt { get; init; } = default!;

	/// <summary>
	/// <para>A personal finance primary category.</para>
	/// <para>See the <a href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy csv file</a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("pfc_primary_category")]
	public string? PfcPrimaryCategory { get; init; } = default!;

	/// <summary>
	/// <para>A personal finance detailed category.</para>
	/// <para>See the <a href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy csv file</a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("pfc_detailed_category")]
	public string? PfcDetailedCategory { get; init; } = default!;

	/// <summary>
	/// <para>A representation of transactions rule details.</para>
	/// </summary>
	[JsonPropertyName("rule_details")]
	public Entity.TransactionsRuleDetails? RuleDetails { get; init; } = default!;

}
