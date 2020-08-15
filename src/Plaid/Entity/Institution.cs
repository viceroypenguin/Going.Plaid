using Newtonsoft.Json;

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
		[JsonProperty("institution_id")]
		public string InstitutionId { get; set; } = null!;

		/// <summary>
		/// The official name of the institution.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// A list of the Plaid products supported by the institution.
		/// </summary>
		[JsonProperty("products")]
		public string[] Products { get; set; } = null!;

		/// <summary>
		/// A list of routing numbers associated with the institution.
		/// </summary>
		[JsonProperty("routing_numbers")]
		public string[]? RoutingNumbers { get; set; }

		/// <summary>
		/// A list of country codes associated with the institution.
		/// </summary>
		[JsonProperty("country_codes")]
		public string[]? CountryCodes { get; set; }

		/// <summary>
		/// Inidcates if this institution uses OAuth flows
		/// </summary>
		[JsonProperty("oauth")]
		public bool? OAuth { get; set; }

		#region MFA

		/// <summary>
		/// Inidcates if this institution uses MFA
		/// </summary>
		[JsonProperty("has_mfa")]
		public bool? HasMFA { get; set; }

		/// <summary>
		/// A list of mfa types associated with the institution.
		/// </summary>
		[JsonProperty("mfa")]
		public string[]? MFA { get; set; }

		/// <summary>
		/// Tht type of MFA used but this Institution.
		/// </summary>
		[JsonProperty("mfa_code_type")]
		public string? MFACodeType { get; set; }

		#endregion

		#region Optional Metadata: include_optional_metadata

		/// <summary>
		/// The URL for the institution's website.
		/// </summary>
		[JsonProperty("url")]
		public string? Url { get; set; }

		/// <summary>
		/// The primary colour for the institution to use in visual displays.
		/// The Brand color is in hexadecimal format
		/// </summary>
		[JsonProperty("primary_color")]
		public string? PrimaryColor { get; set; }

		/// <summary>
		/// The logo for the institution to use in visual displays.
		/// When available, the bank's logo is returned as a base64 encoded 152x152 PNG
		/// </summary>
		[JsonProperty("logo")]
		public string? Logo { get; set; }

		#endregion

	}
}
