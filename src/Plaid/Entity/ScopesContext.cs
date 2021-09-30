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
}