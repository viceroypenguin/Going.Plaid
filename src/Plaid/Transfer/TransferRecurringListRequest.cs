namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/recurring/list</c></para>
/// </summary>
public partial class TransferRecurringListRequest : RequestBase
{
	/// <summary>
	/// <para>The start datetime of recurring transfers to list. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateTimeOffset? StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The end datetime of recurring transfers to list. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateTimeOffset? EndDate { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of transfers to return.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of transfers to skip before returning results.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int Offset { get; set; } = default!;
}