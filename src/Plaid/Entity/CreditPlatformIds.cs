namespace Going.Plaid.Entity;

/// <summary>
/// <para>The object containing a set of ids related to an employee.</para>
/// </summary>
public record CreditPlatformIds
{
	/// <summary>
	/// <para>The ID of an employee as given by their employer.</para>
	/// </summary>
	[JsonPropertyName("employee_id")]
	public string? EmployeeId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of an employee as given by their payroll.</para>
	/// </summary>
	[JsonPropertyName("payroll_id")]
	public string? PayrollId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the position of the employee.</para>
	/// </summary>
	[JsonPropertyName("position_id")]
	public string? PositionId { get; init; } = default!;

}
