using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Entity
{
	public class Liabilities
	{
		[JsonProperty("credit")]
		public Credit[] Credit { get; set; }

		[JsonProperty("mortgage")]
		public Mortgage[] Mortgage { get; set; }

		[JsonProperty("student")]
		public StudentLoan[] StudentLoans { get; set; }
	}
}
