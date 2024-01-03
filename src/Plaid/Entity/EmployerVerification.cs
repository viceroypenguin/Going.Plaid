namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing employer data.</para>
/// </summary>
public record EmployerVerification
{
	/// <summary>
	/// <para>Name of employer.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

}
