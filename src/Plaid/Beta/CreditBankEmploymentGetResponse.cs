namespace Going.Plaid.Beta;

/// <summary>
/// <para>CreditBankEmploymentGetResponse defines the response schema for <c>/beta/credit/v1/bank_employment/get</c>.</para>
/// </summary>
public record CreditBankEmploymentGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Bank Employment data. Each entry in the array will be a distinct bank employment report.</para>
	/// </summary>
	[JsonPropertyName("bank_employment_reports")]
	public IReadOnlyList<Entity.CreditBankEmploymentReport> BankEmploymentReports { get; init; } = default!;
}