namespace Going.Plaid.Entity;

/// <summary>
/// <para>A set of parameters for income verification options. This field is required if <c>income_verification</c> is included in the <c>initial_products</c> array.</para>
/// </summary>
public class SandboxPublicTokenCreateRequestOptionsIncomeVerification
{
	/// <summary>
	/// <para>The types of source income data that users will be permitted to share. Options include <c>bank</c> and <c>payroll</c>. Currently you can only specify one of these options.</para>
	/// </summary>
	[JsonPropertyName("income_source_types")]
	public IReadOnlyList<Entity.IncomeVerificationSourceType>? IncomeSourceTypes { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for Bank Income. This field is required if <c>income_verification</c> is included in the <c>initial_products</c> array and <c>bank</c> is specified in <c>income_source_types</c>.</para>
	/// </summary>
	[JsonPropertyName("bank_income")]
	public Entity.SandboxPublicTokenCreateRequestIncomeVerificationBankIncome? BankIncome { get; set; } = default!;

}
