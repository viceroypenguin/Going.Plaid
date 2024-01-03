namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information specific to a mortgage loan agreement between one or more borrowers and a mortgage lender.</para>
/// </summary>
public record CreditFreddieMacLoan
{
	/// <summary>
	/// <para>Collection of current and previous identifiers for this loan.</para>
	/// </summary>
	[JsonPropertyName("LOAN_IDENTIFIERS")]
	public Entity.CreditFreddieMacLoanIdentifiers LoanIdentifiers { get; init; } = default!;

	/// <summary>
	/// <para>Type of loan. The value can only be "SubjectLoan"</para>
	/// </summary>
	[JsonPropertyName("LoanRoleType")]
	public string Loanroletype { get; init; } = default!;

}
