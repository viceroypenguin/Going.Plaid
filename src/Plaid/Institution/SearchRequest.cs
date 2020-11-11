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
