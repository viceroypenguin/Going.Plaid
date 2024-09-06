namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying how the <c>address</c> field matched for fields that are only present on an international KYC check.</para>
/// </summary>
public record KYCCheckDetailsInternationalAddress
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("building")]
	public Entity.MatchSummaryCode Building { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("county")]
	public Entity.MatchSummaryCode County { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("district")]
	public Entity.MatchSummaryCode District { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("house_number")]
	public Entity.MatchSummaryCode HouseNumber { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("subpremise")]
	public Entity.MatchSummaryCode Subpremise { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("thoroughfare")]
	public Entity.MatchSummaryCode Thoroughfare { get; init; } = default!;

}
