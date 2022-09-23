namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the end user's payroll institution</para>
/// </summary>
public class IncomeVerificationPrecheckPayrollInstitution
{
	/// <summary>
	/// <para>The name of payroll institution</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; set; } = default!;
}