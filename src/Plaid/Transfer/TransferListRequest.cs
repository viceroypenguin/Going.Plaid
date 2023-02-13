namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/list</c></para>
/// </summary>
public partial class TransferListRequest : RequestBase
{
	/// <summary>
	/// <para>The start datetime of transfers to list. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateTimeOffset? StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The end datetime of transfers to list. This should be in RFC 3339 format (i.e. <c>2019-12-06T22:35:49Z</c>)</para>
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

	/// <summary>
	/// <para>Filter transfers to only those originated through the specified origination account.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;

	/// <summary>
	/// <para>Filter transfers to only those with the specified originator client.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>Filter transfers to only those with the specified <c>funding_account_id</c>.</para>
	/// </summary>
	[JsonPropertyName("funding_account_id")]
	public string? FundingAccountId { get; set; } = default!;
}