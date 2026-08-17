namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes an application that a particular end user previously connected and has since disconnected.</para>
/// </summary>
public record DisconnectedApplication
{
	/// <summary>
	/// <para>This field will map to the application ID that is returned from <c>/item/application/list</c>, or provided to the institution in an oauth redirect.</para>
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

}
