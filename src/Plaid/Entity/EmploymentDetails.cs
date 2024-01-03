namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing employment details found on a paystub.</para>
/// </summary>
public record EmploymentDetails
{
	/// <summary>
	/// <para>An object representing a monetary amount.</para>
	/// </summary>
	[JsonPropertyName("annual_salary")]
	public Entity.Pay? AnnualSalary { get; init; } = default!;

	/// <summary>
	/// <para>Date on which the employee was hired, in the YYYY-MM-DD format.</para>
	/// </summary>
	[JsonPropertyName("hire_date")]
	public DateOnly? HireDate { get; init; } = default!;

}
