namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network.</para>
/// </summary>
public enum CreditACHClass
{
	/// <summary>
	/// <para>Corporate Credit or Debit - fund transfer between two corporate bank accounts</para>
	/// </summary>
	[EnumMember(Value = "ccd")]
	Ccd,

	/// <summary>
	/// <para>Prearranged Payment or Deposit - The transfer is part of a pre-existing relationship with a consumer. Authorization was obtained in writing either in person or via an electronic document signing, e.g. Docusign, by the consumer. Can be used for credits or debits.</para>
	/// </summary>
	[EnumMember(Value = "ppd")]
	Ppd,

	/// <summary>
	/// <para>Internet-Initiated Entry. The transfer debits a consumer’s bank account. Authorization from the consumer is obtained over the Internet (e.g. a web or mobile application). Can be used for single debits or recurring debits.</para>
	/// </summary>
	[EnumMember(Value = "web")]
	Web,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
