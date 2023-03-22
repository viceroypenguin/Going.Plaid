namespace Going.Plaid.Item;

/// <summary>
/// <para>Describes a historical log of user consent events.</para>
/// </summary>
public record ItemActivityListResponse : ResponseBase
{
	/// <summary>
	/// <para>A list of activities.</para>
	/// </summary>
	[JsonPropertyName("activities")]
	public IReadOnlyList<Entity.Activity> Activities { get; init; } = default!;

	/// <summary>
	/// <para>An array of objects containing timestamps for the last time each data type was accessed per application.</para>
	/// </summary>
	[JsonPropertyName("last_data_access_times")]
	public IReadOnlyList<Entity.LastDataAccessTimes> LastDataAccessTimes { get; init; } = default!;

	/// <summary>
	/// <para>Cursor used for pagination.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string Cursor { get; init; } = default!;
}