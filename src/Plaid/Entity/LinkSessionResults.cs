namespace Going.Plaid.Entity;

/// <summary>
/// <para>The set of results for a Link session.</para>
/// </summary>
public record LinkSessionResults
{
	/// <summary>
	/// <para>The set of Item adds for the Link session. If you are not receiving this field and are instead receiving the deprecated <c>on_success</c> field, contact your Account Manager to update your integration.</para>
	/// </summary>
	[JsonPropertyName("item_add_results")]
	public IReadOnlyList<Entity.LinkSessionItemAddResult> ItemAddResults { get; init; } = default!;

	/// <summary>
	/// <para>The set of Plaid Check Item adds for the Link session.</para>
	/// </summary>
	[JsonPropertyName("cra_item_add_results")]
	public IReadOnlyList<Entity.LinkSessionCraItemAddResult> CraItemAddResults { get; init; } = default!;

	/// <summary>
	/// <para>The set of Plaid Check Item updates for the Link session.</para>
	/// </summary>
	[JsonPropertyName("cra_update_results")]
	public IReadOnlyList<Entity.LinkSessionCraUpdateResult> CraUpdateResults { get; init; } = default!;

	/// <summary>
	/// <para>The set of bank income verifications for the Link session.</para>
	/// </summary>
	[JsonPropertyName("bank_income_results")]
	public IReadOnlyList<Entity.LinkSessionBankIncomeResult> BankIncomeResults { get; init; } = default!;

	/// <summary>
	/// <para>The set of payroll income verifications for the Link session.</para>
	/// </summary>
	[JsonPropertyName("payroll_income_results")]
	public IReadOnlyList<Entity.LinkSessionPayrollIncomeResult> PayrollIncomeResults { get; init; } = default!;

	/// <summary>
	/// <para>The details of a document income verification in Link</para>
	/// </summary>
	[JsonPropertyName("document_income_results")]
	public Entity.CreditSessionDocumentIncomeResult? DocumentIncomeResults { get; init; } = default!;

	/// <summary>
	/// <para>The details of a document upload CRA session in link</para>
	/// </summary>
	[JsonPropertyName("cra_document_upload_results")]
	public Entity.LinkSessionCraDocumentUploadResult? CraDocumentUploadResults { get; init; } = default!;

	/// <summary>
	/// <para>Plaid Protect details from the Link session</para>
	/// </summary>
	[JsonPropertyName("protect_results")]
	public Entity.LinkSessionProtectResult? ProtectResults { get; init; } = default!;

}
