namespace Going.Plaid.Entity;

/// <summary>
/// <para>The details of a digital payroll income verification in Link.</para>
/// </summary>
public record LinkSessionPayrollIncomeResult
{
	/// <summary>
	/// <para>The number of paystubs retrieved from a payroll provider.</para>
	/// </summary>
	[JsonPropertyName("num_paystubs_retrieved")]
	public int NumPaystubsRetrieved { get; init; } = default!;

	/// <summary>
	/// <para>The number of W-2s retrieved from a payroll provider.</para>
	/// </summary>
	[JsonPropertyName("num_w2s_retrieved")]
	public int NumW2sRetrieved { get; init; } = default!;

	/// <summary>
	/// <para>An institution object. If the Item was created via Same-Day or Instant micro-deposit verification, will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("institution")]
	public Entity.LinkSessionSuccessMetadataInstitution? Institution { get; init; } = default!;

}
