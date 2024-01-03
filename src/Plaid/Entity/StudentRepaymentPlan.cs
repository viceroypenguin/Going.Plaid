namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the repayment plan for the student loan</para>
/// </summary>
public record StudentRepaymentPlan
{
	/// <summary>
	/// <para>The description of the repayment plan as provided by the servicer.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; init; } = default!;

	/// <summary>
	/// <para>The type of the repayment plan.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.StudentRepaymentPlanTypeEnum? Type { get; init; } = default!;

}
