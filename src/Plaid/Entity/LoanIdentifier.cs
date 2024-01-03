namespace Going.Plaid.Entity;

/// <summary>
/// <para>The information used to identify this loan by various parties to the transaction or other organizations.</para>
/// </summary>
public record LoanIdentifier
{
	/// <summary>
	/// <para>The value of the identifier for the specified type.</para>
	/// </summary>
	[JsonPropertyName("LoanIdentifier")]
	public string? Loanidentifier { get; init; } = default!;

	/// <summary>
	/// <para>A value from a MISMO prescribed list that specifies the type of loan identifier.</para>
	/// </summary>
	[JsonPropertyName("LoanIdentifierType")]
	public Entity.LoanIdentifierType? Loanidentifiertype { get; init; } = default!;

}
