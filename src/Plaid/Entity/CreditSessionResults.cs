namespace Going.Plaid.Entity;

/// <summary>
/// <para>The set of results for a Link session.</para>
/// </summary>
public record CreditSessionResults
{
	/// <summary>
	/// <para>The set of Item adds for the Link session.</para>
	/// </summary>
	[JsonPropertyName("item_add_results")]
	public IReadOnlyList<Entity.CreditSessionItemAddResult> ItemAddResults { get; init; } = default!;

	/// <summary>
	/// <para>The set of bank income verifications for the Link session.</para>
	/// </summary>
	[JsonPropertyName("bank_income_results")]
	public IReadOnlyList<Entity.CreditSessionBankIncomeResult> BankIncomeResults { get; init; } = default!;

	/// <summary>
	/// <para>The set of bank employment verifications for the Link session.</para>
	/// </summary>
	[JsonPropertyName("bank_employment_results")]
	public IReadOnlyList<Entity.CreditSessionBankEmploymentResult> BankEmploymentResults { get; init; } = default!;

	/// <summary>
	/// <para>The set of payroll income verifications for the Link session.</para>
	/// </summary>
	[JsonPropertyName("payroll_income_results")]
	public IReadOnlyList<Entity.CreditSessionPayrollIncomeResult> PayrollIncomeResults { get; init; } = default!;

	/// <summary>
	/// <para>The details of a document income verification in Link</para>
	/// </summary>
	[JsonPropertyName("document_income_results")]
	public Entity.CreditSessionDocumentIncomeResult? DocumentIncomeResults { get; init; } = default!;
}