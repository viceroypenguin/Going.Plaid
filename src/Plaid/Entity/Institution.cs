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
		/// The URL for the institution's website.
		/// </summary>
		[JsonProperty("url")]
		public string? Url { get; set; }

		/// <summary>
		/// A list of routing numbers associated with the institution.
		/// </summary>
		[JsonProperty("routing_numbers")]
		public string[]? RoutingNumbers { get; set; }
	}
}
