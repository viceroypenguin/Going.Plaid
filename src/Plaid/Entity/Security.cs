namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains details about a security</para>
/// </summary>
public record Security
{
	/// <summary>
	/// <para>A unique, Plaid-specific identifier for the security, used to associate securities with holdings. Like all Plaid identifiers, the <c>security_id</c> is case sensitive. The <c>security_id</c> may change if inherent details of the security change due to a corporate action, for example, in the event of a ticker symbol change or CUSIP change.</para>
	/// </summary>
	[JsonPropertyName("security_id")]
	public string SecurityId { get; init; } = default!;

	/// <summary>
	/// <para>12-character ISIN, a globally unique securities identifier. A verified CUSIP Global Services license is required to receive this data. This field will be null by default for new customers, and null for existing customers starting March 12, 2024. If you would like access to this field, please start the verification process <a href="https://docs.google.com/forms/d/e/1FAIpQLSd9asHEYEfmf8fxJTHZTAfAzW4dugsnSu-HS2J51f1mxwd6Sw/viewform">here</a>.</para>
	/// </summary>
	[JsonPropertyName("isin")]
	public string? Isin { get; init; } = default!;

	/// <summary>
	/// <para>9-character CUSIP, an identifier assigned to North American securities. A verified CUSIP Global Services license is required to receive this data. This field will be null by default for new customers, and null for existing customers starting March 12, 2024. If you would like access to this field, please start the verification process <a href="https://docs.google.com/forms/d/e/1FAIpQLSd9asHEYEfmf8fxJTHZTAfAzW4dugsnSu-HS2J51f1mxwd6Sw/viewform">here</a>.</para>
	/// </summary>
	[JsonPropertyName("cusip")]
	public string? Cusip { get; init; } = default!;

	/// <summary>
	/// <para>7-character SEDOL, an identifier assigned to securities in the UK.</para>
	/// </summary>
	[JsonPropertyName("sedol")]
	public string? Sedol { get; init; } = default!;

	/// <summary>
	/// <para>An identifier given to the security by the institution</para>
	/// </summary>
	[JsonPropertyName("institution_security_id")]
	public string? InstitutionSecurityId { get; init; } = default!;

	/// <summary>
	/// <para>If <c>institution_security_id</c> is present, this field indicates the Plaid <c>institution_id</c> of the institution to whom the identifier belongs.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>In certain cases, Plaid will provide the ID of another security whose performance resembles this security, typically when the original security has low volume, or when a private security can be modeled with a publicly traded security.</para>
	/// </summary>
	[JsonPropertyName("proxy_security_id")]
	public string? ProxySecurityId { get; init; } = default!;

	/// <summary>
	/// <para>A descriptive name for the security, suitable for display.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.</para>
	/// </summary>
	[JsonPropertyName("ticker_symbol")]
	public string? TickerSymbol { get; init; } = default!;

	/// <summary>
	/// <para>Indicates that a security is a highly liquid asset and can be treated like cash.</para>
	/// </summary>
	[JsonPropertyName("is_cash_equivalent")]
	public bool? IsCashEquivalent { get; init; } = default!;

	/// <summary>
	/// <para>The security type of the holding.</para>
	/// <para>In rare instances, a null value is returned when institutional data is insufficient to determine the security type.</para>
	/// <para>Valid security types are:</para>
	/// <para><c>cash</c>: Cash, currency, and money market funds</para>
	/// <para><c>cryptocurrency</c>: Digital or virtual currencies</para>
	/// <para><c>derivative</c>: Options, warrants, and other derivative instruments</para>
	/// <para><c>equity</c>: Domestic and foreign equities</para>
	/// <para><c>etf</c>: Multi-asset exchange-traded investment funds</para>
	/// <para><c>fixed income</c>: Bonds and certificates of deposit (CDs)</para>
	/// <para><c>loan</c>: Loans and loan receivables</para>
	/// <para><c>mutual fund</c>: Open- and closed-end vehicles pooling funds of multiple investors</para>
	/// <para><c>other</c>: Unknown or other investment types</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;

	/// <summary>
	/// <para>Price of the security at the close of the previous trading session. Null for non-public securities.</para>
	/// <para>If the security is a foreign currency this field will be updated daily and will be priced in USD.</para>
	/// <para>If the security is a cryptocurrency, this field will be updated multiple times a day. As crypto prices can fluctuate quickly and data may become stale sooner than other asset classes, refer to <c>update_datetime</c> with the time when the price was last updated.</para>
	/// </summary>
	[JsonPropertyName("close_price")]
	public decimal? ClosePrice { get; init; } = default!;

	/// <summary>
	/// <para>Date for which <c>close_price</c> is accurate. Always <c>null</c> if <c>close_price</c> is <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("close_price_as_of")]
	public DateOnly? ClosePriceAsOf { get; init; } = default!;

	/// <summary>
	/// <para>Date and time at which <c>close_price</c> is accurate, in ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ). Always <c>null</c> if <c>close_price</c> is <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("update_datetime")]
	public DateTimeOffset? UpdateDatetime { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the price given. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the security. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-10383 Market Identifier Code of the exchange or market in which the security is being traded.</para>
	/// </summary>
	[JsonPropertyName("market_identifier_code")]
	public string? MarketIdentifierCode { get; init; } = default!;

	/// <summary>
	/// <para>The sector classification of the security, such as Finance, Health Technology, etc.</para>
	/// <para>For a complete list of possible values, please refer to the <a href="https://docs.google.com/spreadsheets/d/1L7aXUdqLhxgM8qe7hK67qqKXiUdQqILpwZ0LpxvCVnc">"Sectors and Industries" spreadsheet</a>.</para>
	/// </summary>
	[JsonPropertyName("sector")]
	public string? Sector { get; init; } = default!;

	/// <summary>
	/// <para>The industry classification of the security, such as Biotechnology, Airlines, etc.</para>
	/// <para>For a complete list of possible values, please refer to the <a href="https://docs.google.com/spreadsheets/d/1L7aXUdqLhxgM8qe7hK67qqKXiUdQqILpwZ0LpxvCVnc">"Sectors and Industries" spreadsheet</a>.</para>
	/// </summary>
	[JsonPropertyName("industry")]
	public string? Industry { get; init; } = default!;

	/// <summary>
	/// <para>Details about the option security.</para>
	/// <para>For the Sandbox environment, this data is currently only available if the item is using a custom configuration object, and the <c>ticker</c> field of the custom security follows the <a href="https://en.wikipedia.org/wiki/Option_symbol#The_OCC_Option_Symbol">OCC Option Symbol</a> standard with no spaces.</para>
	/// </summary>
	[JsonPropertyName("option_contract")]
	public Entity.OptionContract? OptionContract { get; init; } = default!;

}
