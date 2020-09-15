using Newtonsoft.Json;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's drop-in authentication module.
	/// </summary>
	public class PlaidLinkResponse
	{
		/// <summary>
		/// Gets or sets the public_token.
		/// </summary>
		/// <value>The public token.</value>
		[JsonProperty("public_token")]
		public string PublicToken { get; set; } = null!;

		/// <summary>
		/// Gets or sets the link session identifier.
		/// </summary>
		/// <value>The link session identifier.</value>
		[JsonProperty("link_session_id")]
		public string LinkSessionId { get; set; } = null!;

		/// <summary>
		/// Gets or sets the accounts info.
		/// </summary>
		/// <value>The accounts.</value>
		[JsonProperty("accounts")]
		public AccountInfo[] Accounts { get; set; } = null!;

		/// <summary>
		/// The account object is not null in the onSuccess callback when 
		/// your users connect a specific bank account via the Select Account 
		/// pane in Link. You can enable this behavior in the Plaid Dashboard 
		/// or by integrating with all Auth features.
		/// 
		/// Note: If Select Account is enabled for multiple accounts, account 
		/// will contain only the first account. All accounts selected by the 
		/// user will be present in the accounts object.
		/// </summary>
		[JsonProperty("account")]
		public AccountInfo Account { get; set; } = null!;

		/// <summary>
		/// Gets or sets the institution.
		/// </summary>
		/// <value>The institution.</value>
		[JsonProperty("institution")]
		public InstitutionInfo Institution { get; set; } = null!;


		/// <summary>
		/// Represents an <see cref="Entity.Account"/> metadata.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage(
			"Design",
			"CA1034:Nested types should not be visible",
			Justification = "Required for Json deserialization?")]
		public class AccountInfo
		{
			/// <summary>
			/// Gets or sets the <see cref="Entity.Account"/> identifier.
			/// </summary>
			/// <value>The identifier.</value>
			[JsonProperty("id")]
			public string Id { get; set; } = null!;

			/// <summary>
			/// Gets or sets the <see cref="Entity.Account"/> name.
			/// </summary>
			/// <value>The name.</value>
			[JsonProperty("name")]
			public string Name { get; set; } = null!;
		}


		/// <summary>
		/// Represents an <see cref="Entity.Institution"/> metadata.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage(
			"Design",
			"CA1034:Nested types should not be visible",
			Justification = "Required for Json deserialization?")]
		public class InstitutionInfo
		{
			/// <summary>
			/// Gets or sets the <see cref="Entity.Institution"/> identifier.
			/// </summary>
			/// <value>The identifier.</value>
			[JsonProperty("institution_id")]
			public string Id { get; set; } = null!;

			/// <summary>
			/// Gets or sets the <see cref="Entity.Institution"/> name.
			/// </summary>
			/// <value>The name.</value>
			[JsonProperty("name")]
			public string Name { get; set; } = null!;
		}
	}
}
