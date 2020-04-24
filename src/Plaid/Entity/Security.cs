using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acklann.Plaid.Entity
{
    public class Security
    {
        /// <summary>
        /// A unique Plaid identifier for the holding.
        /// </summary>
        [JsonProperty("security_id")]
        public string SecurityId { get; set; }

        /// <summary>
        /// 12-character ISIN, a globally unique securities identifier. Will be present when either CUSIP or SEDOL are present.
        /// </summary>
        [JsonProperty("isin")]
        public string Isin { get; set; }

        /// <summary>
        /// 7-character SEDOL, an identifier assigned to securities in the UK.
        /// </summary>
        [JsonProperty("sedol")]
        public string Sedol { get; set; }

        /// <summary>
        /// 9-character CUSIP, an identifier assigned to North American securities.
        /// </summary>
        [JsonProperty("cusip")]
        public string Cusip { get; set; }

        /// <summary>
        /// An identifier that is meaningful within the institution’s own schema.
        /// </summary>
        [JsonProperty("institution_security_id")]
        public string InstitutionSecurityId { get; set; }

        /// <summary>
        /// If institution_security_id is present, this field indicates the Plaid institution_id of the institution referenced.
        /// </summary>
        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// In certain cases, Plaid will provide the ID of another security whose performance resembles this security—typically when the original security has low volume, or when a private security can be modeled with a publicly traded security.
        /// </summary>
        [JsonProperty("proxy_security_id")]
        public string ProxySecurityId { get; set; }

        /// <summary>
        /// The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.
        /// </summary>
        [JsonProperty("ticker_symbol")]
        public string TickerSymbol { get; set; }

        /// <summary>
        /// A descriptive name for the security, suitable for display.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Indicates that a security is a highly liquid asset, and can be treated as cash.
        /// </summary>
        [JsonProperty("is_cash_equivalent")]
        public bool IsCashEquivalent { get; set; }

        /// <summary>
        /// The security type of the holding. 
        /// </summary>
        [JsonProperty("type")]
        public SecurityType Type { get; set; }

        /// <summary>
        /// Price of the security at the close of the previous trading session. null for non-public securities.
        /// </summary>
        [JsonProperty("close_price")]
        public float? ClosePrice { get; set; }

        /// <summary>
        /// Date for which close_price is accurate. Always null if close_price_as_of is null.
        /// </summary>
        [JsonProperty("close_price_as_of")]
        public DateTime? ClosePriceAsOf { get; set; }

        /// <summary>
        /// The ISO-4217 currency code of the holding. Always null if unofficial_currency_code is non-null.
        /// </summary>
        [JsonProperty("iso_currency_code")]
        public string IsoCurrencyCode { get; set; }

        /// <summary>
        /// The unofficial currency of the holding. Always null if iso_currency_code is non-null. This is present if the price is denominated in an unrecognized currency e.g. Bitcoin, rewards points.
        /// </summary>
        [JsonProperty("unofficial_currency_code")]
        public string UnofficialCurrencyCode { get; set; }

        /// <summary>
        /// Gets the currency code from either IsoCurrencyCode or UnofficialCurrencyCode. If non-null, IsoCurrencyCode is returned, else if non-null, UnofficialCurrencyCode, else null is returned.
        /// </summary>
        /// <value>Either available currency code.</value>
        public string CurrencyCode => IsoCurrencyCode ?? UnofficialCurrencyCode;
    }
}
