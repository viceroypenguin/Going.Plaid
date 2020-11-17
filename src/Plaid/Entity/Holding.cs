using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a single security held in an account.
	/// </summary>
	public class Holding
	{
		/// <summary>
		///  The Plaid Account ID associated with the holding.
		/// </summary>
		[JsonPropertyName("account_id")]
		public string AccountId { get; init; } = null!;

		/// <summary>
		/// The Plaid Security ID of the security associated with the holding.
		/// </summary>
		[JsonPropertyName("security_id")]
		public string SecurityId { get; init; } = null!;

		/// <summary>
		/// The last price given by the institution for this security.
		/// </summary>
		[JsonPropertyName("institution_price")]
		public decimal InstitutionPrice { get; init; }

		/// <summary>
		/// The date at which institution_price was current.
		/// </summary>
		[JsonPropertyName("institution_price_as_of")]
		public DateTime? InstitutionPriceAsOf { get; init; }

		/// <summary>
		/// The value of the holding, as stated by the institution.
		/// </summary>
		[JsonPropertyName("institution_value")]
		public decimal InstitutionValue { get; init; }

		/// <summary>
		/// The total cost of acquiring the holding.
		/// </summary>
		[JsonPropertyName("cost_basis")]
		public decimal? CostBasis { get; init; }

		/// <summary>
		/// The total quantity of the asset held, as reported by the financial institution.
		/// </summary>
		[JsonPropertyName("quantity")]
		public decimal Quantity { get; init; }

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
		public string? CurrencyCode => IsoCurrencyCode ?? UnofficialCurrencyCode;
	}
}
