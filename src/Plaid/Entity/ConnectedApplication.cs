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
	/// <para>A URL that links to the application logo image (will be deprecated in the future, please use logo_url).</para>
	/// </summary>
	[JsonPropertyName("logo")]
	public string? Logo { get; init; } = default!;

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
	/// <para>The date this application was linked in ISO8601 (YYYY-MM-DD) format in UTC.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateOnly CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>(Deprecated) A list of enums representing the data collected and products enabled for this connected application.</para>
	/// </summary>
	[JsonPropertyName("product_data_types")]
	public IReadOnlyList<Entity.ConnectedApplicationProductDataTypesEnum> ProductDataTypes { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("scopes")]
	public Entity.Scopes? Scopes { get; init; } = default!;

	/// <summary>
	/// <para>Scope of required and optional account features or content from a ConnectedApplication.</para>
	/// </summary>
	[JsonPropertyName("requested_scopes")]
	public Entity.RequestedScopes RequestedScopes { get; init; } = default!;
}