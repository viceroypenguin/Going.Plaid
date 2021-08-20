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
}