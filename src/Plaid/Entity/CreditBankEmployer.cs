namespace Going.Plaid.Entity;

/// <summary>
/// <para>Object containing employer data.</para>
/// </summary>
public record CreditBankEmployer
{
	/// <summary>
	/// <para>Name of the employer.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

}
