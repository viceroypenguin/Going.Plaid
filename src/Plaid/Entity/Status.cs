namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record Status
{
	/// <summary>
	/// <para>Satus Code.</para>
	/// </summary>
	[JsonPropertyName("StatusCode")]
	public string? Statuscode { get; init; } = default!;

	/// <summary>
	/// <para>Status Description.</para>
	/// </summary>
	[JsonPropertyName("StatusDescription")]
	public string? Statusdescription { get; init; } = default!;
}