namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying how the <c>address</c> field matched.</para>
/// </summary>
public record KYCCheckAddressSummary
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("summary")]
	public Entity.MatchSummaryCode Summary { get; init; } = default!;

	/// <summary>
	/// <para>Field describing whether the associated address is a post office box. Will be <c>yes</c> when a P.O. box is detected, <c>no</c> when Plaid confirmed the address is not a P.O. box, and <c>no_data</c> when Plaid was not able to determine if the address is a P.O. box.</para>
	/// </summary>
	[JsonPropertyName("po_box")]
	public Entity.POBoxStatus PoBox { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.AddressPurposeLabel Type { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("street")]
	public Entity.MatchSummaryCode? Street { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("city")]
	public Entity.MatchSummaryCode? City { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("region")]
	public Entity.MatchSummaryCode? Region { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("postal_code")]
	public Entity.MatchSummaryCode? PostalCode { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying how the <c>address</c> field matched for fields that are only present on an international KYC check.</para>
	/// </summary>
	[JsonPropertyName("international_details")]
	public Entity.KYCCheckDetailsInternationalAddress? InternationalDetails { get; init; } = default!;

}
