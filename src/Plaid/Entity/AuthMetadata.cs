namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata that captures information about the Auth features of an institution.</para>
/// </summary>
public record AuthMetadata
{
	/// <summary>
	/// <para>Metadata specifically related to which auth methods an institution supports.</para>
	/// </summary>
	[JsonPropertyName("supported_methods")]
	public Entity.AuthSupportedMethods? SupportedMethods { get; init; } = default!;

}
