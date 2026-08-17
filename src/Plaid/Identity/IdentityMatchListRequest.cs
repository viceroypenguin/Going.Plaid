namespace Going.Plaid.Identity;

/// <summary>
/// <para>IdentityMatchListRequest defines the request schema for <c>/identity/match/list</c></para>
/// </summary>
public partial class IdentityMatchListRequest : RequestBase
{
	/// <summary>
	/// <para>Inclusive start of the query window in RFC 3339 format.</para>
	/// </summary>
	[JsonPropertyName("start_time")]
	public DateTimeOffset StartTime { get; set; } = default!;

	/// <summary>
	/// <para>Inclusive end of the query window in RFC 3339 format.</para>
	/// </summary>
	[JsonPropertyName("end_time")]
	public DateTimeOffset EndTime { get; set; } = default!;

	/// <summary>
	/// <para>Maximum number of attempts to return in one page.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>Opaque pagination cursor. Omit on the first request. For subsequent requests, set this field to the <c>next_cursor</c> from the previous response and use the same <c>start_time</c> and <c>end_time</c>.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

}
