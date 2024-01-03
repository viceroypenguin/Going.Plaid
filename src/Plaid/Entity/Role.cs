namespace Going.Plaid.Entity;

/// <summary>
/// <para>ADocumentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record Role
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ROLE_DETAIL")]
	public Entity.RoleDetail RoleDetail { get; init; } = default!;

}
