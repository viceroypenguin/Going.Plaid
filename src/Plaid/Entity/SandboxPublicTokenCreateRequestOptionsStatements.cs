namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional set of parameters corresponding to statements options.</para>
/// </summary>
public class SandboxPublicTokenCreateRequestOptionsStatements
{
	/// <summary>
	/// <para>The earliest date for which to fetch statements history. Dates should be formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The most recent date for which to fetch statements history. Dates should be formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; set; } = default!;

}
