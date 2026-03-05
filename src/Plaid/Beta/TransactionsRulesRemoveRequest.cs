namespace Going.Plaid.Beta;

/// <summary>
/// <para>TransactionsRulesRemoveRequest defines the request schema for <c>/beta/transactions/rules/v1/remove</c></para>
/// </summary>
public partial class TransactionsRulesRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>A unique ID representing the end user the rule belongs to.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A rule's unique identifier</para>
	/// </summary>
	[JsonPropertyName("rule_id")]
	public string RuleId { get; set; } = default!;

}
