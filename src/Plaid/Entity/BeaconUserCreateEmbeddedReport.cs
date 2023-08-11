namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data for creating a Beacon Report as part of an initial Beacon User creation. Providing a fraud report as part of an initial Beacon User creation will omit the Beacon User from any billing charges.</para>
/// </summary>
public class BeaconUserCreateEmbeddedReport
{
	/// <summary>
	/// <para>The type of Beacon Report.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.BeaconReportType Type { get; set; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("fraud_date")]
	public DateOnly FraudDate { get; set; } = default!;

	/// <summary>
	/// <para>The amount and currency of the fraud or attempted fraud.</para>
	/// <para><c>fraud_amount</c> should be omitted to indicate an unknown fraud amount.</para>
	/// </summary>
	[JsonPropertyName("fraud_amount")]
	public Entity.FraudAmount? FraudAmount { get; set; } = default!;
}