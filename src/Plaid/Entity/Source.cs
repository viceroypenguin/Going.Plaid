namespace Going.Plaid.Entity;

/// <summary>
/// <para>A type indicating who or what last touched this object. <c>dashboard</c>, <c>link</c>, and <c>api</c> indicate the originating surface; <c>system</c> indicates Plaid. <c>retro</c> indicates a screening created retroactively via a bulk screening creation.</para>
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
	/// 
	/// </summary>
	[EnumMember(Value = "retro")]
	Retro,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
