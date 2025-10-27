namespace Going.Plaid.Entity;

/// <summary>
/// <para>Investment security associated with the account.</para>
/// </summary>
public record BaseReportInvestmentSecurity
{
	/// <summary>
	/// <para>A unique, Plaid-specific identifier for the security, used to associate securities with holdings. Like all Plaid identifiers, the <c>security_id</c> is case sensitive. The <c>security_id</c> may change if inherent details of the security change due to a corporate action, for example, in the event of a ticker symbol change or CUSIP change.</para>
	/// </summary>
	[JsonPropertyName("security_id")]
	public string SecurityId { get; init; } = default!;

	/// <summary>
	/// <para>A descriptive name for the security, suitable for display.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

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
	/// <para>An identifier given to the security by the institution.</para>
	/// </summary>
	[JsonPropertyName("institution_security_id")]
	public string? InstitutionSecurityId { get; init; } = default!;

	/// <summary>
	/// <para>If <c>institution_security_id</c> is present, this field indicates the Plaid <c>institution_id</c> of the institution to whom the identifier belongs.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.</para>
	/// </summary>
	[JsonPropertyName("ticker_symbol")]
	public string? TickerSymbol { get; init; } = default!;

	/// <summary>
	/// <para>The security type of the holding. Valid security types are:</para>
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

}
