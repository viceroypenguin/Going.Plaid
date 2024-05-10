namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains loan application data.</para>
/// </summary>
public class CraLoanApplication
{
	/// <summary>
	/// <para>The user token for the user associated with the loan.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>A unique identifier for the loan application. </para>
	/// <para>Personally identifiable information, such as an email address or phone number, should not be used in the <c>application_id</c>.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string ApplicationId { get; set; } = default!;

	/// <summary>
	/// <para>The type of loan the user applied for.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.CraLoanType Type { get; set; } = default!;

	/// <summary>
	/// <para>The decision of the loan application.</para>
	/// </summary>
	[JsonPropertyName("decision")]
	public Entity.CraLoanApplicationDecision Decision { get; set; } = default!;

	/// <summary>
	/// <para>The date the user applied for the loan. The date should be in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("application_date")]
	public DateOnly? ApplicationDate { get; set; } = default!;

	/// <summary>
	/// <para>The date when the loan application's decision was made. The date should be in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("decision_date")]
	public DateOnly? DecisionDate { get; set; } = default!;

}
