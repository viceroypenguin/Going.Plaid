namespace Going.Plaid.Entity;

/// <summary>
/// <para>Payment consent periodic interval.</para>
/// </summary>
public enum PaymentConsentPeriodicInterval
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DAY")]
	Day,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WEEK")]
	Week,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MONTH")]
	Month,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "YEAR")]
	Year,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}