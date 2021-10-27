namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxPublicTokenCreateResponse defines the response schema for <c>/sandbox/public_token/create</c></para>
/// </summary>
public record SandboxPublicTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A public token that can be exchanged for an access token using <c>/item/public_token/exchange</c></para>
	/// </summary>
	[JsonPropertyName("public_token")]
	public string PublicToken { get; init; } = default!;
}