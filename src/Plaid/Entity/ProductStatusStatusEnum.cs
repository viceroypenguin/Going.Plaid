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

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}