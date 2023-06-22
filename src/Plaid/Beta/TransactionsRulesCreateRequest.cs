namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsRulesCreateRequest defines the request schema for <c>beta/transactions/rules/v1/create</c></para>
/// </summary>
public partial class TransactionsRulesCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Personal finance detailed category.</para>
	/// <para>All implementations are encouraged to use this field instead of <c>category</c>, as it provides more meaningful and accurate categorization.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category")]
	public string PersonalFinanceCategory { get; set; } = default!;

	/// <summary>
	/// <para>A representation of transactions rule details.</para>
	/// </summary>
	[JsonPropertyName("rule_details")]
	public Entity.TransactionsRuleDetails RuleDetails { get; set; } = default!;
}