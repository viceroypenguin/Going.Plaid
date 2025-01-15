namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing Layer-related metadata for the requested user.</para>
/// </summary>
public record NetworkStatusGetResponseLayer
{
	/// <summary>
	/// <para>Indicates if the user is eligible for a Layer session.</para>
	/// </summary>
	[JsonPropertyName("eligible")]
	public bool Eligible { get; init; } = default!;

}
