namespace Going.Plaid.Entity;

/// <summary>
/// <para>Where the payment consent period should start.</para>
/// </summary>
public enum PaymentConsentPeriodicAlignment
{
	/// <summary>
	/// <para>line up with a calendar.</para>
	/// </summary>
	[EnumMember(Value = "CALENDAR")]
	Calendar,

	/// <summary>
	/// <para>on the date of consent creation.</para>
	/// </summary>
	[EnumMember(Value = "CONSENT")]
	Consent,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
