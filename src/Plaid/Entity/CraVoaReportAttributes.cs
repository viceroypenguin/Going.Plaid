namespace Going.Plaid.Entity;

/// <summary>
/// <para>Attributes for the VOA report.</para>
/// </summary>
public record CraVoaReportAttributes
{
	/// <summary>
	/// <para>Total amount of debit transactions into the report's accounts in the time period of the report. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_inflow_amount")]
	public Entity.TotalReportInflowAmount? TotalInflowAmount { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of credit transactions into the report's accounts in the time period of the report. This field only takes into account USD transactions from the accounts.</para>
	/// </summary>
	[JsonPropertyName("total_outflow_amount")]
	public Entity.TotalReportOutflowAmount? TotalOutflowAmount { get; init; } = default!;

}
