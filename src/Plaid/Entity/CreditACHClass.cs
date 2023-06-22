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
	/// <para>Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment</para>
	/// </summary>
	[EnumMember(Value = "ppd")]
	Ppd,

	/// <summary>
	/// <para>A credit Entry initiated by or on behalf of a holder of a Consumer Account that is intended for a Consumer Account of a Receiver</para>
	/// </summary>
	[EnumMember(Value = "web")]
	Web,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}