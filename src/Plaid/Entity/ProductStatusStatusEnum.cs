namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum ProductStatusStatusEnum
{
	/// <summary>
	/// <para>the majority of requests are successful</para>
	/// </summary>
	[EnumMember(Value = "HEALTHY")]
	Healthy,

	/// <summary>
	/// <para>only some requests are successful</para>
	/// </summary>
	[EnumMember(Value = "DEGRADED")]
	Degraded,

	/// <summary>
	/// <para>all requests are failing</para>
	/// </summary>
	[EnumMember(Value = "DOWN")]
	Down,
}