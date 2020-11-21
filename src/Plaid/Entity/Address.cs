using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents the fields of an address.
	/// </summary>
	public record Address
	{
		/// <summary>
		/// The city name
		/// </summary>
		[JsonPropertyName("city")]
		public string? City { get; init; }

		/// <summary>
		/// The ISO 3166-1 alpha-2 country code.
		/// </summary>
		[JsonPropertyName("country")]
		public string? Country { get; init; }

		/// <summary>
		/// The five or nine digit postal code.
		/// </summary>
		[JsonPropertyName("postal_code")]
		public string? PostalCode { get; init; }

		/// <summary>
		/// The region or state (example "NC").
		/// </summary>
		[JsonPropertyName("region")]
		public string? Region { get; init; }

		/// <summary>
		/// The full street address (example "564 Main Street, Apt 15").
		/// </summary>
		[JsonPropertyName("street")]
		public string? Street { get; init; }
	}
}
