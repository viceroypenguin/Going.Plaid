using System.Text.Json.Serialization;

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
		[JsonPropertyName("current")]
		public decimal? Current { get; init; }

		/// <summary>
		/// The available balance of the account.
		/// </summary>
		[JsonPropertyName("available")]
		public decimal? Available { get; init; }

		/// <summary>
		/// The limit of the account.
		/// </summary>
		[JsonPropertyName("limit")]
		public decimal? Limit { get; init; }

		/// <summary>
		/// The iso currency code of the balance, if known officially.
		/// </summary>
		[JsonPropertyName("iso_currency_code")]
		public string? ISOCurrencyCode { get; init; }

		/// <summary>
		/// The guessed iso currency code of the balance, if not known officially.
		/// </summary>
		[JsonPropertyName("unofficial_currency_code")]
		public string? UnofficialCurrencyCode { get; init; }
	}
}
