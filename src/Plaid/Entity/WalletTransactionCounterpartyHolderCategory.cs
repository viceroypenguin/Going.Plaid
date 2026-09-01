namespace Going.Plaid.Entity;

/// <summary>
/// <para>Whether the counterparty is a personal or a business account holder. Payee verification schemes match a different set of identifiers for a natural person and a legal entity.</para>
/// </summary>
public enum WalletTransactionCounterpartyHolderCategory
{
	/// <summary>
	/// <para>the counterparty is an individual.</para>
	/// </summary>
	[EnumMember(Value = "personal")]
	Personal,

	/// <summary>
	/// <para>the counterparty is a company.</para>
	/// </summary>
	[EnumMember(Value = "business")]
	Business,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
