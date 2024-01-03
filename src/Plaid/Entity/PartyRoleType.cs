namespace Going.Plaid.Entity;

/// <summary>
/// <para>A value from a MISMO defined list that identifies the role that the party plays in the transaction. Parties may be either a person or legal entity. A party may play multiple roles in a transaction.A value from a MISMO defined list that identifies the role that the party plays in the transaction. Parties may be either a person or legal entity. A party may play multiple roles in a transaction.</para>
/// </summary>
public enum PartyRoleType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "Borrower")]
	Borrower,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
