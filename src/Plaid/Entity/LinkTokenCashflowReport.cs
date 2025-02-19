namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for the Cashflow Report product. Currently in closed beta.</para>
/// </summary>
public class LinkTokenCashflowReport
{
	/// <summary>
	/// <para>Number of days of transaction history to request in the Cashflow Report product.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

}
