namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying values for <c>email</c> attributes of risk check.</para>
/// </summary>
public record RiskCheckEmail
{
	/// <summary>
	/// <para>SMTP-MX check to confirm the email address exists if known.</para>
	/// </summary>
	[JsonPropertyName("is_deliverable")]
	public Entity.RiskCheckEmailIsDeliverableStatus IsDeliverable { get; init; } = default!;

	/// <summary>
	/// <para>Count of all known breaches of this email address if known.</para>
	/// </summary>
	[JsonPropertyName("breach_count")]
	public int? BreachCount { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("first_breached_at")]
	public DateOnly? FirstBreachedAt { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("last_breached_at")]
	public DateOnly? LastBreachedAt { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("domain_registered_at")]
	public DateOnly? DomainRegisteredAt { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the email address domain is a free provider such as Gmail or Hotmail if known.</para>
	/// </summary>
	[JsonPropertyName("domain_is_free_provider")]
	public Entity.RiskCheckEmailDomainIsFreeProvider DomainIsFreeProvider { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the email address domain is custom if known, i.e. a company domain and not free or disposable.</para>
	/// </summary>
	[JsonPropertyName("domain_is_custom")]
	public Entity.RiskCheckEmailDomainIsCustom DomainIsCustom { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the email domain is listed as disposable if known. Disposable domains are often used to create email addresses that are part of a fake set of user details.</para>
	/// </summary>
	[JsonPropertyName("domain_is_disposable")]
	public Entity.RiskCheckEmailDomainIsDisposable DomainIsDisposable { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the email address top level domain, which is the last part of the domain, is fraudulent or risky if known. In most cases, a suspicious top level domain is also associated with a disposable or high-risk domain.</para>
	/// </summary>
	[JsonPropertyName("top_level_domain_is_suspicious")]
	public Entity.RiskCheckEmailTopLevelDomainIsSuspicious TopLevelDomainIsSuspicious { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("linked_services")]
	public IReadOnlyList<Entity.RiskCheckLinkedService> LinkedServices { get; init; } = default!;
}