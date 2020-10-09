using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Going.Plaid.Utilities;
using Newtonsoft.Json;

namespace Going.Plaid.Link
{
	/// <summary>
	/// Provides a data structure to use to deserialize the Plaid JSON metadata returned when the onSuccess event
	/// in the Plaid Link flow is triggered. 
	/// </summary>
	public class OnSuccessMetadata
	{

		/// <summary>
		/// The public_token is passed to the onSuccess Javascript callback as a separate parameter from 
		/// the metadata structure itself. It must be manually added to the metadata in order to be 
		/// included when deserializing.<br/>
		/// <example>
		/// <code>
		///  onSuccess: async function(public_token, metadata)
		///  {
		///	   // The metadata object contains info about the institution the
		///	   // user selected and the account ID or IDs, if the
		///	   // Select Account view is enabled.
		///	   // https://plaid.com/docs/#onsuccess-callback
		///
		///	   metadata.public_token = public_token;
		///	  
		///	   ... send the metadata as JSON to be deserialized into this class ...  
		///	  
		///	  }
		/// </code>
		/// </example>
		/// </summary>
		/// <value>The public token.</value>
		[JsonPropertyName("public_token")]
		[JsonProperty("public_token")]
		public string PublicToken { get; set; } = null!;

		/// <summary>
		/// Gets or sets the link session identifier.
		/// </summary>
		/// <value>The link session identifier.</value>
		[JsonPropertyName("link_session_id")]
		[JsonProperty("link_session_id")]
		public string LinkSessionId { get; set; } = null!;

		/// <summary>
		/// Gets or sets the link session identifier.
		/// </summary>
		/// <value>The link session identifier.</value>
		[JsonPropertyName("account_id")]
		[JsonProperty("account_id")]
		public string AccountId { get; set; } = null!;

		/// <summary>
		/// Gets or sets the accounts info.
		/// </summary>
		/// <value>The accounts.</value>
		[JsonPropertyName("accounts")]
		[JsonProperty("accounts")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage(
			"Performance",
			"CA1819:Properties should not return arrays",
			Justification = "Matching the data structure from the Plaid API")]
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
		[JsonPropertyName("account")]
		[JsonProperty("account")]
		public AccountInfo Account { get; set; } = null!;

		/// <summary>
		/// Gets or sets the institution.
		/// </summary>
		/// <value>The institution.</value>
		[JsonPropertyName("institution")]
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
			/// Gets or sets the <see cref="Going.Plaid.Entity.Account"/> identifier.
			/// </summary>
			/// <value>The identifier.</value>
			[JsonPropertyName("id")]
			[JsonProperty("id")]
			public string Id { get; set; } = null!;

			/// <summary>
			/// Gets or sets the <see cref="Going.Plaid.Entity.Account"/> name.
			/// </summary>
			/// <value>The name.</value>
			[JsonPropertyName("name")]
			[JsonProperty("name")]
			public string Name { get; set; } = null!;

			/// <summary>
			/// The last 2-4 alphanumeric characters of an account's official account number.
			/// </summary>
			/// <remarks>The mask may be non-unique between an Item's accounts, it may also not match the mask that the bank displays to the user.</remarks>
			[JsonPropertyName("mask")]
			[JsonProperty("mask")]
			public string Mask { get; set; } = null!;

			/// <summary>
			/// Gets or sets the type.
			/// </summary>
			/// <value>The type.</value>
			[JsonPropertyName("type")]
			[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
			[JsonProperty("type")]
			[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
			public Going.Plaid.Entity.AccountType? Type { get; set; } = null!;

			/// <summary>
			/// Gets or sets the type of the sub.
			/// </summary>
			/// <value>The type of the sub.</value>
			[JsonPropertyName("subtype")]
			[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumMemberConverter))]
			[JsonProperty("subtype")]
			[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
			public Going.Plaid.Entity.AccountSubType? SubType { get; set; } = null!;
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
			/// Gets or sets the <see cref="Going.Plaid.Entity.Institution"/> identifier.
			/// </summary>
			/// <value>The identifier.</value>
			[JsonPropertyName("institution_id")]
			[JsonProperty("institution_id")]
			public string Id { get; set; } = null!;

			/// <summary>
			/// Gets or sets the <see cref="Going.Plaid.Entity.Institution"/> name.
			/// </summary>
			/// <value>The name.</value>
			[JsonPropertyName("name")]
			[JsonProperty("name")]
			public string Name { get; set; } = null!;
		}
	}
}

