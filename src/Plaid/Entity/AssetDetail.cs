namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about an asset.</para>
/// </summary>
public record AssetDetail
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
	/// <para>Asset Account Available Balance.</para>
	/// </summary>
	[JsonPropertyName("AssetAvailableBalanceAmount")]
	public decimal Assetavailablebalanceamount { get; init; } = default!;

	/// <summary>
	/// <para>A vendor created unique Identifier</para>
	/// </summary>
	[JsonPropertyName("AssetCurrentBalanceAmount")]
	public decimal Assetcurrentbalanceamount { get; init; } = default!;

	/// <summary>
	/// <para>Total market value of holdings (non-restricted, vested, not crypto, not other, not cash) Note: Any employer stock plan balance must be excluded from the total account balance (identification is 'stock plan')</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingBalanceAmount")]
	public decimal? Assetholdingbalanceamount { get; init; } = default!;

	/// <summary>
	/// <para>HoldingsBalance net MarginAmount</para>
	/// </summary>
	[JsonPropertyName("AssetHoldingBalanceNetMarginAmount")]
	public decimal? Assetholdingbalancenetmarginamount { get; init; } = default!;

	/// <summary>
	/// <para>Total market value of all bonds held (non-restricted, vested)</para>
	/// </summary>
	[JsonPropertyName("AssetBondsBalanceAmount")]
	public decimal? Assetbondsbalanceamount { get; init; } = default!;

	/// <summary>
	/// <para>Total market value of all stocks held (non-restricted, vested, not employer sponsored stock plan)</para>
	/// </summary>
	[JsonPropertyName("AssetStocksBalanceAmount")]
	public decimal? Assetstocksbalanceamount { get; init; } = default!;

	/// <summary>
	/// <para>Total balance of all cryptocurrency held (non-restricted, vested)</para>
	/// </summary>
	[JsonPropertyName("AssetCryptoBalanceAmount")]
	public decimal? Assetcryptobalanceamount { get; init; } = default!;

	/// <summary>
	/// <para>Total balance of all other holding types (non-restricted, vested)</para>
	/// </summary>
	[JsonPropertyName("AssetOtherBalanceAmount")]
	public decimal? Assetotherbalanceamount { get; init; } = default!;

	/// <summary>
	/// <para>loan balance (amount owed by account owner)</para>
	/// </summary>
	[JsonPropertyName("AssetMarginAmountBalance")]
	public decimal? Assetmarginamountbalance { get; init; } = default!;

	/// <summary>
	/// <para>amount available for cash withdrawal</para>
	/// </summary>
	[JsonPropertyName("AssetAvailableCashBalanceAmount")]
	public decimal? Assetavailablecashbalanceamount { get; init; } = default!;

	/// <summary>
	/// <para>cash balance of the account</para>
	/// </summary>
	[JsonPropertyName("AssetCashBalanceAmount")]
	public decimal? Assetcashbalanceamount { get; init; } = default!;

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

	/// <summary>
	/// <para>Whether or not the account is a retirement account (e.g., 401K, 403b, 457, thrift savings plans, traditional and Roth, IRAs, SEP-IRA, SIMPLE-IRA, KEOGH, state retirement savings plans, other independent and IRS-qualified employer retirement plans)</para>
	/// </summary>
	[JsonPropertyName("AssetRetirementIndicator")]
	public Entity.AssetDetailAssetretirementindicatorEnum? Assetretirementindicator { get; init; } = default!;

	/// <summary>
	/// <para>Whether the account is employer sponsored retirement account or not (e.g., 401K, 403b, 457, thrift savings plan)</para>
	/// </summary>
	[JsonPropertyName("AssetEmployerSponsoredIndicator")]
	public Entity.AssetDetailAssetemployersponsoredindicatorEnum? Assetemployersponsoredindicator { get; init; } = default!;

}
