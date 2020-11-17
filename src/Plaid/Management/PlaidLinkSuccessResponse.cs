using System;
using System.Text.Json.Serialization;
using Going.Plaid.Entity;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's drop-in authentication module.
	/// </summary>
	public class PlaidLinkSuccessResponse
	{
		/// <summary>
		/// The link session identifier.
		/// </summary>
		[JsonPropertyName("link_session_id")]
		public string LinkSessionId { get; init; } = null!;

		/// <summary>
		/// The accounts linked to the <see cref="Item"/>.
		/// </summary>
		[JsonPropertyName("accounts")]
		public Account[] Accounts { get; init; } = null!;

		/// <summary>
		/// Deprecated by Plaid. Use <see cref="Accounts"/> array instead.
		/// </summary>
		[JsonPropertyName("account")]
		[Obsolete("Deprecated by Plaid. Use Accounts array instead", true)]
		public Account? Account { get; init; }

		/// <summary>
		/// Gets or sets the institution.
		/// </summary>
		/// <value>The institution.</value>
		[JsonPropertyName("institution")]
		public InstitutionInfo Institution { get; init; } = null!;

		/// <summary>
		/// Represents an <see cref="Entity.Institution"/> metadata.
		/// </summary>
		public class InstitutionInfo
		{
			/// <summary>
			/// Gets or sets the <see cref="Entity.Institution"/> identifier.
			/// </summary>
			[JsonPropertyName("institution_id")]
			public string Id { get; init; } = null!;

			/// <summary>
			/// Gets or sets the <see cref="Entity.Institution"/> name.
			/// </summary>
			[JsonPropertyName("name")]
			public string Name { get; init; } = null!;
		}
	}
}
