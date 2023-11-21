namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the use case of the transfer. Required for transfers on an ACH network.</para>
/// </summary>
public enum AchClass
{
	/// <summary>
	/// <para>Corporate Credit or Debit - fund transfer between two corporate bank accounts</para>
	/// </summary>
	[EnumMember(Value = "ccd")]
	Ccd,

	/// <summary>
	/// <para>Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, e.g. bill payment</para>
	/// </summary>
	[EnumMember(Value = "ppd")]
	Ppd,

	/// <summary>
	/// <para>Telephone-Initiated Entry</para>
	/// </summary>
	[EnumMember(Value = "tel")]
	Tel,

	/// <summary>
	/// <para>Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet</para>
	/// </summary>
	[EnumMember(Value = "web")]
	Web,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}