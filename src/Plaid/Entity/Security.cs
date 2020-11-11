using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a security that may be held or traded in an investment account.
	/// </summary>
	public class Security
	{
		/// <summary>
		/// A unique Plaid identifier for the holding.
		/// </summary>
		[JsonPropertyName("security_id")]
		public string SecurityId { get; init; } = null!;

		/// <summary>
		/// 12-character ISIN, a globally unique securities identifier. Will be present when either CUSIP or SEDOL are present.
		/// </summary>
		[JsonPropertyName("isin")]
		public string? Isin { get; init; }

		/// <summary>
		/// 7-character SEDOL, an identifier assigned to securities in the UK.
		/// </summary>
		[JsonPropertyName("sedol")]
		public string? Sedol { get; init; }

		/// <summary>
		/// 9-character CUSIP, an identifier assigned to North American securities.
		/// </summary>
		[JsonPropertyName("cusip")]
		public string? Cusip { get; init; }

		/// <summary>
		/// An identifier that is meaningful within the institution’s own schema.
		/// </summary>
		[JsonPropertyName("institution_security_id")]
		public string? InstitutionSecurityId { get; init; }

		/// <summary>
		/// If institution_security_id is present, this field indicates the Plaid institution_id of the institution referenced.
		/// </summary>
		[JsonPropertyName("institution_id")]
		public string? InstitutionId { get; init; }

		/// <summary>
		/// In certain cases, Plaid will provide the ID of another security whose performance resembles this security—typically when the original security has low volume, or when a private security can be modeled with a publicly traded security.
		/// </summary>
		[JsonPropertyName("proxy_security_id")]
		public string? ProxySecurityId { get; init; }

		/// <summary>
		/// The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.
		/// </summary>
		[JsonPropertyName("ticker_symbol")]
		public string? TickerSymbol { get; init; }

		/// <summary>
		/// A descriptive name for the security, suitable for display.
		/// </summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		/// <summary>
		/// Indicates that a security is a highly liquid asset, and can be treated as cash.
		/// </summary>
		[JsonPropertyName("is_cash_equivalent")]
		public bool IsCashEquivalent { get; init; }

		/// <summary>
		/// The security type of the holding. 
		/// </summary>
		[JsonPropertyName("type")]
		public SecurityType Type { get; init; }

		/// <summary>
		/// Price of the security at the close of the previous trading session. null for non-public securities.
		/// </summary>
		[JsonPropertyName("close_price")]
		public decimal? ClosePrice { get; init; }

		/// <summary>
		/// Date for which close_price is accurate. Always <c>null</c> if <see cref="ClosePrice"/> is <c>null</c>.
		/// </summary>
		[JsonPropertyName("close_price_as_of")]
		public DateTime? ClosePriceAsOf { get; init; }

		/// <summary>
		/// The ISO-4217 currency code of the holding. Always null if unofficial_currency_code is non-null.
		/// </summary>
		[JsonPropertyName("iso_currency_code")]
		public string? IsoCurrencyCode { get; init; }

		/// <summary>
		/// The unofficial currency of the holding. Always null if iso_currency_code is non-null. This is present if the price is denominated in an unrecognized currency e.g. Bitcoin, rewards points.
		/// </summary>
		[JsonPropertyName("unofficial_currency_code")]
		public string? UnofficialCurrencyCode { get; init; }

		/// <summary>
		/// Gets the currency code from either IsoCurrencyCode or UnofficialCurrencyCode. If non-null, IsoCurrencyCode is returned, else if non-null, UnofficialCurrencyCode, else null is returned.
		/// </summary>
		/// <value>Either available currency code.</value>
		public string? CurrencyCode => IsoCurrencyCode ?? UnofficialCurrencyCode;
	}
}
