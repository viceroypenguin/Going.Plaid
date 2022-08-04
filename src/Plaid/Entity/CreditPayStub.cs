namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an end user's pay stub.</para>
/// </summary>
public record CreditPayStub
{
	/// <summary>
	/// <para>An object with the deduction information found on a pay stub.</para>
	/// </summary>
	[JsonPropertyName("deductions")]
	public Entity.CreditPayStubDeductions Deductions { get; init; } = default!;

	/// <summary>
	/// <para>An identifier of the document referenced by the document metadata.</para>
	/// </summary>
	[JsonPropertyName("document_id")]
	public string? DocumentId { get; init; } = default!;

	/// <summary>
	/// <para>Object representing metadata pertaining to the document.</para>
	/// </summary>
	[JsonPropertyName("document_metadata")]
	public Entity.CreditDocumentMetadata DocumentMetadata { get; init; } = default!;

	/// <summary>
	/// <para>An object representing both a breakdown of earnings on a pay stub and the total earnings.</para>
	/// </summary>
	[JsonPropertyName("earnings")]
	public Entity.CreditPayStubEarnings Earnings { get; init; } = default!;

	/// <summary>
	/// <para>Data about the employee.</para>
	/// </summary>
	[JsonPropertyName("employee")]
	public Entity.CreditPayStubEmployee Employee { get; init; } = default!;

	/// <summary>
	/// <para>Information about the employer on the pay stub.</para>
	/// </summary>
	[JsonPropertyName("employer")]
	public Entity.CreditPayStubEmployer Employer { get; init; } = default!;

	/// <summary>
	/// <para>An object representing information about the net pay amount on the pay stub.</para>
	/// </summary>
	[JsonPropertyName("net_pay")]
	public Entity.CreditPayStubNetPay NetPay { get; init; } = default!;

	/// <summary>
	/// <para>Details about the pay period.</para>
	/// </summary>
	[JsonPropertyName("pay_period_details")]
	public Entity.PayStubPayPeriodDetails PayPeriodDetails { get; init; } = default!;

	/// <summary>
	/// <para>(To be deprecated) Verification info will be moved to a separate endpoint in the future. An object containing details on the paystub's verification status. This object will only be populated if the <a href="https://plaid.com/docs/api/tokens/#link-token-create-request-income-verification-access-tokens"><c>income_verification.access_tokens</c></a> parameter was provided during the <c>/link/token/create</c> call or if a problem was detected with the information supplied by the user; otherwise it will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("verification")]
	public Entity.CreditPayStubVerification? Verification { get; init; } = default!;
}