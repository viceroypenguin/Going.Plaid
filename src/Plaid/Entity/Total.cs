namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing both the current pay period and year to date amount for a category.</para>
/// </summary>
public record Total
{
	/// <summary>
	/// <para>Commonly used term to describe the line item.</para>
	/// </summary>
	[JsonPropertyName("canonical_description")]
	public Entity.TotalCanonicalDescription? CanonicalDescription { get; init; } = default!;

	/// <summary>
	/// <para>Text of the line item as printed on the paystub.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a monetary amount.</para>
	/// </summary>
	[JsonPropertyName("current_pay")]
	public Entity.Pay? CurrentPay { get; init; } = default!;

	/// <summary>
	/// <para>An object representing a monetary amount.</para>
	/// </summary>
	[JsonPropertyName("ytd_pay")]
	public Entity.Pay? YtdPay { get; init; } = default!;
}