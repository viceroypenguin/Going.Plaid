using Newtonsoft.Json;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents an account balance.
	/// </summary>
	public struct Balance
	{
		/// <summary>
		/// The current balance of the account.
		/// </summary>
		[JsonProperty("current")]
		public decimal Current { get; init; }

		/// <summary>
		/// The available balance of the account.
		/// </summary>
		[JsonProperty("available")]
		public decimal? Available { get; init; }

		/// <summary>
		/// The limit of the account.
		/// </summary>
		[JsonProperty("limit")]
		public decimal? Limit { get; init; }

		/// <summary>
		/// The iso currency code of the balance, if known officially.
		/// </summary>
		[JsonProperty("iso_currency_code")]
		public string? ISOCurrencyCode { get; init; }

		/// <summary>
		/// The guessed iso currency code of the balance, if not known officially.
		/// </summary>
		[JsonProperty("unofficial_currency_code")]
		public string? UnofficialCurrencyCode { get; init; }
	}
}
