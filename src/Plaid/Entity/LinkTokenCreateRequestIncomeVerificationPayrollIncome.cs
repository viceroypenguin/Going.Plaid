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
	public bool? IsUpdateMode { get; set; } = default!;

	/// <summary>
	/// <para>Uniquely identify a payroll income item to update with. It should only be used for update mode.</para>
	/// </summary>
	[JsonPropertyName("item_id_to_update")]
	public string? ItemIdToUpdate { get; set; } = default!;

	/// <summary>
	/// <para>The types of analysis to enable for document uploads. If none are specified, then docs will undergo OCR parsing only.</para>
	/// </summary>
	[JsonPropertyName("parsing_config")]
	public IReadOnlyList<Entity.IncomeVerificationDocParsingConfig>? ParsingConfig { get; set; } = default!;
}