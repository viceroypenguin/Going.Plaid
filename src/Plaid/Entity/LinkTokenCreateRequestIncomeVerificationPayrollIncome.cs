namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with Payroll Income (including Document Income). Further customization options for Document Income, such as customizing which document types may be uploaded, are also available via the <a href="https://dashboard.plaid.com/link">Link Customization pane</a> in the Dashboard. (Requires Production enablement.)</para>
/// </summary>
public class LinkTokenCreateRequestIncomeVerificationPayrollIncome
{
	/// <summary>
	/// <para>The types of payroll income verification to enable for the Link session. If none are specified, then users will see both document and digital payroll income.</para>
	/// </summary>
	[JsonPropertyName("flow_types")]
	public IReadOnlyList<Entity.IncomeVerificationPayrollFlowType>? FlowTypes { get; set; } = default!;

	/// <summary>
	/// <para>An identifier to indicate whether the income verification Link token will be used for update mode. This field is only relevant for participants in the Payroll Income Refresh beta.</para>
	/// </summary>
	[JsonPropertyName("is_update_mode")]
	public bool? IsUpdateMode { get; set; } = default!;

	/// <summary>
	/// <para>Uniquely identify a payroll income Item to update with.  This field is only relevant for participants in the Payroll Income Refresh beta.</para>
	/// </summary>
	[JsonPropertyName("item_id_to_update")]
	public string? ItemIdToUpdate { get; set; } = default!;

	/// <summary>
	/// <para>The types of analysis to enable for document uploads. If none are specified, then docs will undergo OCR parsing only. This field is only relevant to participants in the Document Fraud beta.</para>
	/// </summary>
	[JsonPropertyName("parsing_config")]
	public IReadOnlyList<Entity.IncomeVerificationDocParsingConfig>? ParsingConfig { get; set; } = default!;
}