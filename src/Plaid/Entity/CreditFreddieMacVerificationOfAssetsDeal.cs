namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an Asset Report with Freddie Mac schema.</para>
/// </summary>
public record CreditFreddieMacVerificationOfAssetsDeal
{
	/// <summary>
	/// <para>A collection of loans that are part of a single deal.</para>
	/// </summary>
	[JsonPropertyName("LOANS")]
	public Entity.CreditFreddieMacLoans Loans { get; init; } = default!;

	/// <summary>
	/// <para>A collection of objects that define specific parties to a deal. This includes the direct participating parties, such as borrower and seller and the indirect parties such as the credit report provider.</para>
	/// </summary>
	[JsonPropertyName("PARTIES")]
	public Entity.CreditFreddieMacParties Parties { get; init; } = default!;

	/// <summary>
	/// <para>A collection of objects that describe requests and responses for services.</para>
	/// </summary>
	[JsonPropertyName("SERVICES")]
	public Entity.CreditFreddieMacServices Services { get; init; } = default!;
}