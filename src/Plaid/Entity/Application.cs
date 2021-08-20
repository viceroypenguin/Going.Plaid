namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata about the application</para>
/// </summary>
public record Application
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
	/// <para>The date this application was linked in ISO8601 (YYYY-MM-DD) format in UTC.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateOnly CreatedAt { get; init; } = default!;

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
}