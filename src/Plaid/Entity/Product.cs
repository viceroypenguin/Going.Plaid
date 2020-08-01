using System.Runtime.Serialization;
using Newtonsoft.Json;

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
		/// Information pertaining to a <see cref="Item"/>’s income. In addition to the annual income, detailed information will be provided for each contributing income stream (or job).
		/// </summary>
		[EnumMember(Value = "income")]
		Income,

		/// <summary>
		/// Point-in-time snapshots of an <see cref="Item"/> or set of <see cref="Item"/>s, including account balances, historical transactions, and account holder identity information, which we call Asset Reports.
		/// </summary>
		[EnumMember(Value = "assets")]
		Assets,

		/// <summary>
		/// Holding, Security, and InvestmentTransactions data for a wide array of investment account and security types.
		/// </summary>
		[EnumMember(Value = "investments")]
		Investments,

		/// <summary>
		/// Details about an <see cref="Item"/> with loan or credit accounts, such as Balances, Payment timing, Current loan terms, or Account details.
		/// </summary>
		[EnumMember(Value = "liabilities")]
		Liabilities,

		/// <summary>
		/// The Payment Initiation API enables payment transfers within your app. Right now, the API only supports payments originating from UK bank accounts but we are working to support payment initiation from other geographies in the near future.
		/// </summary>
		/// <remarks>unsupported/untested</remarks>
		[EnumMember(Value = "payment_initiation")]
		PaymentInitiation,
	}
}
