namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of information about a single party to a transaction. Included direct participants like the borrower and seller as well as indirect participants such as the flood certificate provider.</para>
/// </summary>
public record CreditFreddieMacParty
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("INDIVIDUAL")]
	public Entity.CreditFreddieMacPartyIndividual Individual { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ROLES")]
	public Entity.Roles Roles { get; init; } = default!;

	/// <summary>
	/// <para>The collection of TAXPAYER_IDENTIFICATION elements</para>
	/// </summary>
	[JsonPropertyName("TAXPAYER_IDENTIFIERS")]
	public Entity.TaxpayerIdentifiers TaxpayerIdentifiers { get; init; } = default!;
}