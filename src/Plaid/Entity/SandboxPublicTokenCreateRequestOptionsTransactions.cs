namespace Going.Plaid.Entity;

/// <summary>
/// <para>SandboxPublicTokenCreateRequestOptionsTransactions is an optional set of parameters corresponding to transactions options.</para>
/// </summary>
public class SandboxPublicTokenCreateRequestOptionsTransactions
{
	/// <summary>
	/// <para>The earliest date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The most recent date for which to fetch transaction history. Dates should be formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; set; } = default!;
}