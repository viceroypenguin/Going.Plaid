using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Entity
{
	public class StudentLoan
	{
		[JsonProperty("account_id")]
		public string AccountId { get; set; }

		[JsonProperty("account_number")]
		public string AccountNumber { get; set; }

		[JsonProperty("disbursement_dates")]
		public string[] DisbursementDates { get; set; }

		[JsonProperty("expected_payoff_date")]
		public string ExpectedPayoffDate { get; set; }

		[JsonProperty("guarantor")]
		public string Guarantor { get; set; }

		[JsonProperty("interest_rate_percentage")]
		public double InterestRatePercentage { get; set; }

		[JsonProperty("is_overdue")]
		public bool IsOverdue { get; set; }

		[JsonProperty("last_payment_amount")]
		public double LastPaymentAmount { get; set; }

		[JsonProperty("last_payment_date")]
		public string LastPaymentDate { get; set; }

		[JsonProperty("last_statement_balance")]
		public double LastStatementBalance { get; set; }

		[JsonProperty("last_statement_issue_date")]
		public string LastStatementIssueDate { get; set; }

		[JsonProperty("loan_name")]
		public string LoanName { get; set; }

		[JsonProperty("loan_status")]
		public StudentLoanStatus LoanStatus { get; set; }

		[JsonProperty("minimum_payment_amount")]
		public int MinimumPaymentAmount { get; set; }

		[JsonProperty("next_payment_due_date")]
		public string NextPaymentDueDate { get; set; }

		[JsonProperty("origination_date")]
		public string OriginationDate { get; set; }

		[JsonProperty("origination_principal_amount")]
		public int OriginationPrincipalAmount { get; set; }

		[JsonProperty("outstanding_interest_amount")]
		public double OutstandingInterestAmount { get; set; }

		[JsonProperty("payment_reference_number")]
		public string PaymentReferenceNumber { get; set; }

		[JsonProperty("pslf_status")]
		public PslfStatus PslfStatus { get; set; }

		[JsonProperty("repayment_plan")]
		public RepaymentPlan RepaymentPlan { get; set; }

		[JsonProperty("sequence_number")]
		public string SequenceNumber { get; set; }

		[JsonProperty("servicer_address")]
		public ServicerAddress ServicerAddress { get; set; }

		[JsonProperty("ytd_interest_paid")]
		public double YtdInterestPaid { get; set; }

		[JsonProperty("ytd_principal_paid")]
		public double YtdPrincipalPaid { get; set; }
	}

	public struct StudentLoanStatus
	{
		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}

	public struct PslfStatus
	{
		[JsonProperty("estimated_eligibility_date")]
		public string EstimatedEligibilityDate { get; set; }

		[JsonProperty("payments_made")]
		public int PaymentsMade { get; set; }

		[JsonProperty("payments_remaining")]
		public int PaymentsRemaining { get; set; }
	}

	public struct RepaymentPlan
	{
		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}

	public struct ServicerAddress
	{
		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("postal_code")]
		public string PostalCode { get; set; }

		[JsonProperty("region")]
		public string Region { get; set; }

		[JsonProperty("street")]
		public string Street { get; set; }
	}
}
