namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditPayrollIncomeParsingConfigUpdateRequest defines the request schema for <c>/credit/payroll_income/documents/update</c>.</para>
/// </summary>
public partial class CreditPayrollIncomeParsingConfigUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; set; } = default!;

	/// <summary>
	/// <para>The types of analysis to enable for the document income verification session</para>
	/// </summary>
	[JsonPropertyName("parsing_config")]
	public IReadOnlyList<Entity.IncomeVerificationDocParsingConfig> ParsingConfig { get; set; } = default!;

}
