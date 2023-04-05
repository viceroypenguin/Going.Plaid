namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing proof of employment data for an individual</para>
/// </summary>
public record EmploymentVerification
{
	/// <summary>
	/// <para>Current employment status.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.EmploymentVerificationStatus? Status { get; init; } = default!;

	/// <summary>
	/// <para>Start of employment in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>End of employment, if applicable. Provided in ISO 8601 format (YYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>An object containing employer data.</para>
	/// </summary>
	[JsonPropertyName("employer")]
	public Entity.EmployerVerification? Employer { get; init; } = default!;

	/// <summary>
	/// <para>Current title of employee.</para>
	/// </summary>
	[JsonPropertyName("title")]
	public string? Title { get; init; } = default!;

	/// <summary>
	/// <para>An object containing a set of ids related to an employee</para>
	/// </summary>
	[JsonPropertyName("platform_ids")]
	public Entity.PlatformIds? PlatformIds { get; init; } = default!;
}