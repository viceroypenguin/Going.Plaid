using System.Text.Json.Serialization;
using Going.Plaid.Entity;
using Going.Plaid.Options;

namespace Going.Plaid.Institution
{
	/// <summary>
	/// Represents a request for plaid's '<c>/institutions/search</c>' endpoints. The '<c>/institutions/search</c>' endpoint to retrieve a complete list of supported institutions that match the query.
	/// </summary>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class SearchRequest : RequestBase
	{
		/// <summary>
		/// Gets or sets the query.
		/// </summary>
		/// <remarks>Required</remarks>
		[JsonPropertyName("query")]
		public string Query { get; set; } = null!;

		/// <summary>
		/// Gets or sets the supported products.
		/// </summary>
		/// <remarks>Required</remarks>
		[JsonPropertyName("products")]
		public Product[] Products { get; set; } = null!;

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
			/// Limit results to institutions with or without OAuth login flows. This is only relevant to institutions with European country codes.
			/// </summary>
			[JsonPropertyName("oauth")]
			public bool OAuth { get; set; }

			/// <summary>
			/// When <c>true</c>, return an institution's logo, brand color, and URL. When available, the bank's logo is returned as a base64 encoded 152x152 PNG, the brand color is in hexadecimal format.
			/// </summary>
			[JsonPropertyName("include_optional_metadata")]
			public bool IncludeOptionalMetadata { get; set; }

			/// <summary>
			/// When <c>true</c>, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.
			/// </summary>
			[JsonPropertyName("include_payment_initiation_metadata")]
			public bool IncludePaymentInitiationMetadata { get; set; }

			/// <summary>
			/// Additional options that will be used to filter institutions by various Payment Initiation configurations.
			/// </summary>
			[JsonPropertyName("payment_initiation")]
			public PaymentInitiationOptions? PaymentInitiationOptions { get; set; }
		}

		/// <summary>
		/// Additional options that will be used to filter institutions by various Payment Initiation configurations.
		/// </summary>
		public struct PaymentInitiationOptions
		{
			/// <summary>
			/// A unique ID identifying the payment
			/// </summary>
			[JsonPropertyName("payment_id")]
			public string PaymentId { get; set; }
		}
	}
}
