namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains the status and date information of the loan when unregistering.</para>
/// </summary>
public class CraLoanClosedStatus
{
	/// <summary>
	/// <para>The status of the loan.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.CraLoanStatus Status { get; set; } = default!;

	/// <summary>
	/// <para>The effective date for the status of the loan. The date should be in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; set; } = default!;

}
