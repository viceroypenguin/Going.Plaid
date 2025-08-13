namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed AAMVA data for the associated hit.</para>
/// <para>Note: This field is only available for U.S. driver's licenses issued by participating states.</para>
/// </summary>
public record AAMVAAnalysis
{
	/// <summary>
	/// <para>The overall outcome of checking the associated hit against the issuing state database.</para>
	/// </summary>
	[JsonPropertyName("is_verified")]
	public bool IsVerified { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the particular field against state databases.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.AAMVAMatchResult IdNumber { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the particular field against state databases.</para>
	/// </summary>
	[JsonPropertyName("id_issue_date")]
	public Entity.AAMVAMatchResult IdIssueDate { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the particular field against state databases.</para>
	/// </summary>
	[JsonPropertyName("id_expiration_date")]
	public Entity.AAMVAMatchResult IdExpirationDate { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the associated hit against state databases.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public Entity.AAMVADetailedMatchResult Street { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the particular field against state databases.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public Entity.AAMVAMatchResult City { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the associated hit against state databases.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public Entity.AAMVADetailedMatchResult PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the particular field against state databases.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public Entity.AAMVAMatchResult DateOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the particular field against state databases.</para>
	/// </summary>
	[JsonPropertyName("gender")]
	public Entity.AAMVAMatchResult Gender { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the particular field against state databases.</para>
	/// </summary>
	[JsonPropertyName("height")]
	public Entity.AAMVAMatchResult Height { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the particular field against state databases.</para>
	/// </summary>
	[JsonPropertyName("eye_color")]
	public Entity.AAMVAMatchResult EyeColor { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the associated hit against state databases.</para>
	/// </summary>
	[JsonPropertyName("first_name")]
	public Entity.AAMVADetailedMatchResult FirstName { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the associated hit against state databases.</para>
	/// </summary>
	[JsonPropertyName("middle_name")]
	public Entity.AAMVADetailedMatchResult MiddleName { get; init; } = default!;

	/// <summary>
	/// <para>The outcome of checking the associated hit against state databases.</para>
	/// </summary>
	[JsonPropertyName("last_name")]
	public Entity.AAMVADetailedMatchResult LastName { get; init; } = default!;

}
