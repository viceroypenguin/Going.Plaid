using System.Runtime.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Enum AccountType
	/// </summary>
	public enum AccountType
	{
		/// <summary>
		/// Brokerage account.
		/// </summary>
		[EnumMember(Value = "brokerage")]
		Brokerage,

		/// <summary>
		/// Credit card.
		/// </summary>
		[EnumMember(Value = "credit")]
		Credit,

		/// <summary>
		/// Checking or Savings accounts.
		/// </summary>
		[EnumMember(Value = "depository")]
		Depository,

		/// <summary>
		/// Investment accounts.
		/// </summary>
		[EnumMember(Value = "investment")]
		Investment,

		/// <summary>
		/// Loan account.
		/// </summary>
		[EnumMember(Value = "loan")]
		Loan,

		/// <summary>
		/// Mortgage account.
		/// </summary>
		[EnumMember(Value = "mortgage")]
		Mortgage,

		/// <summary>
		/// Non-specified account type
		/// </summary>
		[EnumMember(Value = "other")]
		Other
	}
}
