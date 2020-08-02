using System;
using Going.Plaid.Options;
using Newtonsoft.Json;

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
		[JsonProperty("count")]
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
		[JsonProperty("offset")]
		public uint Offset { get; set; }

		/// <summary>
		/// Search options for filtering the returned institutions
		/// </summary>
		[JsonProperty("options")]
		public InstitutionSearchOptions? Options { get; set; }

		/// <summary>
		/// SearchById does not accept <c>access_token</c>
		/// </summary>
		protected internal override bool UseAccessToken => false;
	}
}
