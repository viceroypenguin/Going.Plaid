namespace Going.Plaid.Entity;

/// <summary>
/// <para>The frequency at which an individual is paid.</para>
/// </summary>
public enum PayPeriodDetailsPayFrequency
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAY_FREQUENCY_UNKNOWN")]
	PayFrequencyUnknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAY_FREQUENCY_WEEKLY")]
	PayFrequencyWeekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAY_FREQUENCY_BIWEEKLY")]
	PayFrequencyBiweekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAY_FREQUENCY_SEMIMONTHLY")]
	PayFrequencySemimonthly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAY_FREQUENCY_MONTHLY")]
	PayFrequencyMonthly,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
