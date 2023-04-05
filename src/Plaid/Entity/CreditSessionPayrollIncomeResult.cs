namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a digital payroll income verification in Link</para>
/// </summary>
public record CreditSessionPayrollIncomeResult
{
	/// <summary>
	/// <para>The number of paystubs retrieved from a payroll provider.</para>
	/// </summary>
	[JsonPropertyName("num_paystubs_retrieved")]
	public int? NumPaystubsRetrieved { get; init; } = default!;

	/// <summary>
	/// <para>The number of w2s retrieved from a payroll provider.</para>
	/// </summary>
	[JsonPropertyName("num_w2s_retrieved")]
	public int? NumW2sRetrieved { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid Institution ID associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The Institution Name associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string? InstitutionName { get; init; } = default!;
}