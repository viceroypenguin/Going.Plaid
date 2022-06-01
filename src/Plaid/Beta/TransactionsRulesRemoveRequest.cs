namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsRulesRemoveRequest defines the request schema for <c>/beta/transactions/rules/v1/remove</c></para>
/// </summary>
public partial class TransactionsRulesRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>A rule's unique identifier</para>
	/// </summary>
	[JsonPropertyName("rule_id")]
	public string RuleId { get; set; } = default!;
}