namespace Going.Plaid.Entity;

/// <summary>
/// <para>Transaction rule's match type. For <c>TRANSACTION_ID</c> field, <c>EXACT_MATCH</c> is available.</para>
/// </summary>
public enum TransactionsRuleType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EXACT_MATCH")]
	ExactMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SUBSTRING_MATCH")]
	SubstringMatch,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
