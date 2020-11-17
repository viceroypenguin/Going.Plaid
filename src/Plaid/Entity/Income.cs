using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents an user earnings.
	/// </summary>
	public class Income
	{
		/// <summary>
		/// The sum of the <see cref="Item"/>’s income over the past 365 days. If we have less than 365 days of data this will be less than a full year's income.
		/// </summary>
		[JsonPropertyName("last_year_income")]
		public decimal LastYearIncome { get; init; }

		/// <summary>
		/// <see cref="LastYearIncome"/> interpolated to value before taxes. This is the minimum pre-tax salary that assumes a filing status of single with zero dependents.
		/// </summary>
		[JsonPropertyName("last_year_income_before_tax")]
		public decimal LastYearIncomeBeforeTax { get; init; }

		/// <summary>
		/// <see cref="Item"/>’s income extrapolated over a year based on current, active income streams. Income streams become inactive if they have not recurred for more than two cycles. For example, if a weekly paycheck hasn’t been seen for the past two weeks, it's no longer active.
		/// </summary>
		[JsonPropertyName("projected_yearly_income")]
		public decimal ProjectedYearlyIncome { get; init; }

		/// <summary>
		/// <see cref="ProjectedYearlyIncome"/> interpolated to value before taxes. This is the minimum pre-tax salary that assumes a filing status of single with zero dependents.
		/// </summary>
		[JsonPropertyName("projected_yearly_income_before_tax")]
		public decimal ProjectedYearlyIncomeBeforeTax { get; init; }

		/// <summary>
		/// Max number of income streams present at the same time over the past 365 days.
		/// </summary>
		[JsonPropertyName("max_number_of_overlapping_income_streams")]
		public int MaxNumberOfOverlappingIncomeStreams { get; init; }

		/// <summary>
		/// Total number of distinct income streams received over the past 365 days.
		/// </summary>
		[JsonPropertyName("number_of_income_streams")]
		public int TotalIncomeStreams { get; init; }

		/// <summary>
		/// An array of income streams with detailed information on each.
		/// </summary>
		[JsonPropertyName("income_streams")]
		public Stream[] Streams { get; init; } = null!;

		/// <summary>
		/// Represents an income stream.
		/// </summary>
		public class Stream
		{
			/// <summary>
			/// Name of the entity associated with this income stream.
			/// </summary>
			[JsonPropertyName("name")]
			public string Name { get; init; } = null!;

			/// <summary>
			/// Extent of data found for this income stream.
			/// </summary>
			[JsonPropertyName("days")]
			public int Days { get; init; }

			/// <summary>
			/// The monthly income associated with the income stream.
			/// </summary>
			[JsonPropertyName("monthly_income")]
			public decimal MonthlyIncome { get; init; }

			/// <summary>
			/// A numeric representation of our confidence in the income data associated with this particular income stream, with 0 being the lowest confidence and 1 being the highest.
			/// </summary>
			[JsonPropertyName("confidence")]
			public decimal Confidence { get; init; }
		}
	}
}
