namespace Going.Plaid.Entity;

/// <summary>
/// <para>This field is deprecated in favor of the <c>breakdown</c> object, which provides more granular institution health data.</para>
/// </summary>
public enum ProductStatusStatusEnum
{
	/// <summary>
	/// <para>nearly all requests are successful</para>
	/// </summary>
	[EnumMember(Value = "HEALTHY")]
	Healthy,

	/// <summary>
	/// <para>a meaningful share of requests are failing, or data refreshes are delayed</para>
	/// </summary>
	[EnumMember(Value = "DEGRADED")]
	Degraded,

	/// <summary>
	/// <para>nearly all requests are failing, or data refreshes have stopped</para>
	/// </summary>
	[EnumMember(Value = "DOWN")]
	Down,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
