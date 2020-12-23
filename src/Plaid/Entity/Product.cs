using System.Runtime.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// The available products for Plaid. Used to inform Plaid which products should be used when connecting to an <see cref="Item"/>
	/// </summary>
	public enum Product
	{
		/// <summary>
		/// Individual transactions in credit, depository, and some loan-type <see cref="Account"/>s.
		/// </summary>
		[EnumMember(Value = "transactions")]
		Transactions,

		/// <summary>
		/// Validate that credentials to an <see cref="Item"/>  are valid.
		/// </summary>
		[EnumMember(Value = "auth")]
		Auth,

		/// <summary>
		/// Account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
		/// </summary>
		[EnumMember(Value = "identity")]
		Identity,

		/// <summary>
		/// Information pertaining to an <see cref="Item"/>’s income. In addition to the annual income, detailed information will be provided for each contributing income stream (or job).
		/// </summary>
		[EnumMember(Value = "income")]
		Income,

		/// <summary>
		/// Information pertaining to an <see cref="Item"/>'s asset list, which we call Asset Reports.
		/// </summary>
		/// <remarks>
		/// Asset Reports are not currently implemented in this library. If you need this data, please feel free to submit a PR or ask me to implement.
		/// </remarks>
		[EnumMember(Value = "assets")]
		Assets,

		/// <summary>
		/// Point-in-time snapshots of an <see cref="Item"/> or set of <see cref="Item"/>s, including account balances.
		/// </summary>
		[EnumMember(Value = "balance")]
		Balance,

		/// <summary>
		/// Holding, Security, and Investment Transactions data for an <see cref="Item"/>.
		/// </summary>
		[EnumMember(Value = "investments")]
		Investments,

		/// <summary>
		/// Details about an <see cref="Item"/> with loan or credit accounts, such as Balances, Payment timing, Current loan terms, or Account details.
		/// </summary>
		[EnumMember(Value = "liabilities")]
		Liabilities,

		/// <summary>
		/// Details about an <see cref="Item"/> with individual credit liabilities, such as credit cards. This is part of the <see cref="Liabilities"/> product.
		/// </summary>
		[EnumMember(Value = "credit_details")]
		CreditDetails,

		/// <summary>
		/// The Payment Initiation API enables payment transfers within your app. Right now, the API only supports payments originating from UK bank accounts but we are working to support payment initiation from other geographies in the near future.
		/// </summary>
		/// <remarks>unsupported/untested</remarks>
		[EnumMember(Value = "payment_initiation")]
		PaymentInitiation,
	}
}
