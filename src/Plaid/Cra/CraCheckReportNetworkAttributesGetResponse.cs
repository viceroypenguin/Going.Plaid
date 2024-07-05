namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportNetworkAttributesGetResponse defines the response schema for <c>/cra/check_report/network_attributes/get</c>.</para>
/// </summary>
public record CraCheckReportNetworkAttributesGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains data for the CRA Network Attributes Report.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraNetworkAttributesReport Report { get; init; } = default!;

}
