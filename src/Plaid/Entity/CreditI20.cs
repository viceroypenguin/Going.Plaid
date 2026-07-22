namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an end user's Form I-20 US immigration student document.</para>
/// </summary>
public record CreditI20
{
	/// <summary>
	/// <para>An identifier of the document referenced by the document metadata.</para>
	/// </summary>
	[JsonPropertyName("document_id")]
	public string? DocumentId { get; init; } = default!;

	/// <summary>
	/// <para>Object representing metadata pertaining to the document.</para>
	/// </summary>
	[JsonPropertyName("document_metadata")]
	public Entity.CreditDocumentMetadata? DocumentMetadata { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the student named on a Form I-20.</para>
	/// </summary>
	[JsonPropertyName("student")]
	public Entity.CreditI20Student? Student { get; init; } = default!;

	/// <summary>
	/// <para>Amount of the student's personal funds.</para>
	/// </summary>
	[JsonPropertyName("personal_funds")]
	public decimal? PersonalFunds { get; init; } = default!;

	/// <summary>
	/// <para>Amount of funds from on-campus employment.</para>
	/// </summary>
	[JsonPropertyName("on_campus_employment")]
	public decimal? OnCampusEmployment { get; init; } = default!;

	/// <summary>
	/// <para>Amount of funds provided by the issuing school.</para>
	/// </summary>
	[JsonPropertyName("funds_from_this_school")]
	public decimal? FundsFromThisSchool { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of funds available to the student.</para>
	/// </summary>
	[JsonPropertyName("students_funding_total")]
	public decimal? StudentsFundingTotal { get; init; } = default!;

	/// <summary>
	/// <para>Amount of funds from another source.</para>
	/// </summary>
	[JsonPropertyName("funds_from_another_source")]
	public decimal? FundsFromAnotherSource { get; init; } = default!;

	/// <summary>
	/// <para>Estimated total average costs for the program period.</para>
	/// </summary>
	[JsonPropertyName("estimated_average_costs_total")]
	public decimal? EstimatedAverageCostsTotal { get; init; } = default!;

	/// <summary>
	/// <para>Estimated average living expenses.</para>
	/// </summary>
	[JsonPropertyName("estimated_average_living_expenses")]
	public decimal? EstimatedAverageLivingExpenses { get; init; } = default!;

	/// <summary>
	/// <para>Number of months the student's funding covers.</para>
	/// </summary>
	[JsonPropertyName("students_funding_period_months")]
	public int? StudentsFundingPeriodMonths { get; init; } = default!;

	/// <summary>
	/// <para>Number of months the estimated average costs cover.</para>
	/// </summary>
	[JsonPropertyName("estimated_average_costs_period_months")]
	public int? EstimatedAverageCostsPeriodMonths { get; init; } = default!;

}
