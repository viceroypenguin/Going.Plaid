namespace Going.Plaid.Entity;

/// <summary>
/// <para>Transaction field for which the rule is defined.</para>
/// </summary>
public enum TransactionsRuleField
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTION_ID")]
	TransactionId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NAME")]
	Name,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
