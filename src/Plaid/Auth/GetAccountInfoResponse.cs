using Newtonsoft.Json;

namespace Going.Plaid.Auth
{
	/// <summary>
	/// Represents a response from plaid's '<c>/auth/get</c>' endpoint. The <c>/auth/get</c> endpoint allows you to retrieve the bank account and routing numbers associated with an <see cref="Entity.Item"/>’s checking and savings accounts, along with high-level account data and balances.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record GetAccountInfoResponse : ResponseBase
	{
		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		[JsonProperty("item")]
		public Entity.Item Item { get; init; } = null!;

		/// <summary>
		/// The accounts attached to the <see cref="Item"/>
		/// </summary>
		[JsonProperty("accounts")]
		public Entity.Account[] Accounts { get; init; } = null!;

		/// <summary>
		/// The routing and account numbers for the accounts.
		/// </summary>
		/// <value>The numbers.</value>
		[JsonProperty("numbers")]
		public AccountIdentifiers Numbers { get; init; }

		/// <summary>
		/// Seperates account types into ACH and EFT types.
		/// </summary>
		public struct AccountIdentifiers
		{
			/// <summary>
			/// An array of ACH account numbers.
			/// </summary>
			/// <remarks>These are used for US accounts.</remarks>
			[JsonProperty("ach")]
			public AchAccountNumbers[] ACH { get; init; }

			/// <summary>
			/// Gets or sets an array of EFT account numbers.
			/// </summary>
			/// <remarks>These are used for Canadian accounts.</remarks>
			[JsonProperty("eft")]
			public EtfAccountNumbers[] EFT { get; init; }

			/// <summary>
			/// Gets or sets an array of international account numbers.
			/// </summary>
			/// <remarks>These are used for standard international accounts.</remarks>
			[JsonProperty("international")]
			public InternationalAccountNumbers[] International { get; init; }

			/// <summary>
			/// Gets or sets an array of BACS account numbers.
			/// </summary>
			/// <remarks>These are used for British accounts.</remarks>
			[JsonProperty("bacs")]
			public BacsAccountNumbers[] BACS { get; init; }
		}

		/// <summary>
		/// Represents the bank account and routing numbers associated with an ACH account on a item.
		/// </summary>
		public struct AchAccountNumbers
		{
			/// <summary>
			/// Gets or sets the plaid account identifier.
			/// </summary>
			/// <value>The account identifier.</value>
			[JsonProperty("account_id")]
			public string AccountId { get; init; }

			/// <summary>
			/// Gets or sets the account number.
			/// </summary>
			/// <value>The account number.</value>
			[JsonProperty("account")]
			public string AccountNumber { get; init; }

			/// <summary>
			/// Gets or sets the routing number.
			/// </summary>
			/// <value>The routing number.</value>
			[JsonProperty("routing")]
			public string RoutingNumber { get; init; }

			/// <summary>
			/// Gets or sets the wire routing number.
			/// </summary>
			/// <value>The wire routing number.</value>
			[JsonProperty("wire_routing")]
			public string WireRoutingNumber { get; init; }
		}

		/// <summary>
		/// Represents the bank account and institution/branch associated with an EFT account on a item.
		/// </summary>
		public struct EtfAccountNumbers
		{
			/// <summary>
			/// Gets or sets the Plaid account ID associated with the account numbers.
			/// </summary>
			/// <value>The account identifier.</value>
			[JsonProperty("account_id")]
			public string AccountId { get; init; }

			/// <summary>
			/// Gets or sets the EFT account number for the account.
			/// </summary>
			/// <value>The account number.</value>
			[JsonProperty("account")]
			public string AccountNumber { get; init; }

			/// <summary>
			/// Gets or sets the EFT institution number for the account.
			/// </summary>
			/// <value>The institution identifier.</value>
			[JsonProperty("institution")]
			public string Institution { get; init; }

			/// <summary>
			/// Gets or sets the EFT branch number for the account.
			/// </summary>
			/// <value>The branch number.</value>
			[JsonProperty("branch")]
			public string Branch { get; init; }
		}

		/// <summary>
		/// Represents the bank account and routing numbers associated with an international account on a item.
		/// </summary>
		public struct InternationalAccountNumbers
		{
			/// <summary>
			/// Gets or sets the plaid account identifier.
			/// </summary>
			/// <value>The account identifier.</value>
			[JsonProperty("account_id")]
			public string AccountId { get; init; }

			/// <summary>
			/// Gets or sets the International Bank Account Number for the account.
			/// </summary>
			/// <value>The International Bank Account Number (IBAN).</value>
			[JsonProperty("iban")]
			public string Iban { get; init; }

			/// <summary>
			/// Gets or sets the Bank Identifier Code for the account.
			/// </summary>
			/// <value>The Bank Identifier Code (BIC)</value>
			[JsonProperty("bic")]
			public string Bic { get; init; }
		}

		/// <summary>
		/// Represents the bank account and routing numbers associated with an ACH account on a item.
		/// </summary>
		public struct BacsAccountNumbers
		{
			/// <summary>
			/// Gets or sets the plaid account identifier.
			/// </summary>
			/// <value>The account identifier.</value>
			[JsonProperty("account_id")]
			public string AccountId { get; init; }

			/// <summary>
			/// Gets or sets the BACS account number for the account.
			/// </summary>
			/// <value>The BACS account number.</value>
			[JsonProperty("account")]
			public string AccountNumber { get; init; }

			/// <summary>
			/// Gets or sets the BACS sort code for the account.
			/// </summary>
			/// <value>The BACS sort code.</value>
			[JsonProperty("sort_code")]
			public string RoutingNumber { get; init; }
		}
	}
}
