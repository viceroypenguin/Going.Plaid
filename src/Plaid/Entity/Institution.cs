namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details relating to a specific financial institution</para>
/// </summary>
public record Institution
{
	/// <summary>
	/// <para>Unique identifier for the institution</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The official name of the institution</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>A list of the Plaid products supported by the institution. Note that only institutions that support Instant Auth will return <c>auth</c> in the product array; institutions that do not list <c>auth</c> may still support other Auth methods such as Instant Match or Automated Micro-deposit Verification. For more details, see <a href="https://plaid.com/docs/auth/coverage/">Full Auth coverage</a>.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products> Products { get; init; } = default!;

	/// <summary>
	/// <para>A list of the country codes supported by the institution.</para>
	/// </summary>
	[JsonPropertyName("country_codes")]
	public IReadOnlyList<Entity.CountryCode> CountryCodes { get; init; } = default!;

	/// <summary>
	/// <para>The URL for the institution's website</para>
	/// </summary>
	[JsonPropertyName("url")]
	public string? Url { get; init; } = default!;

	/// <summary>
	/// <para>Hexadecimal representation of the primary color used by the institution</para>
	/// </summary>
	[JsonPropertyName("primary_color")]
	public string? PrimaryColor { get; init; } = default!;

	/// <summary>
	/// <para>Base64 encoded representation of the institution's logo</para>
	/// </summary>
	[JsonPropertyName("logo")]
	public string? Logo { get; init; } = default!;

	/// <summary>
	/// <para>A partial list of routing numbers associated with the institution. This list is provided for the purpose of looking up institutions by routing number. It is not comprehensive and should never be used as a complete list of routing numbers for an institution.</para>
	/// </summary>
	[JsonPropertyName("routing_numbers")]
	public IReadOnlyList<string>? RoutingNumbers { get; init; } = default!;

	/// <summary>
	/// <para>Indicates that the institution has an OAuth login flow. This is primarily relevant to institutions with European country codes.</para>
	/// </summary>
	[JsonPropertyName("oauth")]
	public bool Oauth { get; init; } = default!;

	/// <summary>
	/// <para>The status of an institution is determined by the health of its Item logins, Transactions updates, Investments updates, Liabilities updates, Auth requests, Balance requests, Identity requests, Investments requests, and Liabilities requests. A login attempt is conducted during the initial Item add in Link. If there is not enough traffic to accurately calculate an institution's status, Plaid will return null rather than potentially inaccurate data.</para>
	/// <para>Institution status is accessible in the Dashboard and via the API using the <c>/institutions/get_by_id</c> endpoint with the <c>include_status</c> option set to true. Note that institution status is not available in the Sandbox environment.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.InstitutionStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>Metadata that captures what specific payment configurations an institution supports when making Payment Initiation requests.</para>
	/// </summary>
	[JsonPropertyName("payment_initiation_metadata")]
	public Entity.PaymentInitiationMetadata? PaymentInitiationMetadata { get; init; } = default!;
}