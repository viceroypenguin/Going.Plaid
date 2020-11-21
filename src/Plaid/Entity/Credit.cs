using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// A single credit account.
	/// </summary>
	public class Credit
	{
		/// <summary>
		/// The <see cref="Account.AccountId"/> of the account that this liability belongs to.
		/// </summary>
		[JsonPropertyName("account_id")]
		public string? AccountId { get; init; }

		/// <summary>
		/// the various interest rates that apply to the account.
		/// </summary>
		[JsonPropertyName("aprs")]
		public Apr[] Aprs { get; init; } = Array.Empty<Apr>();

		/// <summary>
		/// <c>true</c> if a payment is currently overdue. 
		/// </summary>
		/// <remarks>Availability for this field is limited.</remarks>
		[JsonPropertyName("is_overdue")]
		public bool? IsOverdue { get; init; }

		/// <summary>
		/// The amount of the last payment.
		/// </summary>
		[JsonPropertyName("last_payment_amount")]
		public decimal LastPaymentAmount { get; init; }

		/// <summary>
		/// The date of the last payment.
		/// </summary>
		[JsonPropertyName("last_payment_date")]
		public DateTime LastPaymentDate { get; init; }

		/// <summary>
		/// The outstanding balance on the last statement. 
		/// </summary>
		/// <remarks>Availability for this field is limited.</remarks>
		[JsonPropertyName("last_statement_balance")]
		public decimal LastStatementBalance { get; init; }

		/// <summary>
		/// The date of the last statement. 
		/// </summary>
		[JsonPropertyName("last_statement_issue_date")]
		public DateTime LastStatementIssueDate { get; init; }

		/// <summary>
		/// The minimum payment due for the next billing cycle.
		/// </summary>
		[JsonPropertyName("minimum_payment_amount")]
		public decimal MinimumPaymentAmount { get; init; }

		/// <summary>
		/// The due date for the next payment. The due date is <c>null</c> if a payment is not expected. 
		/// </summary>
		[JsonPropertyName("next_payment_due_date")]
		public DateTime? NextPaymentDueDate { get; init; }
	}

	/// <summary>
	/// Represents a single interest rate that applies to the account
	/// </summary>
	public struct Apr
	{
		/// <summary>
		/// Annual Percentage Rate applied.
		/// </summary>
		[JsonPropertyName("apr_percentage")]
		public decimal AprPercentage { get; init; }

		/// <summary>
		/// The type of balance to which the APR applies.
		/// </summary>
		[JsonPropertyName("apr_type")]
		public AprType AprType { get; init; }

		/// <summary>
		/// Amount of money that is subjected to the APR if a balance was carried beyond payment due date. How it is calculated can vary by card issuer. It is often calculated as an average daily balance.
		/// </summary>
		[JsonPropertyName("balance_subject_to_apr")]
		public decimal? BalanceSubjectToApr { get; init; }

		/// <summary>
		/// Amount of money charged due to interest from last statement.
		/// </summary>
		[JsonPropertyName("interest_charge_amount")]
		public decimal? InterestChargeAmount { get; init; }
	}

	/// <summary>
	/// APR Type
	/// </summary>
	public enum AprType
	{
		/// <summary>
		/// APR for a Balance Transfer charge
		/// </summary>
		[EnumMember(Value = "balance_transfer_apr")]
		BalanceTransfer,

		/// <summary>
		/// APR for a Cash charge
		/// </summary>
		[EnumMember(Value = "cash_apr")]
		Cash,

		/// <summary>
		/// APR for a Purchase charge
		/// </summary>
		[EnumMember(Value = "purchase_apr")]
		Purchase,

		/// <summary>
		/// Special APR
		/// </summary>
		[EnumMember(Value = "special")]
		Special,
	}
}
