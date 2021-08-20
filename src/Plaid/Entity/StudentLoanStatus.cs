namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the status of the student loan</para>
/// </summary>
public record StudentLoanStatus
{
	/// <summary>
	/// <para>The date until which the loan will be in its current status. Dates are returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The status type of the student loan</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.StudentLoanStatusTypeEnum? Type { get; init; } = default!;
}