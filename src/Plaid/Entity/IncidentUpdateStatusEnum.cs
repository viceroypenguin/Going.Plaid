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
}