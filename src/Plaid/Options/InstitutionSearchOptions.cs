using System.Text.Json.Serialization;
using Going.Plaid.Entity;

namespace Going.Plaid.Options
{
	/// <summary>
	/// Options for searching Institutions
	/// </summary>
	public class InstitutionSearchOptions
	{
		/// <summary>
		/// When <c>true</c>, return an institution's logo, brand color, and URL. When available, the bank's logo is returned as a base64 encoded 152x152 PNG, the brand color is in hexadecimal format.
		/// </summary>
		[JsonPropertyName("include_optional_metadata")]
		public bool IncludeOptionalMetadata { get; set; }

		/// <summary>
		/// If <c>true</c>, the response will include status information about the institution.
		/// </summary>
		[JsonPropertyName("include_status")]
		public bool IncludeStatus { get; set; }

		/// <summary>
		/// Filter the <see cref="Entity.Institution"/> based on whether they support all products listed in <see cref="Products"/>.
		/// </summary>
		[JsonPropertyName("products")]
		public Product[]? Products { get; set; }

		/// <summary>
		/// Specify an array of Plaid-supported country codes using the ISO-3166-1 alpha-2 country code standard.
		/// </summary>
		[JsonPropertyName("country_codes")]
		public string[]? CountryCodes { get; set; }

		/// <summary>
		/// Specify an array of routing numbers to filter institutions.
		/// </summary>
		[JsonPropertyName("routing_numbers")]
		public string[]? RoutingNumbers { get; set; }

		/// <summary>
		/// Limit results to institutions with or without OAuth login flows. This is only relevant to institutions with European country codes.
		/// </summary>
		[JsonPropertyName("oauth")]
		public bool? OAuth { get; set; }
	}
}
