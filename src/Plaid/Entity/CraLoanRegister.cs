namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains loan data to register.</para>
/// </summary>
public class CraLoanRegister
{
	/// <summary>
	/// <para>The user token for the user associated with the loan.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>A unique identifier for the loan.</para>
	/// <para>Personally identifiable information, such as an email address or phone number, should not be used in the <c>loan_id</c>.</para>
	/// </summary>
	[JsonPropertyName("loan_id")]
	public string LoanId { get; set; } = default!;

	/// <summary>
	/// <para>The type of loan the user applied for.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.CraLoanType Type { get; set; } = default!;

	/// <summary>
	/// <para>The frequency of a loan's payment schedule.</para>
	/// </summary>
	[JsonPropertyName("payment_schedule")]
	public Entity.CraLoanPaymentSchedule PaymentSchedule { get; set; } = default!;

	/// <summary>
	/// <para>The date the loan account was opened. The date should be in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("opened_date")]
	public DateOnly OpenedDate { get; set; } = default!;

	/// <summary>
	/// <para>Contains the status and date information of the loan when registering.</para>
	/// </summary>
	[JsonPropertyName("opened_with_status")]
	public Entity.CraLoanOpenedStatus OpenedWithStatus { get; set; } = default!;

	/// <summary>
	/// <para>The total amount of the approved loan.</para>
	/// </summary>
	[JsonPropertyName("loan_amount")]
	public decimal? LoanAmount { get; set; } = default!;

	/// <summary>
	/// <para>Contains loan application data to register.</para>
	/// </summary>
	[JsonPropertyName("application")]
	public Entity.CraLoanRegisterApplication? Application { get; set; } = default!;

}
