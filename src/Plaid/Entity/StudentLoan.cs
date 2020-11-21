using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a single Student Loan account.
	/// </summary>
	public class StudentLoan
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
		public string? AccountNumber { get; init; }

		/// <summary>
		/// The dates on which loaned funds were disbursed or will be disbursed. These are often in the past. 
		/// </summary>
		[JsonPropertyName("disbursement_dates")]
		public DateTime[]? DisbursementDates { get; init; }

		/// <summary>
		/// The date when the student loan is expected to be paid off. Availability for this field is limited.
		/// </summary>
		[JsonPropertyName("expected_payoff_date")]
		public DateTime? ExpectedPayoffDate { get; init; }

		/// <summary>
		/// The guarantor of the student loan.
		/// </summary>
		[JsonPropertyName("guarantor")]
		public string? Guarantor { get; init; }

		/// <summary>
		/// The interest rate on the loan as a percentage.
		/// </summary>
		[JsonPropertyName("interest_rate_percentage")]
		public decimal InterestRatePercentage { get; init; }

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
		public decimal? LastPaymentAmount { get; init; }

		/// <summary>
		/// The date of the last payment. 
		/// </summary>
		[JsonPropertyName("last_payment_date")]
		public DateTime? LastPaymentDate { get; init; }

		/// <summary>
		/// The outstanding balance on the last statement. This field could also be interpreted as the next payment due. 
		/// </summary>
		/// <remarks>Availability for this field is limited.</remarks>
		[JsonPropertyName("last_statement_balance")]
		public decimal? LastStatementBalance { get; init; }

		/// <summary>
		/// The date of the last statement. 
		/// </summary>
		[JsonPropertyName("last_statement_issue_date")]
		public DateTime? LastStatementIssueDate { get; init; }

		/// <summary>
		/// The type of loan, e.g., "Consolidation Loans".
		/// </summary>
		[JsonPropertyName("loan_name")]
		public string? LoanName { get; init; }

		/// <summary>
		/// An object representing the status of the student loan.
		/// </summary>
		[JsonPropertyName("loan_status")]
		public StudentLoanStatus LoanStatus { get; init; }

		/// <summary>
		/// The minimum payment due for the next billing cycle.
		/// </summary>
		/// <remarks>
		/// There are some exceptions:
		/// <list type="bullet">
		/// <item>
		/// Some institutions require a minimum payment across all loans associated with an account number.
		/// Our API presents that same minimum payment amount on each loan. The institutions that do this are: 
		/// <list type="bullet">
		/// <item>Great Lakes (ins_116861), 				   </item>
		/// <item>Firstmark (ins_116295), 					   </item>
		/// <item>Commonbond Firstmark Services (ins_116950),  </item>
		/// <item>Nelnet (ins_116528), 						   </item>
		/// <item>EdFinancial Services (ins_116304), 		   </item>
		/// <item>Granite State (ins_116308), and 			   </item>
		/// <item>Oklahoma Student Loan Authority (ins_116945).</item>
		/// </list>
		/// </item>
		/// <item>Firstmark(ins_116295) will display as $0 if there is an autopay program in effect.</item>
		/// </list>
		/// </remarks>
		[JsonPropertyName("minimum_payment_amount")]
		public decimal? MinimumPaymentAmount { get; init; }

		/// <summary>
		/// The due date for the next payment. The due date is <c>null</c> if a payment is not expected. 
		/// A payment is not expected if <see cref="StudentLoanStatus.Type"/> is <see cref="StudentLoanStatusType.Deferment"/>, 
		/// <see cref="StudentLoanStatusType.InSchool"/>, <see cref="StudentLoanStatusType.Consolidated"/>,
		/// <see cref="StudentLoanStatusType.PaidInFull"/>, or <see cref="StudentLoanStatusType.Transferred"/>
		/// </summary>
		[JsonPropertyName("next_payment_due_date")]
		public DateTime? NextPaymentDueDate { get; init; }

		/// <summary>
		/// The date on which the loan was initially lent.
		/// </summary>
		[JsonPropertyName("origination_date")]
		public DateTime? OriginationDate { get; init; }

		/// <summary>
		/// The original principal balance of the loan.
		/// </summary>
		[JsonPropertyName("origination_principal_amount")]
		public decimal? OriginationPrincipalAmount { get; init; }

		/// <summary>
		/// The total dollar amount of the accrued interest balance. For Sallie Mae (ins_116944), this amount is included in the current balance of the loan, so this field will return as <c>null</c>.
		/// </summary>
		[JsonPropertyName("outstanding_interest_amount")]
		public decimal? OutstandingInterestAmount { get; init; }

		/// <summary>
		/// The relevant account number that should be used to reference this loan for payments. 
		/// </summary>
		/// <remarks>
		/// In the majority of cases, <see cref="PaymentReferenceNumber"/> will match <see cref="AccountNumber"/>, 
		/// but in some institutions, such as Great Lakes (ins_116861), it will be different.
		/// </remarks>
		[JsonPropertyName("payment_reference_number")]
		public string? PaymentReferenceNumber { get; init; }

		/// <summary>
		/// Information about the student's eligibility in the Public Service Loan Forgiveness program. 
		/// </summary>
		/// <remarks>This is only returned if the institution is Fedloan (ins_116527).</remarks>
		[JsonPropertyName("pslf_status")]
		public PslfStatus? PslfStatus { get; init; }

		/// <summary>
		/// An object representing the repayment plan for the student loan
		/// </summary>
		[JsonPropertyName("repayment_plan")]
		public RepaymentPlan RepaymentPlan { get; init; }

		/// <summary>
		/// The sequence number of the student loan. 
		/// </summary>
		/// <remarks>Heartland ECSI (ins_116948) does not make this field available.</remarks>
		[JsonPropertyName("sequence_number")]
		public string? SequenceNumber { get; init; }

		/// <summary>
		/// The address of the student loan servicer.
		/// </summary>
		[JsonPropertyName("servicer_address")]
		public Address? ServicerAddress { get; init; }

		/// <summary>
		/// The year to date (YTD) interest paid. 
		/// </summary>
		/// <remarks>Availability for this field is limited.</remarks>
		[JsonPropertyName("ytd_interest_paid")]
		public decimal? YtdInterestPaid { get; init; }

		/// <summary>
		/// The year to date (YTD) principal paid. 
		/// </summary>
		/// <remarks>Availability for this field is limited.</remarks>
		[JsonPropertyName("ytd_principal_paid")]
		public decimal? YtdPrincipalPaid { get; init; }
	}

	/// <summary>
	/// An object representing the status of the student loan
	/// </summary>
	public struct StudentLoanStatus
	{
		/// <summary>
		/// The date until which the loan will be in its current status.
		/// </summary>
		[JsonPropertyName("end_date")]
		public DateTime? EndDate { get; init; }

		/// <summary>
		/// The status type of the student loan
		/// </summary>
		[JsonPropertyName("type")]
		public StudentLoanStatusType? Type { get; init; }
	}

	/// <summary>
	/// The status type of the student loan
	/// </summary>
	public enum StudentLoanStatusType
	{
		/// <summary>
		/// cancelled
		/// </summary>
		[EnumMember(Value = "cancelled")]
		Cancelled,

		/// <summary>
		/// charged off
		/// </summary>
		[EnumMember(Value = "charged off")]
		ChargedOff,

		/// <summary>
		/// claim
		/// </summary>
		[EnumMember(Value = "claim")]
		Claim,

		/// <summary>
		/// consolidated
		/// </summary>
		[EnumMember(Value = "consolidated")]
		Consolidated,

		/// <summary>
		/// deferment
		/// </summary>
		[EnumMember(Value = "deferment")]
		Deferment,

		/// <summary>
		/// delinquent
		/// </summary>
		[EnumMember(Value = "delinquent")]
		Delinquent,

		/// <summary>
		/// discharged
		/// </summary>
		[EnumMember(Value = "discharged")]
		Discharged,

		/// <summary>
		/// extension
		/// </summary>
		[EnumMember(Value = "extension")]
		Extension,

		/// <summary>
		/// forbearance
		/// </summary>
		[EnumMember(Value = "forbearance")]
		Forbearance,

		/// <summary>
		/// in grace
		/// </summary>
		[EnumMember(Value = "in grace")]
		InGrace,

		/// <summary>
		/// in military
		/// </summary>
		[EnumMember(Value = "in military")]
		InMilitary,

		/// <summary>
		/// in school
		/// </summary>
		[EnumMember(Value = "in school")]
		InSchool,

		/// <summary>
		/// not fully disbursed
		/// </summary>
		[EnumMember(Value = "not fully disbursed")]
		NotFullyDisbursed,

		/// <summary>
		/// other
		/// </summary>
		[EnumMember(Value = "other")]
		Other,

		/// <summary>
		/// paid in full
		/// </summary>
		[EnumMember(Value = "paid in full")]
		PaidInFull,

		/// <summary>
		/// refunded
		/// </summary>
		[EnumMember(Value = "refunded")]
		Refunded,

		/// <summary>
		/// repayment
		/// </summary>
		[EnumMember(Value = "repayment")]
		Repayment,

		/// <summary>
		/// transferred
		/// </summary>
		[EnumMember(Value = "transferred")]
		Transferred,

	}

	/// <summary>
	/// Information about the student's eligibility in the Public Service Loan Forgiveness program. 
	/// </summary>
	public struct PslfStatus
	{
		/// <summary>
		/// The estimated date borrower will have completed 120 qualifying monthly payments.
		/// </summary>
		[JsonPropertyName("estimated_eligibility_date")]
		public DateTime? EstimatedEligibilityDate { get; init; }

		/// <summary>
		/// The number of qualifying payments that have been made.
		/// </summary>
		[JsonPropertyName("payments_made")]
		public int? PaymentsMade { get; init; }

		/// <summary>
		/// The number of qualifying payments remaining.
		/// </summary>
		[JsonPropertyName("payments_remaining")]
		public int? PaymentsRemaining { get; init; }
	}

	/// <summary>
	/// An object representing the repayment plan for the student loan
	/// </summary>
	public struct RepaymentPlan
	{
		/// <summary>
		/// The description of the repayment plan as provided by the servicer.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }

		/// <summary>
		/// The type of the repayment plan.
		/// </summary>
		[JsonPropertyName("type")]
		public RepaymentPlanType? Type { get; init; }
	}

	/// <summary>
	/// The type of repayment plan
	/// </summary>
	public enum RepaymentPlanType
	{
		/// <summary>
		/// extended graduated
		/// </summary>
		[EnumMember(Value = "extended graduated")]
		ExtendedGraduated,

		/// <summary>
		/// extended standard
		/// </summary>
		[EnumMember(Value = "extended standard")]
		ExtendedStandard,

		/// <summary>
		/// graduated
		/// </summary>
		[EnumMember(Value = "graduated")]
		Graduated,

		/// <summary>
		/// income-contingent repayment
		/// </summary>
		[EnumMember(Value = "income-contingent repayment")]
		IncomeContingentRepayment,

		/// <summary>
		/// income-based repayment
		/// </summary>
		[EnumMember(Value = "income-based repayment")]
		IncomeBasedRepayment,

		/// <summary>
		/// interest-only
		/// </summary>
		[EnumMember(Value = "interest-only")]
		InterestOnly,

		/// <summary>
		/// other
		/// </summary>
		[EnumMember(Value = "other")]
		Other,

		/// <summary>
		/// pay as you earn
		/// </summary>
		[EnumMember(Value = "pay as you earn")]
		PayAsYouEarn,

		/// <summary>
		/// revised pay as you earn
		/// </summary>
		[EnumMember(Value = "revised pay as you earn")]
		RevisedPayAsYouEarn,

		/// <summary>
		/// standard
		/// </summary>
		[EnumMember(Value = "standard")]
		Standard,
	}
}
