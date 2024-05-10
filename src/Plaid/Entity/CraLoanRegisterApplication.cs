namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains loan application data to register.</para>
/// </summary>
public class CraLoanRegisterApplication
{
	/// <summary>
	/// <para>A unique identifier for the loan application. </para>
	/// <para>Personally identifiable information, such as an email address or phone number, should not be used in the <c>application_id</c>.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string? ApplicationId { get; set; } = default!;

	/// <summary>
	/// <para>The date the user applied for the loan. The date should be in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("application_date")]
	public DateOnly? ApplicationDate { get; set; } = default!;

}
