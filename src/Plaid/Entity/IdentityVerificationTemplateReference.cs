namespace Going.Plaid.Entity;

/// <summary>
/// <para>The resource ID and version number of the template configuring the behavior of a given identity verification.</para>
/// </summary>
public record IdentityVerificationTemplateReference
{
	/// <summary>
	/// <para>ID of the associated Identity Verification template.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>Version of the associated Identity Verification template.</para>
	/// </summary>
	[JsonPropertyName("version")]
	public decimal Version { get; init; } = default!;
}