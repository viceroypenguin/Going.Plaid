namespace Going.Plaid.Entity;

/// <summary>
/// <para>A type indicating whether a dashboard user, an API-based user, or Plaid last touched this object.</para>
/// </summary>
public enum Source
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "dashboard")]
	Dashboard,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "link")]
	Link,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "api")]
	Api,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "system")]
	System,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
