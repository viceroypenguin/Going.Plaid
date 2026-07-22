namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the student named on a Form I-20.</para>
/// </summary>
public record CreditI20Student
{
	/// <summary>
	/// <para>Given name of the student.</para>
	/// </summary>
	[JsonPropertyName("given_name")]
	public string? GivenName { get; init; } = default!;

	/// <summary>
	/// <para>Surname or primary name of the student.</para>
	/// </summary>
	[JsonPropertyName("surname_primary_name")]
	public string? SurnamePrimaryName { get; init; } = default!;

	/// <summary>
	/// <para>Name of the student as it appears on their passport.</para>
	/// </summary>
	[JsonPropertyName("passport_name")]
	public string? PassportName { get; init; } = default!;

	/// <summary>
	/// <para>Preferred name of the student.</para>
	/// </summary>
	[JsonPropertyName("preferred_name")]
	public string? PreferredName { get; init; } = default!;

	/// <summary>
	/// <para>Name of the school issuing the Form I-20.</para>
	/// </summary>
	[JsonPropertyName("school_name")]
	public string? SchoolName { get; init; } = default!;

	/// <summary>
	/// <para>Start date of the program in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("program_start_date")]
	public DateOnly? ProgramStartDate { get; init; } = default!;

	/// <summary>
	/// <para>End date of the program in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("program_end_date")]
	public DateOnly? ProgramEndDate { get; init; } = default!;

}
