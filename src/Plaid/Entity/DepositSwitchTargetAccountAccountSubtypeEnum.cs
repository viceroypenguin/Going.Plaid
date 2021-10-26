namespace Going.Plaid.Entity;

/// <summary>
/// <para>The account subtype of the account, either <c>checking</c> or <c>savings</c>.</para>
/// </summary>
public enum DepositSwitchTargetAccountAccountSubtypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "checking")]
	Checking,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "savings")]
	Savings,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}