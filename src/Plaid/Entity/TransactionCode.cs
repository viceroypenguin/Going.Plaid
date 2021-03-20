using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// An identifier classifying the transaction type.
	/// </summary>
	public enum TransactionCode
	{
		/// <summary>
		/// Bank adjustment
		/// </summary>
		[EnumMember(Value = "adjustment")]
		Adjustment,

		/// <summary>
		/// Cash deposit or withdrawal via an automated teller machine
		/// </summary>
		[EnumMember(Value = "atm")]
		Atm,

		/// <summary>
		/// Charge or fee levied by the institution
		/// </summary>
		[EnumMember(Value = "bank charge")]
		BankCharge,

		/// <summary>
		/// Payment of a bill
		/// </summary>
		[EnumMember(Value = "bill payment")]
		BillPayment,

		/// <summary>
		/// Cash deposit or withdrawal
		/// </summary>
		[EnumMember(Value = "cash")]
		Cash,

		/// <summary>
		/// Cash withdrawal while making a debit card purchase
		/// </summary>
		[EnumMember(Value = "cashback")]
		Cashback,

		/// <summary>
		/// Document ordering the payment of money to another person or organization
		/// </summary>
		[EnumMember(Value = "cheque")]
		Cheque,

		/// <summary>
		/// Automatic withdrawal of funds initiated by a third party at a regular interval
		/// </summary>
		[EnumMember(Value = "direct debit")]
		DirectDebit,

		/// <summary>
		/// Interest earned or incurred
		/// </summary>
		[EnumMember(Value = "interest")]
		Interest,

		/// <summary>
		/// Purchase made with a debit or credit card
		/// </summary>
		[EnumMember(Value = "purchase")]
		Purchase,

		/// <summary>
		/// Payment instructed by the account holder to a third party at a regular interval
		/// </summary>
		[EnumMember(Value = "standing order")]
		StandingOrder,

		/// <summary>
		/// Transfer of money between accounts
		/// </summary>
		[EnumMember(Value = "transfer")]
		Transfer,
	}
}
