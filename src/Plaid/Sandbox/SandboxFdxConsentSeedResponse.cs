namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Response containing the identifier of the seeded FDX consent grant, which can then be listed, retrieved, and revoked through the FDX Consent API.</para>
/// </summary>
public record SandboxFdxConsentSeedResponse : ResponseBase
{
	/// <summary>
	/// <para>The identifier of the newly seeded FDX consent grant.</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string ConsentId { get; init; } = default!;

}
