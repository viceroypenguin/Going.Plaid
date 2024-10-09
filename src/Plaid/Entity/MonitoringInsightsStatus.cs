namespace Going.Plaid.Entity;

/// <summary>
/// <para>Enum for the status of the insights</para>
/// </summary>
public enum MonitoringInsightsStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AVAILABLE")]
	Available,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FAILED")]
	Failed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PENDING")]
	Pending,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNSUPPORTED")]
	Unsupported,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNHEALTHY")]
	Unhealthy,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
