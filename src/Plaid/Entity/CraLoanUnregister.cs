namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains loan data for the loan being unregistered.</para>
/// </summary>
public class CraLoanUnregister
{
	/// <summary>
	/// <para>A unique identifier for the loan. </para>
	/// <para>Personally identifiable information, such as an email address or phone number, should not be used in the <c>loan_id</c>.</para>
	/// </summary>
	[JsonPropertyName("loan_id")]
	public string LoanId { get; set; } = default!;

	/// <summary>
	/// <para>Contains the status and date information of the loan when unregistering.</para>
	/// </summary>
	[JsonPropertyName("closed_with_status")]
	public Entity.CraLoanClosedStatus ClosedWithStatus { get; set; } = default!;

}
