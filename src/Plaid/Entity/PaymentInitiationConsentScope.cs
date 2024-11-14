namespace Going.Plaid.Entity;

/// <summary>
/// <para>This field is deprecated in favor of the consent <c>type</c> field. Consents are required to have a single type.</para>
/// </summary>
public enum PaymentInitiationConsentScope
{
	/// <summary>
	/// <para>Allows moving money between accounts owned by the same user.</para>
	/// </summary>
	[EnumMember(Value = "ME_TO_ME")]
	MeToMe,

	/// <summary>
	/// <para>Allows initiating payments from the user's account to third parties.</para>
	/// </summary>
	[EnumMember(Value = "EXTERNAL")]
	External,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
