using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a single Mortgage account.
	/// </summary>
	public class Mortgage
	{
		/// <summary>
		/// The <see cref="Account.AccountId"/> of the account that this liability belongs to.
		/// </summary>
		[JsonPropertyName("account_id")]
		public string? AccountId { get; init; }

		/// <summary>
		/// The account number of the loan.
		/// </summary>
		[JsonPropertyName("account_number")]
		public string AccountNumber { get; init; } = null!;

		/// <summary>
		/// The current outstanding amount charged for late payment.
		/// </summary>
		[JsonPropertyName("current_late_fee")]
		public decimal? CurrentLateFee { get; init; }

		/// <summary>
		/// Total amount held in escrow to pay taxes and insurance on behalf of the borrower.
		/// </summary>
		[JsonPropertyName("escrow_balance")]
		public decimal? EscrowBalance { get; init; }

		/// <summary>
		/// Indicates whether the borrower has private mortgage insurance in effect.
		/// </summary>
		[JsonPropertyName("has_pmi")]
		public bool? HasPmi { get; init; }

		/// <summary>
		/// Indicates whether the borrower will pay a penalty for early payoff of mortgage.
		/// </summary>
		[JsonPropertyName("has_prepayment_penalty")]
		public bool? HasPrepaymentPenalty { get; init; }

		/// <summary>
		/// Object containing metadata about the interest rate for the mortgage.
		/// </summary>
		[JsonPropertyName("interest_rate")]
		public InterestRate InterestRate { get; init; }

		/// <summary>
		/// The amount of the last payment.
		/// </summary>
		[JsonPropertyName("last_payment_amount")]
		public decimal? LastPaymentAmount { get; init; }

		/// <summary>
		/// The date of the last payment. 
		/// </summary>
		[JsonPropertyName("last_payment_date")]
		public DateTime? LastPaymentDate { get; init; }

		/// <summary>
		/// Full duration of mortgage as at origination. (10yr, 15yr, 30yr)
		/// </summary>
		[JsonPropertyName("loan_term")]
		public string? LoanTerm { get; init; }

		/// <summary>
		/// Type of mortgage
		/// </summary>
		[JsonPropertyName("loan_type_description")]
		public MortgageType? MortgageType { get; init; }

		/// <summary>
		/// Original date on which mortgage is due in full. 
		/// </summary>
		[JsonPropertyName("maturity_date")]
		public DateTime? MaturityDate { get; init; }

		/// <summary>
		/// The amount of the next payment.
		/// </summary>
		[JsonPropertyName("next_monthly_payment")]
		public decimal? NextMonthlyPayment { get; init; }

		/// <summary>
		/// The due date for the next payment.
		/// </summary>
		[JsonPropertyName("next_payment_due_date")]
		public DateTime? NextPaymentDueDate { get; init; }

		/// <summary>
		/// The date on which the loan was initially lent. 
		/// </summary>
		[JsonPropertyName("origination_date")]
		public DateTime? OriginationDate { get; init; }

		/// <summary>
		/// The original principal balance of the mortgage.
		/// </summary>
		[JsonPropertyName("origination_principal_amount")]
		public decimal? OriginationPrincipalAmount { get; init; }

		/// <summary>
		/// Amount of loan (principal + interest) past due for payment.
		/// </summary>
		[JsonPropertyName("past_due_amount")]
		public decimal? PastDueAmount { get; init; }

		/// <summary>
		/// Object containing fields describing property address.
		/// </summary>
		[JsonPropertyName("property_address")]
		public Address? PropertyAddress { get; init; }

		/// <summary>
		/// The year to date (YTD) interest paid.
		/// </summary>
		[JsonPropertyName("ytd_interest_paid")]
		public decimal? YtdInterestPaid { get; init; }

		/// <summary>
		/// The YTD principal paid.
		/// </summary>
		[JsonPropertyName("ytd_principal_paid")]
		public decimal? YtdPrincipalPaid { get; init; }
	}

	/// <summary>
	/// Mortgage Type
	/// </summary>
	public enum MortgageType
	{
		/// <summary>
		/// Conventional Mortgage
		/// </summary>
		[EnumMember(Value = "conventional")]
		Conventional,

		/// <summary>
		/// Fixed Rate Mortgage
		/// </summary>
		[EnumMember(Value = "fixed")]
		Fixed,

		/// <summary>
		/// Variable Rate Mortgage
		/// </summary>
		[EnumMember(Value = "variable")]
		Variable,
	}

	/// <summary>
	/// Object containing metadata about the interest rate for the mortgage.
	/// </summary>
	public struct InterestRate
	{
		/// <summary>
		/// Percentage value (interest rate of current mortgage, not APR) of interest payable on a loan.
		/// </summary>
		[JsonPropertyName("percentage")]
		public decimal? Percentage { get; init; }

		/// <summary>
		/// The type of interest charged (fixed or variable).
		/// </summary>
		[JsonPropertyName("type")]
		public InterestRateType Type { get; init; }
	}

	/// <summary>
	/// Interest Rate Type
	/// </summary>
	public enum InterestRateType
	{
		/// <summary>
		/// Fixed Interest Rate
		/// </summary>
		[EnumMember(Value = "fixed")]
		Fixed,

		/// <summary>
		/// Variable Interest Rate
		/// </summary>
		[EnumMember(Value = "variable")]
		Variable,
	}
}
