namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record CreditFreddieMacIndividualName
{
	/// <summary>
	/// <para>The first name of the individual represented by the parent object.</para>
	/// </summary>
	[JsonPropertyName("FirstName")]
	public string Firstname { get; init; } = default!;

	/// <summary>
	/// <para>The last name of the individual represented by the parent object.</para>
	/// </summary>
	[JsonPropertyName("LastName")]
	public string Lastname { get; init; } = default!;

	/// <summary>
	/// <para>The middle name of the individual represented by the parent object.</para>
	/// </summary>
	[JsonPropertyName("MiddleName")]
	public string Middlename { get; init; } = default!;
}