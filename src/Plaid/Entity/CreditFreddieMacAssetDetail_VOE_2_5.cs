namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about an asset.</para>
/// </summary>
public record CreditFreddieMacAssetDetail_VOE_2_5
{
	/// <summary>
	/// <para>A vendor created unique Identifier.</para>
	/// </summary>
	[JsonPropertyName("AssetUniqueIdentifier")]
	public string Assetuniqueidentifier { get; init; } = default!;

	/// <summary>
	/// <para>A unique alphanumeric string identifying an asset.</para>
	/// </summary>
	[JsonPropertyName("AssetAccountIdentifier")]
	public string Assetaccountidentifier { get; init; } = default!;

	/// <summary>
	/// <para>Account Report As of Date / Create Date. Format YYYY-MM-DD</para>
	/// </summary>
	[JsonPropertyName("AssetAsOfDate")]
	public DateOnly Assetasofdate { get; init; } = default!;

	/// <summary>
	/// <para>A text description that further defines the Asset. This could be used to describe the shares associated with the stocks, bonds or mutual funds, retirement funds or business owned that the borrower has disclosed (named) as an asset.</para>
	/// </summary>
	[JsonPropertyName("AssetDescription")]
	public string? Assetdescription { get; init; } = default!;

	/// <summary>
	/// <para>A value from a MISMO prescribed list that specifies financial assets in a mortgage loan transaction. Assets may be either liquid or fixed and are associated with a corresponding asset amount.</para>
	/// </summary>
	[JsonPropertyName("AssetType")]
	public Entity.AssetType Assettype { get; init; } = default!;

	/// <summary>
	/// <para>Additional Asset Decription some examples are Investment Tax-Deferred , Loan, 401K, 403B, Checking, Money Market, Credit Card,ROTH,529,Biller,ROLLOVER,CD,Savings,Investment Taxable, IRA, Mortgage, Line Of Credit.</para>
	/// </summary>
	[JsonPropertyName("AssetTypeAdditionalDescription")]
	public string? Assettypeadditionaldescription { get; init; } = default!;

	/// <summary>
	/// <para>The Number of days requested made to the Financial Institution. Example When looking for 3 months of data from the FI, pass in 90 days.</para>
	/// </summary>
	[JsonPropertyName("AssetDaysRequestedCount")]
	public int Assetdaysrequestedcount { get; init; } = default!;

	/// <summary>
	/// <para>Ownership type of the asset account.</para>
	/// </summary>
	[JsonPropertyName("AssetOwnershipType")]
	public string? Assetownershiptype { get; init; } = default!;
}