namespace Going.Plaid.Entity;

/// <summary>
/// <para>A collection of loans that are part of a single deal.</para>
/// </summary>
public record CreditFreddieMacLoans
{
	/// <summary>
	/// <para>Information specific to a mortgage loan agreement between one or more borrowers and a mortgage lender.</para>
	/// </summary>
	[JsonPropertyName("LOAN")]
	public Entity.CreditFreddieMacLoan Loan { get; init; } = default!;

}
