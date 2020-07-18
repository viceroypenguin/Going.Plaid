using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Entity
{
    public class Holding
    {
        /// <summary>
        ///  The Plaid Account ID associated with the holding.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// The Plaid Security ID of the security associated with the holding.
        /// </summary>
        [JsonProperty("security_id")]
        public string SecurityId { get; set; }

        /// <summary>
        /// The last price given by the institution for this security.
        /// </summary>
        [JsonProperty("institution_price")]
        public float InstitutionPrice { get; set; }

        /// <summary>
        /// The date at which institution_price was current.
        /// </summary>
        [JsonProperty("institution_price_as_of")]
        public DateTime? InstitutionPriceAsOf { get; set; }

        /// <summary>
        /// The value of the holding, as stated by the institution.
        /// </summary>
        [JsonProperty("institution_value")]
        public float InstitutionValue { get; set; }

        /// <summary>
        /// The total cost of acquiring the holding.
        /// </summary>
        [JsonProperty("cost_basis")]
        public float? CostBasis { get; set; }

        /// <summary>
        /// The total quantity of the asset held, as reported by the financial institution.
        /// </summary>
        [JsonProperty("quantity")]
        public float Quantity { get; set; }

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
