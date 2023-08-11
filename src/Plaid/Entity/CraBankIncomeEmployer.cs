namespace Going.Plaid.Entity;

/// <summary>
/// <para>The object containing employer data.</para>
/// </summary>
public record CraBankIncomeEmployer
{
	/// <summary>
	/// <para>The name of the employer.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;
}