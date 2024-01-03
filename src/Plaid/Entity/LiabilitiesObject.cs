namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing liability accounts</para>
/// </summary>
public record LiabilitiesObject
{
	/// <summary>
	/// <para>The credit accounts returned.</para>
	/// </summary>
	[JsonPropertyName("credit")]
	public IReadOnlyList<Entity.CreditCardLiability>? Credit { get; init; } = default!;

	/// <summary>
	/// <para>The mortgage accounts returned.</para>
	/// </summary>
	[JsonPropertyName("mortgage")]
	public IReadOnlyList<Entity.MortgageLiability>? Mortgage { get; init; } = default!;

	/// <summary>
	/// <para>The student loan accounts returned.</para>
	/// </summary>
	[JsonPropertyName("student")]
	public IReadOnlyList<Entity.StudentLoan>? Student { get; init; } = default!;

}
