namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with Payroll Income. This field is required if <c>income_verification</c> is included in the <c>products</c> array and <c>payroll</c> is specified in <c>income_source_types</c>.</para>
/// </summary>
public class LinkTokenCreateRequestIncomeVerificationPayrollIncome
{
	/// <summary>
	/// <para>The types of payroll income verification to enable for the link session. If none are specified, then users will see both document and digital payroll income.</para>
	/// </summary>
	[JsonPropertyName("flow_types")]
	public IReadOnlyList<Entity.IncomeVerificationPayrollFlowType>? FlowTypes { get; set; } = default!;

	/// <summary>
	/// <para>An identifier to indicate whether the income verification link token will be used for an update or not</para>
	/// </summary>
	[JsonPropertyName("is_update_mode")]
	public bool IsUpdateMode { get; set; } = default!;
}