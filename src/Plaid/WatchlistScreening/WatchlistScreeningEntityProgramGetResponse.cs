namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>A program that configures the active lists, search parameters, and other behavior for initial and ongoing screening of entities.</para>
/// </summary>
public record WatchlistScreeningEntityProgramGetResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated entity program.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>Indicator specifying whether the program is enabled and will perform daily rescans.</para>
	/// </summary>
	[JsonPropertyName("is_rescanning_enabled")]
	public bool IsRescanningEnabled { get; init; } = default!;

	/// <summary>
	/// <para>Watchlists enabled for the associated program</para>
	/// </summary>
	[JsonPropertyName("lists_enabled")]
	public IReadOnlyList<Entity.EntityWatchlistCode> ListsEnabled { get; init; } = default!;

	/// <summary>
	/// <para>A name for the entity program to define its purpose. For example, "High Risk Organizations" or "Applicants".</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The valid name matching sensitivity configurations for a screening program. Note that while certain matching techniques may be more prevalent on less strict settings, all matching algorithms are enabled for every sensitivity.</para>
	/// </summary>
	[JsonPropertyName("name_sensitivity")]
	public Entity.ProgramNameSensitivity NameSensitivity { get; init; } = default!;

	/// <summary>
	/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
	/// </summary>
	[JsonPropertyName("audit_trail")]
	public Entity.WatchlistScreeningAuditTrail AuditTrail { get; init; } = default!;

	/// <summary>
	/// <para>Archived programs are read-only and cannot screen new customers nor participate in ongoing monitoring.</para>
	/// </summary>
	[JsonPropertyName("is_archived")]
	public bool IsArchived { get; init; } = default!;

}
