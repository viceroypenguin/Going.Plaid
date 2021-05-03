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

		/// <summary>
		/// Options for searching Institutions
		/// </summary>
		public struct InstitutionSearchOptions
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
			/// When <c>true</c>, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.
			/// </summary>
			[JsonPropertyName("include_payment_initiation_metadata")]
			public bool IncludePaymentInitiationMetadata { get; set; }
		}
	}
}
