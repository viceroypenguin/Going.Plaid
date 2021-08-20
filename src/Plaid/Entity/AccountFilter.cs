namespace Going.Plaid.Entity;

/// <summary>
/// <para>Enumerates the account subtypes that the application wishes for the user to be able to select from. For more details refer to Plaid documentation on account filters.</para>
/// </summary>
public record AccountFilter
{
	/// <summary>
	/// <para>A list of account subtypes to be filtered.</para>
	/// </summary>
	[JsonPropertyName("depository")]
	public IReadOnlyList<string> Depository { get; init; } = default!;

	/// <summary>
	/// <para>A list of account subtypes to be filtered.</para>
	/// </summary>
	[JsonPropertyName("credit")]
	public IReadOnlyList<string> Credit { get; init; } = default!;

	/// <summary>
	/// <para>A list of account subtypes to be filtered.</para>
	/// </summary>
	[JsonPropertyName("loan")]
	public IReadOnlyList<string> Loan { get; init; } = default!;

	/// <summary>
	/// <para>A list of account subtypes to be filtered.</para>
	/// </summary>
	[JsonPropertyName("investment")]
	public IReadOnlyList<string> Investment { get; init; } = default!;
}