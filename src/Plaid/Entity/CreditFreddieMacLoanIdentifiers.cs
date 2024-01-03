namespace Going.Plaid.Entity;

/// <summary>
/// <para>Collection of current and previous identifiers for this loan.</para>
/// </summary>
public record CreditFreddieMacLoanIdentifiers
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("LOAN_IDENTIFIER")]
	public IReadOnlyList<Entity.LoanIdentifier> LoanIdentifier { get; init; } = default!;

}
