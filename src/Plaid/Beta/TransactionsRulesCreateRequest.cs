namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsRulesCreateRequest defines the request schema for <c>beta/transactions/rules/v1/create</c></para>
/// </summary>
public partial class TransactionsRulesCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A unique ID representing the end user. This ID is used to associate rules with a specific user.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A personal finance primary category.</para>
	/// <para>See the <a href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy csv file</a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("pfc_primary_category")]
	public string PfcPrimaryCategory { get; set; } = default!;

	/// <summary>
	/// <para>A personal finance detailed category.</para>
	/// <para>See the <a href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy csv file</a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("pfc_detailed_category")]
	public string PfcDetailedCategory { get; set; } = default!;

	/// <summary>
	/// <para>A representation of transactions rule details.</para>
	/// </summary>
	[JsonPropertyName("rule_details")]
	public Entity.TransactionsRuleDetails RuleDetails { get; set; } = default!;

}
