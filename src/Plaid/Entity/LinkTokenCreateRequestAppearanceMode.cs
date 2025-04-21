namespace Going.Plaid.Entity;

/// <summary>
/// <para>Enum representing the desired appearance mode for Link, used to force light or dark modes or set Link to change depending on user system settings. Currently in closed beta.</para>
/// </summary>
public enum LinkTokenCreateRequestAppearanceMode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LIGHT")]
	Light,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DARK")]
	Dark,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SYSTEM")]
	System,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
