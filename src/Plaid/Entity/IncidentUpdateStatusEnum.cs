namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the incident.</para>
/// </summary>
public enum IncidentUpdateStatusEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVESTIGATING")]
	Investigating,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IDENTIFIED")]
	Identified,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SCHEDULED")]
	Scheduled,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RESOLVED")]
	Resolved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}