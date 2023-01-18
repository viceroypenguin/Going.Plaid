namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with Payroll Income.</para>
/// </summary>
public class LinkTokenCreateRequestIncomeVerificationPayrollIncome
{
	/// <summary>
	/// <para>The types of payroll income verification to enable for the Link session. If none are specified, then users will see both document and digital payroll income.</para>
	/// </summary>
	[JsonPropertyName("flow_types")]
	public IReadOnlyList<Entity.IncomeVerificationPayrollFlowType>? FlowTypes { get; set; } = default!;

	/// <summary>
	/// <para>An identifier to indicate whether the income verification Link token will be used for an update or not</para>
	/// </summary>
	[JsonPropertyName("is_update_mode")]
	public bool IsUpdateMode { get; set; } = default!;
}