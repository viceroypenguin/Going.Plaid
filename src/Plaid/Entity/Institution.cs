using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a banking institution.
	/// </summary>
	public class Institution
	{
		/// <summary>
		/// Unique identifier for the institution.
		/// </summary>
		[JsonPropertyName("institution_id")]
		public string InstitutionId { get; init; } = null!;

		/// <summary>
		/// The official name of the institution.
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; init; } = null!;

		/// <summary>
		/// A list of the Plaid products supported by the institution.
		/// </summary>
		[JsonPropertyName("products")]
		public Product[] Products { get; init; } = null!;

		/// <summary>
		/// A list of country codes associated with the institution.
		/// </summary>
		[JsonPropertyName("country_codes")]
		public string[] CountryCodes { get; init; } = null!;

		/// <summary>
		/// Inidcates if this institution uses OAuth flows
		/// </summary>
		[JsonPropertyName("oauth")]
		public bool? OAuth { get; init; }

		#region Optional Metadata: include_optional_metadata

		/// <summary>
		/// A list of routing numbers associated with the institution.
		/// </summary>
		[JsonPropertyName("routing_numbers")]
		public string[]? RoutingNumbers { get; init; }

		/// <summary>
		/// The URL for the institution's website.
		/// </summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		/// <summary>
		/// The primary colour for the institution to use in visual displays.
		/// The Brand color is in hexadecimal format
		/// </summary>
		[JsonPropertyName("primary_color")]
		public string? PrimaryColor { get; init; }

		/// <summary>
		/// The logo for the institution to use in visual displays.
		/// When available, the bank's logo is returned as a base64 encoded 152x152 PNG
		/// </summary>
		[JsonPropertyName("logo")]
		public string? Logo { get; init; }

		#endregion

	}
}
