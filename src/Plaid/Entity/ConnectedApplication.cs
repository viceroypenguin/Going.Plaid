namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes the connected application for a particular end user.</para>
/// </summary>
public record ConnectedApplication
{
	/// <summary>
	/// <para>This field will map to the application ID that is returned from /item/applications/list, or provided to the institution in an oauth redirect.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string ApplicationId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the application</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>A human-readable name of the application for display purposes</para>
	/// </summary>
	[JsonPropertyName("display_name")]
	public string? DisplayName { get; init; } = default!;

	/// <summary>
	/// <para>A URL that links to the application logo image.</para>
	/// </summary>
	[JsonPropertyName("logo_url")]
	public string? LogoUrl { get; init; } = default!;

	/// <summary>
	/// <para>The URL for the application's website</para>
	/// </summary>
	[JsonPropertyName("application_url")]
	public string? ApplicationUrl { get; init; } = default!;

	/// <summary>
	/// <para>A string provided by the connected app stating why they use their respective enabled products.</para>
	/// </summary>
	[JsonPropertyName("reason_for_access")]
	public string? ReasonForAccess { get; init; } = default!;

	/// <summary>
	/// <para>The date this application was linked in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format in UTC.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateOnly CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The scopes object</para>
	/// </summary>
	[JsonPropertyName("scopes")]
	public Entity.Scopes? Scopes { get; init; } = default!;
}