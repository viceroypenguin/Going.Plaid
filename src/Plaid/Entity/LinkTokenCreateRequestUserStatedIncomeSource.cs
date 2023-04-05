namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies user stated income sources for the Income product</para>
/// </summary>
public class LinkTokenCreateRequestUserStatedIncomeSource
{
	/// <summary>
	/// <para>The employer corresponding to an income source specified by the user</para>
	/// </summary>
	[JsonPropertyName("employer")]
	public string? Employer { get; set; } = default!;

	/// <summary>
	/// <para>The income category for a specified income source</para>
	/// </summary>
	[JsonPropertyName("category")]
	public Entity.UserStatedIncomeSourceCategory? Category { get; set; } = default!;

	/// <summary>
	/// <para>The income amount paid per cycle for a specified income source</para>
	/// </summary>
	[JsonPropertyName("pay_per_cycle")]
	public decimal? PayPerCycle { get; set; } = default!;

	/// <summary>
	/// <para>The income amount paid annually for a specified income source</para>
	/// </summary>
	[JsonPropertyName("pay_annual")]
	public decimal? PayAnnual { get; set; } = default!;

	/// <summary>
	/// <para>The pay type - <c>GROSS</c>, <c>NET</c>, or <c>UNKNOWN</c> for a specified income source</para>
	/// </summary>
	[JsonPropertyName("pay_type")]
	public Entity.UserStatedIncomeSourcePayType? PayType { get; set; } = default!;

	/// <summary>
	/// <para>The pay frequency of a specified income source</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public Entity.UserStatedIncomeSourceFrequency? PayFrequency { get; set; } = default!;
}