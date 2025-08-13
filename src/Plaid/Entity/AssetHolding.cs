namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record AssetHolding
{
	/// <summary>
	/// <para>Unique id of investment position</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingID")]
	public string? Assetholdingid { get; init; } = default!;

	/// <summary>
	/// <para>US Dollar</para>
	/// </summary>
	[JsonPropertyName("Currency")]
	public string? Currency { get; init; } = default!;

	/// <summary>
	/// <para>Description of holding</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingDescription")]
	public string? Assetholdingdescription { get; init; } = default!;

	/// <summary>
	/// <para>Investment position's market ticker symbol</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingSymbol")]
	public string? Assetholdingsymbol { get; init; } = default!;

	/// <summary>
	/// <para>Security name of investment holding</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingSecurityName")]
	public string? Assetholdingsecurityname { get; init; } = default!;

	/// <summary>
	/// <para>Number of units of holding</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingUnits")]
	public decimal? Assetholdingunits { get; init; } = default!;

	/// <summary>
	/// <para>market value of investment position</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingMarketValueAmount")]
	public decimal? Assetholdingmarketvalueamount { get; init; } = default!;

	/// <summary>
	/// <para>current price of investment holding</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingCurrentPriceAmount")]
	public decimal? Assetholdingcurrentpriceamount { get; init; } = default!;

	/// <summary>
	/// <para>Type of holding (e.g. bond, stock, crypto, other)</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingType")]
	public Entity.AssetHoldingAssetholdingtypeEnum? Assetholdingtype { get; init; } = default!;

	/// <summary>
	/// <para>Whether or not the stock is restricted, i.e. "Restricted" or "Not Restricted"</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingRestrictedIndicator")]
	public Entity.AssetHoldingAssetholdingrestrictedindicatorEnum? Assetholdingrestrictedindicator { get; init; } = default!;

	/// <summary>
	/// <para>Amount of holding vested</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingVestedAmount")]
	public decimal? Assetholdingvestedamount { get; init; } = default!;

}
