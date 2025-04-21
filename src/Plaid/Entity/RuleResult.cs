namespace Going.Plaid.Entity;

/// <summary>
/// <para>The result of the rule that was triggered for this transaction.</para>
/// </summary>
public enum RuleResult
{
	/// <summary>
	/// <para>Accept the transaction for processing.</para>
	/// </summary>
	[EnumMember(Value = "ACCEPT")]
	Accept,

	/// <summary>
	/// <para>Reroute the transaction to a different payment method.</para>
	/// </summary>
	[EnumMember(Value = "REROUTE")]
	Reroute,

	/// <summary>
	/// <para>Review the transaction before proceeding.</para>
	/// </summary>
	[EnumMember(Value = "REVIEW")]
	Review,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
