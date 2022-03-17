namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes if the connected item is active (i.e. has not been revoked or unlinked)</para>
/// </summary>
public enum ConnectedApplicationStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACTIVE")]
	Active,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INACTIVE")]
	Inactive,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}