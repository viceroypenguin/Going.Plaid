using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a bank account.
	/// </summary>
	public class Account
	{
		/// <summary>
		/// Plaid’s unique identifier for the account.
		/// </summary>
		[JsonProperty("account_id")]
		public string AccountId { get; init; } = null!;

		/// <summary>
		/// Plaid’s unique identifier for the <see cref="Item"/>.
		/// </summary>
		/// <remarks>This is not included in: <see cref="PlaidClient.FetchAccountInfoAsync(Auth.GetAccountInfoRequest)"/></remarks>
		[JsonProperty("item_id")]
		public string? ItemId { get; init; }

		/// <summary>
		/// The financial <see cref="Institution"/> associated with the item.
		/// </summary>
		/// <remarks>This is not included in: <see cref="PlaidClient.FetchAccountInfoAsync(Auth.GetAccountInfoRequest)"/></remarks>
		[JsonProperty("institution_id")]
		public string? InstitutionId { get; init; }

		/// <summary>
		/// The name of the account, either assigned by the user or by the financial institution itself.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; init; } = null!;

		/// <summary>
		/// The last 2-4 alphanumeric characters of an account's official account number.
		/// </summary>
		/// <remarks>The mask may be non-unique between an Item's accounts, it may also not match the mask that the bank displays to the user.</remarks>
		[JsonProperty("mask")]
		public string? Mask { get; init; }

		/// <summary>
		/// The official name of the account as given by the financial institution.
		/// </summary>
		[JsonProperty("official_name")]
		public string? OfficialName { get; init; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		[JsonProperty("type")]
		public AccountType Type { get; init; }

		/// <summary>
		/// Gets or sets the type of the sub.
		/// </summary>
		/// <value>The type of the sub.</value>
		[JsonProperty("subtype")]
		public AccountSubType SubType { get; init; }

		/// <summary>
		/// Balance information about the account. The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
		/// </summary>
		/// <remarks>Note: Not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of <c>null</c>.</remarks>
		[JsonProperty("balances")]
		public Balance? Balance { get; init; }

		/// <summary>
		/// Owner information from the institution.
		/// </summary>
		/// <remarks>This is not included in: /auth/get</remarks>
		[JsonProperty("owners")]
		public Identity[]? Identity { get; init; }
	}
}
