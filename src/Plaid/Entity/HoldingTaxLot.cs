namespace Going.Plaid.Entity;

/// <summary>
/// <para>A single acquisition lot within a holding.</para>
/// </summary>
public record HoldingTaxLot
{
	/// <summary>
	/// <para>The financial institution's identifier for this lot. Null if the institution does not provide a lot identifier.</para>
	/// </summary>
	[JsonPropertyName("institution_lot_id")]
	public string? InstitutionLotId { get; init; } = default!;

	/// <summary>
	/// <para>The date and time this lot was acquired, in ISO 8601 format. Null if the institution does not provide acquisition datetime data.</para>
	/// </summary>
	[JsonPropertyName("original_purchase_datetime")]
	public DateTimeOffset? OriginalPurchaseDatetime { get; init; } = default!;

	/// <summary>
	/// <para>The number of units of the security in this lot.</para>
	/// </summary>
	[JsonPropertyName("quantity")]
	public decimal? Quantity { get; init; } = default!;

	/// <summary>
	/// <para>The price per unit of the security at the time this lot was acquired.</para>
	/// </summary>
	[JsonPropertyName("purchase_price")]
	public decimal? PurchasePrice { get; init; } = default!;

	/// <summary>
	/// <para>The total cost basis of this lot, inclusive of any fees.</para>
	/// </summary>
	[JsonPropertyName("cost_basis")]
	public decimal? CostBasis { get; init; } = default!;

	/// <summary>
	/// <para>The current market value of this lot.</para>
	/// </summary>
	[JsonPropertyName("current_value")]
	public decimal? CurrentValue { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether a holding lot position is long or short. Possible values are <c>LONG</c> and <c>SHORT</c>.</para>
	/// </summary>
	[JsonPropertyName("position_type")]
	public Entity.HoldingTaxLotPositionType? PositionType { get; init; } = default!;

}
