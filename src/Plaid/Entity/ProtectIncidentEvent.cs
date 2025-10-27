namespace Going.Plaid.Entity;

/// <summary>
/// <para>details about the incident event.</para>
/// </summary>
public class ProtectIncidentEvent
{
	/// <summary>
	/// <para>A globally unique identifier representing a Protect event that may be associated with this incident.</para>
	/// </summary>
	[JsonPropertyName("protect_event_id")]
	public string? ProtectEventId { get; set; } = default!;

	/// <summary>
	/// <para>A unique identifier for a Link session that may be associated with this incident.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string? LinkSessionId { get; set; } = default!;

	/// <summary>
	/// <para>A unique identifier for an Identity Verification session that may be associated with this incident.</para>
	/// </summary>
	[JsonPropertyName("idv_session_id")]
	public string? IdvSessionId { get; set; } = default!;

	/// <summary>
	/// <para>The unique ID used to refer to a Signal transaction evaluation that may be associated with this incident.</para>
	/// </summary>
	[JsonPropertyName("signal_client_transaction_id")]
	public string? SignalClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID representing the incident in your system. Personally identifiable information, such as an email address or phone number, should not be used in this field.</para>
	/// </summary>
	[JsonPropertyName("internal_reference")]
	public string? InternalReference { get; set; } = default!;

	/// <summary>
	/// <para>The timestamp when the incident occurred, in ISO 8601 format (e.g., '2020-07-24T03:26:02Z').</para>
	/// </summary>
	[JsonPropertyName("time")]
	public DateTimeOffset? Time { get; set; } = default!;

	/// <summary>
	/// <para>The monetary amount associated with the incident.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.ProtectIncidentAmount? Amount { get; set; } = default!;

	/// <summary>
	/// <para>An access token associated with the Item related to this incident.</para>
	/// </summary>
	[JsonPropertyName("access_token")]
	public string? AccessToken { get; set; } = default!;

}
