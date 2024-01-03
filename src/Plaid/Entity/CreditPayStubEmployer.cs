namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the employer on the pay stub.</para>
/// </summary>
public record CreditPayStubEmployer
{
	/// <summary>
	/// <para>Address on the pay stub.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.CreditPayStubAddress Address { get; init; } = default!;

	/// <summary>
	/// <para>The name of the employer on the pay stub.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

}
