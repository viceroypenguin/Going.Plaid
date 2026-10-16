namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of transactions rule details.</para>
/// </summary>
public class TransactionsRuleDetails
{
	/// <summary>
	/// <para>Transaction field for which the rule is defined.</para>
	/// </summary>
	[JsonPropertyName("field")]
	public Entity.TransactionsRuleField Field { get; set; } = default!;

	/// <summary>
	/// <para>Transaction rule's match type. For <c>TRANSACTION_ID</c> field, <c>EXACT_MATCH</c> is available.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransactionsRuleType Type { get; set; } = default!;

	/// <summary>
	/// <para>For <c>TRANSACTION_ID</c> field, provide <c>transaction_id</c>. For <c>MERCHANT_NAME</c> field, provide a string pattern.</para>
	/// </summary>
	[JsonPropertyName("query")]
	public string Query { get; set; } = default!;

}
