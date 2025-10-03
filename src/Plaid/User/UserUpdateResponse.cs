namespace Going.Plaid.User;

/// <summary>
/// <para>UserUpdateResponse defines the response schema for <c>/user/update</c></para>
/// </summary>
public record UserUpdateResponse : ResponseBase
{
	/// <summary>
	/// <para>The result of creating an identity, indicating success or failure with optional error details.</para>
	/// </summary>
	[JsonPropertyName("identity_creation_result")]
	public Entity.IdentityCreationResult? IdentityCreationResult { get; init; } = default!;

}
