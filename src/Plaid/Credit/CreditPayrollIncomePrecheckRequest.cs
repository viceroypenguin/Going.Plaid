namespace Going.Plaid.Credit;

/// <summary>
/// <para>Defines the request schema for <c>/credit/payroll_income/precheck</c>.</para>
/// </summary>
public partial class CreditPayrollIncomePrecheckRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>An array of access tokens corresponding to Items belonging to the user whose eligibility is being checked. Note that if the Items specified here are not already initialized with <c>transactions</c>, providing them in this field will cause these Items to be initialized with (and billed for) the Transactions product.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string> AccessTokens { get; set; } = default!;

	/// <summary>
	/// <para>Information about the end user's employer</para>
	/// </summary>
	[JsonPropertyName("employer")]
	public Entity.IncomeVerificationPrecheckEmployer? Employer { get; set; } = default!;

	/// <summary>
	/// <para>Data about military info in the income verification precheck.</para>
	/// </summary>
	[JsonPropertyName("us_military_info")]
	public Entity.IncomeVerificationPrecheckMilitaryInfo? UsMilitaryInfo { get; set; } = default!;

	/// <summary>
	/// <para>Information about the end user's payroll institution</para>
	/// </summary>
	[JsonPropertyName("payroll_institution")]
	public Entity.IncomeVerificationPrecheckPayrollInstitution? PayrollInstitution { get; set; } = default!;
}