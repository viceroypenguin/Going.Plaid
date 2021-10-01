namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationPrecheckRequest defines the request schema for <c>/income/verification/precheck</c></para>
/// </summary>
public partial class IncomeVerificationPrecheckRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.IncomeVerificationPrecheckUser? User { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("employer")]
	public Entity.IncomeVerificationPrecheckEmployer? Employer { get; set; } = default!;

	/// <summary>
	/// <para>The access token associated with the Item data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("transactions_access_token")]
	public string? TransactionsAccessToken { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("us_military_info")]
	public Entity.IncomeVerificationPrecheckMilitaryInfo? UsMilitaryInfo { get; set; } = default!;
}