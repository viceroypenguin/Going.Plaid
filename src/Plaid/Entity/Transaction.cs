using Newtonsoft.Json;
using System;

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
		[JsonProperty("name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The unique ID of the transaction.
		/// </summary>
		[JsonProperty("transaction_id")]
		public string TransactionId { get; set; } = null!;

		/// <summary>
		/// The ID of the account in which this transaction occurred.
		/// </summary>
		[JsonProperty("account_id")]
		public string AccountId { get; set; } = null!;

		/// <summary>
		/// A hierarchical array of the categories to which this transaction belongs.
		/// </summary>
		[JsonProperty("category")]
		public string[]? Categories { get; set; }

		/// <summary>
		///The ID of the category to which this transaction belongs.
		/// </summary>
		[JsonProperty("category_id")]
		public string? CategoryId { get; set; }

		/// <summary>
		/// The channel used to make a payment. Possible values are: online, in store, other. This field will replace the transaction_type field.
		/// </summary>
		[JsonProperty("payment_channel")]
		public PaymentChannel PaymentChannel { get; set; }

		/// <summary>
		/// The settled dollar value. Positive values when money moves out of the account; negative values when money moves in. For example, purchases are positive; credit card payments, direct deposits, refunds are negative.
		/// </summary>
		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		/// <summary>
		/// The ISO currency code of the transaction, either USD or CAD. Always <c>null</c> if unofficial_currency_code is non-<c>null</c>.
		/// </summary>
		[JsonProperty("iso_currency_code")]
		public string? IsoCurrencyCode { get; set; }

		/// <summary>
		/// The unofficial currency code associated with the transaction. Always <c>null</c> if iso_currency_code is non-<c>null</c>.
		/// </summary>
		[JsonProperty("unofficial_currency_code")]
		public string? UnofficialCurrencyCode { get; set; }

		/// <summary>
		/// Gets the currency code from either IsoCurrencyCode or UnofficialCurrencyCode. If non-null, IsoCurrencyCode is returned, else if non-null, UnofficialCurrencyCode, else null is returned.
		/// </summary>
		/// <value>Either available currency code.</value>
		public string? CurrencyCode => IsoCurrencyCode ?? UnofficialCurrencyCode ?? null;

		/// <summary>
		/// The date of the transaction.
		/// </summary>
		/// <remarks>For pending transactions, Plaid returns the date the transaction occurred; for posted transactions, Plaid returns the date the transaction posts.</remarks>
		[JsonProperty("date")]
		public DateTime Date { get; set; }

		/// <summary>
		/// The date that the transaction was authorized.
		/// </summary>
		[JsonProperty("authorized_date")]
		public DateTime? AuthorizedDate { get; set; }

		/// <summary>
		/// Gets or sets the information of the merchant's location. Typically <c>null</c>.
		/// </summary>
		[JsonProperty("location")]
		public LocationInfo? Location { get; set; }

		/// <summary>
		/// A value indicating whether this <see cref="Transaction"/> is pending or unsettled. Pending transaction details (<see cref="Name"/>, <see cref="PaymentChannel"/>, <see cref="Amount"/>) may change before they are settled.
		/// </summary>
		/// <value><c>true</c> if pending; otherwise, <c>false</c>.</value>
		[JsonProperty("pending")]
		public bool Pending { get; set; }

		/// <summary>
		/// The id of a posted transaction's associated pending transaction.
		/// </summary>
		[JsonProperty("pending_transaction_id")]
		public string? PendingTransactionId { get; set; }

		/// <summary>
		/// The name of the account owner. This property is not typically populated and only relevant when dealing with sub-accounts.
		/// </summary>
		[JsonProperty("account_owner")]
		public string? AccountOwner { get; set; }

		/// <summary>
		/// Represents a geographical location.
		/// </summary>
		public class LocationInfo
		{
			/// <summary>
			/// Gets or sets the address.
			/// </summary>
			/// <value>The address.</value>
			[JsonProperty("address")]
			public string? Address { get; set; }

			/// <summary>
			/// Gets or sets the city.
			/// </summary>
			/// <value>The city.</value>
			[JsonProperty("city")]
			public string? City { get; set; }

			/// <summary>
			/// Gets or sets the state.
			/// </summary>
			/// <value>The state.</value>
			[JsonProperty("state")]
			public string? State { get; set; }

			/// <summary>
			/// Gets or sets the zip.
			/// </summary>
			/// <value>The zip.</value>
			[JsonProperty("zip")]
			public string? Zip { get; set; }

			/// <summary>
			/// Gets or sets the latitude (x-coordinate).
			/// </summary>
			/// <value>The latitude.</value>
			[JsonProperty("lat")]
			public decimal? Latitude { get; set; }

			/// <summary>
			/// Gets or sets the longitude (y-coordinate).
			/// </summary>
			/// <value>The longitude.</value>
			[JsonProperty("lon")]
			public decimal? Longitude { get; set; }

			/// <summary>
			/// Gets or sets the store number.
			/// </summary>
			/// <value>The store number.</value>
			[JsonProperty("store_number")]
			public string? StoreNumber { get; set; }
		}
	}
}
