using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Entity
{
	public class Mortgage
	{
		[JsonProperty("account_id")]
		public string AccountId { get; set; }

		[JsonProperty("accountNumber")]
		public long AccountNumber { get; set; }

		[JsonProperty("currentLateFee")]
		public int CurrentLateFee { get; set; }

		[JsonProperty("escrowBalance")]
		public double EscrowBalance { get; set; }

		[JsonProperty("hasPmi")]
		public bool HasPmi { get; set; }

		[JsonProperty("hasPrepaymentPenalty")]
		public bool HasPrepaymentPenalty { get; set; }

		[JsonProperty("interestRate")]
		public InterestRate InterestRate { get; set; }

		[JsonProperty("lastPaymentAmount")]
		public double LastPaymentAmount { get; set; }

		[JsonProperty("lastPaymentDate")]
		public string LastPaymentDate { get; set; }

		[JsonProperty("loanTerm")]
		public string LoanTerm { get; set; }

		[JsonProperty("loanTypeDescription")]
		public string LoanTypeDescription { get; set; }

		[JsonProperty("maturityDate")]
		public string MaturityDate { get; set; }

		[JsonProperty("nextMonthlyPayment")]
		public double NextMonthlyPayment { get; set; }

		[JsonProperty("nextPaymentDueDate")]
		public string NextPaymentDueDate { get; set; }

		[JsonProperty("originationDate")]
		public string OriginationDate { get; set; }

		[JsonProperty("originationPrincipalAmount")]
		public int OriginationPrincipalAmount { get; set; }

		[JsonProperty("pastDueAmount")]
		public int PastDueAmount { get; set; }

		[JsonProperty("propertyAddress")]
		public PropertyAddress PropertyAddress { get; set; }

		[JsonProperty("ytdInterestPaid")]
		public double YtdInterestPaid { get; set; }

		[JsonProperty("ytdPrincipalPaid")]
		public double YtdPrincipalPaid { get; set; }
	}

	public struct InterestRate
	{
		[JsonProperty("percentage")]
		public double Percentage { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}

	public struct PropertyAddress
	{
		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("postalCode")]
		public int PostalCode { get; set; }

		[JsonProperty("region")]
		public string Region { get; set; }

		[JsonProperty("street")]
		public string Street { get; set; }
	}
}
