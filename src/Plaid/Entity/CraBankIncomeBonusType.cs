namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of bonus that this transaction represents, if it is a bonus.</para>
/// </summary>
public enum CraBankIncomeBonusType
{
	/// <summary>
	/// <para>Bonus is included in this transaction along with the normal pay</para>
	/// </summary>
	[EnumMember(Value = "BONUS_INCLUDED")]
	BonusIncluded,

	/// <summary>
	/// <para>This transaction is a standalone bonus</para>
	/// </summary>
	[EnumMember(Value = "BONUS_ONLY")]
	BonusOnly,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
