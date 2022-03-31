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
	/// <para>The date this application was linked in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format in UTC.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateOnly CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The date this application was granted production access at Plaid in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format in UTC.</para>
	/// </summary>
	[JsonPropertyName("join_date")]
	public DateOnly JoinDate { get; init; } = default!;

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
	/// <para>A string representing client’s broad use case as assessed by Plaid.</para>
	/// </summary>
	[JsonPropertyName("use_case")]
	public string? UseCase { get; init; } = default!;

	/// <summary>
	/// <para>A string representing the name of client’s legal entity.</para>
	/// </summary>
	[JsonPropertyName("company_legal_name")]
	public string? CompanyLegalName { get; init; } = default!;

	/// <summary>
	/// <para>A string representing the city of the client’s headquarters.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public string? City { get; init; } = default!;

	/// <summary>
	/// <para>A string representing the region of the client’s headquarters.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public string? Region { get; init; } = default!;

	/// <summary>
	/// <para>A string representing the postal code of the client’s headquarters.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public string? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>A string representing the country code of the client’s headquarters.</para>
	/// </summary>
	[JsonPropertyName("country_code")]
	public string? CountryCode { get; init; } = default!;
}