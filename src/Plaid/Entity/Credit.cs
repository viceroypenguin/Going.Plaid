using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Entity
{
	public class Credit
	{
		[JsonProperty("account_id")]
		public string AccountId { get; set; }

		[JsonProperty("aprs")]
		public Apr[] Aprs { get; set; }

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

		[JsonProperty("minimum_payment_amount")]
		public int MinimumPaymentAmount { get; set; }

		[JsonProperty("next_payment_due_date")]
		public string NextPaymentDueDate { get; set; }

		public struct Apr
		{
			[JsonProperty("apr_percentage")]
			public double AprPercentage { get; set; }

			[JsonProperty("apr_type")]
			public string AprType { get; set; }

			[JsonProperty("balance_subject_to_apr")]
			public double BalanceSubjectToApr { get; set; }

			[JsonProperty("interest_charge_amount")]
			public double InterestChargeAmount { get; set; }
		}
	}
}
