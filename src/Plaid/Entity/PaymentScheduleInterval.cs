namespace Going.Plaid.Entity;

/// <summary>
/// <para>The frequency interval of the payment.</para>
/// </summary>
public enum PaymentScheduleInterval
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "WEEKLY")]
	Weekly,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MONTHLY")]
	Monthly,
}