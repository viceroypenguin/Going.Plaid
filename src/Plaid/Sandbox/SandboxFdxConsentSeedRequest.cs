namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>Request to seed an FDX consent grant, and its backing item, for the given end user and recipient application so the FDX Consent API can be exercised in Sandbox.</para>
/// </summary>
public partial class SandboxFdxConsentSeedRequest : RequestBase
{
	/// <summary>
	/// <para>The data provider's identifier for the end user to associate the seeded consent grant with.</para>
	/// </summary>
	[JsonPropertyName("customer_id")]
	public string CustomerId { get; set; } = default!;

	/// <summary>
	/// <para>This field will map to the application ID that is returned from <c>/item/application/list</c>, or provided to the institution in an oauth redirect.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string ApplicationId { get; set; } = default!;

	/// <summary>
	/// <para>Optional UUIDv4 identifier for the seeded consent grant. If omitted, one is generated. Seeding fails if a grant with this identifier already exists.</para>
	/// </summary>
	[JsonPropertyName("consent_id")]
	public string? ConsentId { get; set; } = default!;

}
