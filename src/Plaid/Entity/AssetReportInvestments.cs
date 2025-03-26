namespace Going.Plaid.Entity;

/// <summary>
/// <para>A set of fields describing the investments data on an account.</para>
/// </summary>
public record AssetReportInvestments
{
	/// <summary>
	/// <para>Quantities and values of securities held in the investment account. Map to the <c>securities</c> array for security details.</para>
	/// </summary>
	[JsonPropertyName("holdings")]
	public IReadOnlyList<Entity.AssetReportInvestmentHolding>? Holdings { get; init; } = default!;

	/// <summary>
	/// <para>Details of specific securities held in on the investment account.</para>
	/// </summary>
	[JsonPropertyName("securities")]
	public IReadOnlyList<Entity.AssetReportInvestmentSecurity>? Securities { get; init; } = default!;

	/// <summary>
	/// <para>Transaction history on the investment account.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.AssetReportInvestmentTransaction>? Transactions { get; init; } = default!;

}
