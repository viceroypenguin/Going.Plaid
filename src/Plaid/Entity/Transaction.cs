using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a banking transaction.
	/// </summary>
	/// <remarks>
	/// Transaction data is standardized across financial institutions, and in many cases transactions are linked to a clean name, entity type, location, and category. Similarly, account data is standardized and returned with a clean name, number, balance, and other meta information where available.
	/// </remarks>
	public class Transaction
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		[JsonPropertyName("name")]
		public string Name { get; init; } = null!;

		/// <summary>
		/// The unique ID of the transaction.
		/// </summary>
		[JsonPropertyName("transaction_id")]
		public string TransactionId { get; init; } = null!;

		/// <summary>
		/// The ID of the account in which this transaction occurred.
		/// </summary>
		[JsonPropertyName("account_id")]
		public string AccountId { get; init; } = null!;

		/// <summary>
		/// A hierarchical array of the categories to which this transaction belongs.
		/// </summary>
		[JsonPropertyName("category")]
		public string[]? Categories { get; init; }

		/// <summary>
		///The ID of the category to which this transaction belongs.
		/// </summary>
		[JsonPropertyName("category_id")]
		public string? CategoryId { get; init; }

		/// <summary>
		/// The channel used to make a payment. Possible values are: online, in store, other. This field will replace the transaction_type field.
		/// </summary>
		[JsonPropertyName("payment_channel")]
		public PaymentChannel PaymentChannel { get; init; }

		/// <summary>
		/// The settled dollar value. Positive values when money moves out of the account; negative values when money moves in. For example, purchases are positive; credit card payments, direct deposits, refunds are negative.
		/// </summary>
		[JsonPropertyName("amount")]
		public decimal Amount { get; init; }

		/// <summary>
		/// The ISO currency code of the transaction, either USD or CAD. Always <c>null</c> if unofficial_currency_code is non-<c>null</c>.
		/// </summary>
		[JsonPropertyName("iso_currency_code")]
		public string? IsoCurrencyCode { get; init; }

		/// <summary>
		/// The unofficial currency code associated with the transaction. Always <c>null</c> if iso_currency_code is non-<c>null</c>.
		/// </summary>
		[JsonPropertyName("unofficial_currency_code")]
		public string? UnofficialCurrencyCode { get; init; }

		/// <summary>
		/// Gets the currency code from either IsoCurrencyCode or UnofficialCurrencyCode. If non-null, IsoCurrencyCode is returned, else if non-null, UnofficialCurrencyCode, else null is returned.
		/// </summary>
		/// <value>Either available currency code.</value>
		public string? CurrencyCode => IsoCurrencyCode ?? UnofficialCurrencyCode ?? null;

		/// <summary>
		/// The date of the transaction.
		/// </summary>
		/// <remarks>For pending transactions, Plaid returns the date the transaction occurred; for posted transactions, Plaid returns the date the transaction posts.</remarks>
		[JsonPropertyName("date")]
		public DateTime Date { get; init; }

		/// <summary>
		/// The date that the transaction was authorized.
		/// </summary>
		[JsonPropertyName("authorized_date")]
		public DateTime? AuthorizedDate { get; init; }

		/// <summary>
		/// Gets or sets the information of the merchant's location. Typically <c>null</c>.
		/// </summary>
		[JsonPropertyName("location")]
		public LocationInfo? Location { get; init; }

		/// <summary>
		/// A value indicating whether this <see cref="Transaction"/> is pending or unsettled. Pending transaction details (<see cref="Name"/>, <see cref="PaymentChannel"/>, <see cref="Amount"/>) may change before they are settled.
		/// </summary>
		/// <value><c>true</c> if pending; otherwise, <c>false</c>.</value>
		[JsonPropertyName("pending")]
		public bool Pending { get; init; }

		/// <summary>
		/// The id of a posted transaction's associated pending transaction.
		/// </summary>
		[JsonPropertyName("pending_transaction_id")]
		public string? PendingTransactionId { get; init; }

		/// <summary>
		/// The name of the account owner. This property is not typically populated and only relevant when dealing with sub-accounts.
		/// </summary>
		[JsonPropertyName("account_owner")]
		public string? AccountOwner { get; init; }

		/// <summary>
		/// Represents a geographical location.
		/// </summary>
		public record LocationInfo : Address
		{
			/// <summary>
			/// Gets or sets the latitude (x-coordinate).
			/// </summary>
			/// <value>The latitude.</value>
			[JsonPropertyName("lat")]
			public decimal? Latitude { get; init; }

			/// <summary>
			/// Gets or sets the longitude (y-coordinate).
			/// </summary>
			/// <value>The longitude.</value>
			[JsonPropertyName("lon")]
			public decimal? Longitude { get; init; }

			/// <summary>
			/// The merchant defined store number where the transaction occurred.
			/// </summary>
			[JsonPropertyName("store_number")]
			public string? StoreNumber { get; init; }
		}
	}
}
