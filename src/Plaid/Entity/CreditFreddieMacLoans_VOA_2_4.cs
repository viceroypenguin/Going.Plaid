namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of loans that are part of a single deal.</para>
/// </summary>
public record CreditFreddieMacLoans_VOA_2_4
{
	/// <summary>
	/// <para>Information specific to a mortgage loan agreement between one or more borrowers and a mortgage lender.</para>
	/// </summary>
	[JsonPropertyName("LOAN")]
	public Entity.CreditFreddieMacLoan_VOA_2_4 Loan { get; init; } = default!;
}