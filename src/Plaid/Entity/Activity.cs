namespace Going.Plaid.Entity;

/// <summary>
/// <para>Describes a consent activity.</para>
/// </summary>
public record Activity
{
	/// <summary>
	/// <para>Types of consent activities</para>
	/// </summary>
	[JsonPropertyName("activity")]
	public Entity.ActivityType ActivityType { get; init; } = default!;

	/// <summary>
	/// <para>The date this activity was initiated <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format in UTC.</para>
	/// </summary>
	[JsonPropertyName("initiated_date")]
	public DateOnly InitiatedDate { get; init; } = default!;

	/// <summary>
	/// <para>A unique identifier for the activity</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>Application ID of the client who initiated the activity.</para>
	/// </summary>
	[JsonPropertyName("initiator")]
	public string Initiator { get; init; } = default!;

	/// <summary>
	/// <para>Enum representing the state of the action/activity.</para>
	/// </summary>
	[JsonPropertyName("state")]
	public Entity.ActionState State { get; init; } = default!;

	/// <summary>
	/// <para>This field will map to the application ID that is returned from /item/applications/list, or provided to the institution in an oauth redirect.</para>
	/// </summary>
	[JsonPropertyName("target_application_id")]
	public string? TargetApplicationId { get; init; } = default!;

	/// <summary>
	/// <para>The scopes object</para>
	/// </summary>
	[JsonPropertyName("scopes")]
	public Entity.Scopes? Scopes { get; init; } = default!;
}