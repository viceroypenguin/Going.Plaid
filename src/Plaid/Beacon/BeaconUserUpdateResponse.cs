namespace Going.Plaid.Beacon;

/// <summary>
/// <para>A Beacon User represents an end user that has been scanned against the Beacon Network.</para>
/// </summary>
public record BeaconUserUpdateResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp. This field indicates the last time the resource was modified.</para>
	/// </summary>
	[JsonPropertyName("updated_at")]
	public DateTimeOffset UpdatedAt { get; init; } = default!;

	/// <summary>
	/// <para>A status of a Beacon User.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.BeaconUserStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>ID of the associated Beacon Program.</para>
	/// </summary>
	[JsonPropertyName("program_id")]
	public string ProgramId { get; init; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; init; } = default!;

	/// <summary>
	/// <para>A Beacon User's data and resulting analysis when checked against duplicate records and the Beacon Fraud Network.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.BeaconUserData User { get; init; } = default!;

	/// <summary>
	/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
	/// </summary>
	[JsonPropertyName("audit_trail")]
	public Entity.BeaconAuditTrail AuditTrail { get; init; } = default!;

}
