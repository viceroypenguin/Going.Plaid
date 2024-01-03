namespace Going.Plaid.Beacon;

/// <summary>
/// <para>A Beacon Report describes the type of fraud committed by a user as well as the date the fraud was committed and the total amount of money lost due to the fraud incident.</para>
/// <para>This information is used to block similar fraud attempts on your platform as well as alert other companies who screen a user with matching identity information.</para>
/// <para>Other companies will not receive any new identity information, just what matched, plus information such as industry, type of fraud, and date of fraud.</para>
/// <para>You can manage your fraud reports by adding, deleting, or editing reports as you get additional information on fraudulent users.</para>
/// </summary>
public record BeaconReportGetResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated Beacon Report.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The type of Beacon Report.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.BeaconReportType Type { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("fraud_date")]
	public DateOnly FraudDate { get; init; } = default!;

	/// <summary>
	/// <para>The amount and currency of the fraud or attempted fraud.</para>
	/// <para><c>fraud_amount</c> should be omitted to indicate an unknown fraud amount.</para>
	/// </summary>
	[JsonPropertyName("fraud_amount")]
	public Entity.FraudAmount? FraudAmount { get; init; } = default!;

	/// <summary>
	/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
	/// </summary>
	[JsonPropertyName("audit_trail")]
	public Entity.BeaconAuditTrail AuditTrail { get; init; } = default!;

}
