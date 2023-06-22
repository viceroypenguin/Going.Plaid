namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies what type of Reroute to Credentials pane should be used in the Link session for the Same Day Micro-deposits flow.</para>
/// </summary>
public enum LinkTokenCreateRequestAuthRerouteToCredentialsEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OFF")]
	Off,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OPTIONAL")]
	Optional,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FORCED")]
	Forced,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}