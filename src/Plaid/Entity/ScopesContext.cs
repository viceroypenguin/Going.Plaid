namespace Going.Plaid.Entity;

/// <summary>
/// <para>An indicator for when scopes are being updated. When scopes are updated via enrollment (i.e. OAuth), the partner must send <c>ENROLLMENT</c>. When scopes are updated in a post-enrollment view, the partner must send <c>PORTAL</c>.</para>
/// </summary>
public enum ScopesContext
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ENROLLMENT")]
	Enrollment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PORTAL")]
	Portal,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}