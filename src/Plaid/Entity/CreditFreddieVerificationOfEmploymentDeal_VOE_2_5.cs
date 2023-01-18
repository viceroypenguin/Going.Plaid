namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a Verification of Employment report.</para>
/// </summary>
public record CreditFreddieVerificationOfEmploymentDeal_VOE_2_5
{
	/// <summary>
	/// <para>A collection of loans that are part of a single deal.</para>
	/// </summary>
	[JsonPropertyName("LOANS")]
	public Entity.CreditFreddieMacLoans_VOA_2_4 Loans { get; init; } = default!;

	/// <summary>
	/// <para>A collection of objects that define specific parties to a deal. This includes the direct participating parties, such as borrower and seller and the indirect parties such as the credit report provider.</para>
	/// </summary>
	[JsonPropertyName("PARTIES")]
	public Entity.CreditFreddieMacParties_VOA_2_4 Parties { get; init; } = default!;

	/// <summary>
	/// <para>A collection of objects that describe requests and responses for services.</para>
	/// </summary>
	[JsonPropertyName("SERVICES")]
	public Entity.CreditFreddieMacServices_VOE_2_5 Services { get; init; } = default!;
}