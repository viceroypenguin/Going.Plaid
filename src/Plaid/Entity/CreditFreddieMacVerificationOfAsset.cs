namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record CreditFreddieMacVerificationOfAsset
{
	/// <summary>
	/// <para>Information about an report identifier and a report name.</para>
	/// </summary>
	[JsonPropertyName("REPORTING_INFORMATION")]
	public Entity.CreditFreddieMacReportingInformation ReportingInformation { get; init; } = default!;

	/// <summary>
	/// <para>A collection of details related to a fulfillment service or product in terms of request, process and result.</para>
	/// </summary>
	[JsonPropertyName("SERVICE_PRODUCT_FULFILLMENT")]
	public Entity.ServiceProductFulfillment ServiceProductFulfillment { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("VERIFICATION_OF_ASSET_RESPONSE")]
	public Entity.VerificationOfAssetResponse VerificationOfAssetResponse { get; init; } = default!;

}
