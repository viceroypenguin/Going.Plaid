using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Entity
{
    public class InvestmentTransaction
    {
        /// <summary>
        /// The ID of the Investment transaction, unique across all Plaid transactions.
        /// </summary>
        [JsonProperty("investment_transaction_id")]
        public string InvestmentTransactionId { get; set; }

        /// <summary>
        /// The ID of the account against which this transaction posted.
        /// </summary>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// The ID of the security to which this transaction is related.
        /// </summary>
        [JsonProperty("security_id")]
        public string SecurityId { get; set; }

        /// <summary>
        /// The ISO-8601 posting date for the transaction, or transacted date for pending transactions.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Institution’s description of the transaction.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The Amount of the security involved in this transaction.
        /// </summary>
        [JsonProperty("quantity")]
        public float Quantity { get; set; }

        /// <summary>
        /// The complete value of the transaction.Positive values when cash is debited, e.g.purchases of stock; negative values when cash is credited, e.g.sales of stock.Treatment remains the same for cash-only movements unassociated with securities.
        /// </summary>
        [JsonProperty("amount")]
        public float Amount { get; set; }

        /// <summary>
        /// The price of the security at which this transaction occurred.
        /// </summary>
        [JsonProperty("price")]
        public float Price { get; set; }

        /// <summary>
        /// The combined value of all fees applied to this transaction.
        /// </summary>
        [JsonProperty("fees")]
        public float? Fees { get; set; }

        /// <summary>
        /// Transaction Type
        /// </summary>
        [JsonProperty("type")]
        public InvestmentTransactionType TransactionType { get; set; }

        /// <summary>
        /// Transaction Sub-Type
        /// </summary>
        [JsonProperty("subtype")]
        public InvestmentTransactionSubType TransactionSubType { get; set; }

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
