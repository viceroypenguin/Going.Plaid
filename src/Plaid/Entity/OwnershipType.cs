namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum OwnershipType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "individual")]
	Individual,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "joint")]
	Joint,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "association")]
	Association,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "trust")]
	Trust,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}