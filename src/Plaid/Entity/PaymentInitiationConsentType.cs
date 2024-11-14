namespace Going.Plaid.Entity;

/// <summary>
/// <para>Payment consent type. Defines possible use case for payments made with the given consent.</para>
/// </summary>
public enum PaymentInitiationConsentType
{
	/// <summary>
	/// <para>Allows moving money between accounts owned by the same user.</para>
	/// </summary>
	[EnumMember(Value = "SWEEPING")]
	Sweeping,

	/// <summary>
	/// <para>Allows initiating payments from the user's account to third parties.</para>
	/// </summary>
	[EnumMember(Value = "COMMERCIAL")]
	Commercial,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
