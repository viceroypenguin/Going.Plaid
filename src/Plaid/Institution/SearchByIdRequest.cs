using System.Text.Json.Serialization;
using Going.Plaid.Options;

namespace Going.Plaid.Institution
{
	/// <summary>
	/// Represents a request for plaid's '<c>/institutions/get_by_id</c>' endpoint. The '<c>/institutions/get_by_id</c>' endpoint to retrieve a <see cref="Entity.Institution"/> with the specified id.
	/// </summary>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class SearchByIdRequest : RequestBase
	{
		/// <summary>
		/// The identifier of the <see cref="Entity.Institution"/> for which to query information.
		/// </summary>
		/// <value>The products.</value>
		[JsonPropertyName("institution_id")]
		public string InstitutionId { get; set; } = null!;

		/// <summary>
		/// Specify an array of Plaid-supported country codes using the ISO-3166-1 alpha-2 country code standard.
		/// </summary>
		[JsonPropertyName("country_codes")]
		public string[] CountryCodes { get; set; } = null!;

		/// <summary>
		/// Options for searching Institutions
		/// </summary>
		[JsonPropertyName("options")]
		public InstitutionSearchOptions? Options { get; set; }

		/// <inheritdoc/>
		public override void SetCredentials(string? secret, string? clientId, string? accessToken)
		{
			if (string.IsNullOrWhiteSpace(Secret)) Secret = secret;
			if (string.IsNullOrWhiteSpace(ClientId)) ClientId = clientId;
			AccessToken = null;
		}
	}
}
