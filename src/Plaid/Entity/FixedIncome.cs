namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the fixed income security.</para>
/// </summary>
public record FixedIncome
{
	/// <summary>
	/// <para>Details about a fixed income security's expected rate of return.</para>
	/// </summary>
	[JsonPropertyName("yield_rate")]
	public Entity.YieldRate? YieldRate { get; init; } = default!;

	/// <summary>
	/// <para>The maturity date for this fixed income security, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("maturity_date")]
	public DateOnly? MaturityDate { get; init; } = default!;

	/// <summary>
	/// <para>The issue date for this fixed income security, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("issue_date")]
	public DateOnly? IssueDate { get; init; } = default!;

	/// <summary>
	/// <para>The face value that is paid upon maturity of the fixed income security, per unit of security.</para>
	/// </summary>
	[JsonPropertyName("face_value")]
	public decimal? FaceValue { get; init; } = default!;

}
