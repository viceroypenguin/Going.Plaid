namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for creating a Beacon Report</para>
/// </summary>
public partial class BeaconReportCreateRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; set; } = default!;

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
