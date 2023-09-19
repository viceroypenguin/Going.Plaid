namespace Going.Plaid.Entity;

/// <summary>
/// <para>A statement's metadata associated with an account</para>
/// </summary>
public record StatementsStatement
{
	/// <summary>
	/// <para>Plaid's unique identifier for the statement.</para>
	/// </summary>
	[JsonPropertyName("statement_id")]
	public string StatementId { get; init; } = default!;

	/// <summary>
	/// <para>Month of the year. Possible values: 1 through 12 (January through December).</para>
	/// </summary>
	[JsonPropertyName("month")]
	public int Month { get; init; } = default!;

	/// <summary>
	/// <para>The year of statement.</para>
	/// </summary>
	[JsonPropertyName("year")]
	public int Year { get; init; } = default!;
}