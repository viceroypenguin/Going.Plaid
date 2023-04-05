namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Employment product. This field is required if <c>employment</c> is included in the <c>products</c> array.</para>
/// </summary>
public class LinkTokenCreateRequestEmployment
{
	/// <summary>
	/// <para>The types of source employment data that users will be permitted to share. Options include <c>bank</c> and <c>payroll</c>. Currently you can only specify one of these options.</para>
	/// </summary>
	[JsonPropertyName("employment_source_types")]
	public IReadOnlyList<Entity.EmploymentSourceType>? EmploymentSourceTypes { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with Bank Employment. This field is required if <c>employment</c> is included in the <c>products</c> array and <c>bank</c> is specified in <c>employment_source_types</c>.</para>
	/// </summary>
	[JsonPropertyName("bank_employment")]
	public Entity.LinkTokenCreateRequestEmploymentBankIncome? BankEmployment { get; set; } = default!;
}