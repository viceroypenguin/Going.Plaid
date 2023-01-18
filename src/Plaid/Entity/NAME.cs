namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record NAME
{
	/// <summary>
	/// <para>The unparsed name of either an individual or a legal entity.</para>
	/// </summary>
	[JsonPropertyName("FullName")]
	public string Fullname { get; init; } = default!;
}