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
	/// 
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransactionsRuleType Type { get; set; } = default!;

	/// <summary>
	/// <para>For <c>TRANSACTION_ID</c> field, provide <c>transaction_id</c>. For <c>NAME</c> field, provide a string pattern.</para>
	/// </summary>
	[JsonPropertyName("query")]
	public string Query { get; set; } = default!;

}
