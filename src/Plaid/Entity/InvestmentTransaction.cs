using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a transaction in an investment account. Can contain cash transfers or security purchase or sales.
	/// </summary>
	public class InvestmentTransaction
	{
		/// <summary>
		/// The ID of the Investment transaction, unique across all Plaid transactions.
		/// </summary>
		[JsonPropertyName("investment_transaction_id")]
		public string InvestmentTransactionId { get; init; } = null!;

		/// <summary>
		/// The ID of the account against which this transaction posted.
		/// </summary>
		[JsonPropertyName("account_id")]
		public string AccountId { get; init; } = null!;

		/// <summary>
		/// The ID of the security to which this transaction is related.
		/// </summary>
		[JsonPropertyName("security_id")]
		public string? SecurityId { get; init; }

		/// <summary>
		/// The ISO-8601 posting date for the transaction, or transacted date for pending transactions.
		/// </summary>
		[JsonPropertyName("date")]
		public DateTime Date { get; init; }

		/// <summary>
		/// The Institution’s description of the transaction.
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; init; } = null!;

		/// <summary>
		/// The Amount of the security involved in this transaction.
		/// </summary>
		[JsonPropertyName("quantity")]
		public decimal Quantity { get; init; }

		/// <summary>
		/// The complete value of the transaction.Positive values when cash is debited, e.g.purchases of stock; negative values when cash is credited, e.g.sales of stock.Treatment remains the same for cash-only movements unassociated with securities.
		/// </summary>
		[JsonPropertyName("amount")]
		public decimal Amount { get; init; }

		/// <summary>
		/// The price of the security at which this transaction occurred.
		/// </summary>
		[JsonPropertyName("price")]
		public decimal Price { get; init; }

		/// <summary>
		/// The combined value of all fees applied to this transaction.
		/// </summary>
		[JsonPropertyName("fees")]
		public decimal? Fees { get; init; }

		/// <summary>
		/// Transaction Type
		/// </summary>
		[JsonPropertyName("type")]
		public InvestmentTransactionType TransactionType { get; init; }

		/// <summary>
		/// Transaction Sub-Type
		/// </summary>
		[JsonPropertyName("subtype")]
		public InvestmentTransactionSubType TransactionSubType { get; init; }

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
