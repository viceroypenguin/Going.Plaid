using System;
using System.Text.Json.Serialization;
using Going.Plaid.Options;

namespace Going.Plaid.Institution
{
	/// <summary>
	/// Represents a request for plaid's '<c>/institutions/get</c>' endpoint. Returns a JSON response containing details on all financial institutions currently supported by Plaid. Because we support thousands of institutions, results are paginated.
	/// </summary>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class GetAllInstitutionsRequest : RequestBase
	{
		private uint _count = 100;

		/// <summary>
		/// The number of transactions to fetch, where 0 &lt; count &lt;= 500.
		/// </summary>
		[JsonPropertyName("count")]
		public uint Count
		{
			get => _count;
			set => _count =
				value < 1 ? throw new ArgumentOutOfRangeException(nameof(Count), "Count cannot be set to 0.") :
				value > 500 ? throw new ArgumentOutOfRangeException(nameof(Count), "Count must be set to a number <= 500.") :
				value;
		}

		/// <summary>
		/// The number of transactions to skip, where offset &gt;= 0.
		/// </summary>
		[JsonPropertyName("offset")]
		public uint Offset { get; set; }

		/// <summary>
		/// Specify an array of Plaid-supported country codes using the ISO-3166-1 alpha-2 country code standard.
		/// </summary>
		[JsonPropertyName("country_codes")]
		public string[] CountryCodes { get; set; } = null!;

		/// <summary>
		/// Search options for filtering the returned institutions
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
