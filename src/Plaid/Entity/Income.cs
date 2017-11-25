using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Represents an user earnings.
    /// </summary>
    public class Income
    {
        /// <summary>
        /// Gets or sets the last year income.
        /// </summary>
        /// <value>The last year income.</value>
        [JsonProperty("last_year_income")]
        public float LastYearIncome { get; set; }

        /// <summary>
        /// Gets or sets the last year income before tax.
        /// </summary>
        /// <value>The last year income before tax.</value>
        [JsonProperty("last_year_income_before_tax")]
        public float LastYearIncomeBeforeTax { get; set; }

        /// <summary>
        /// Gets or sets the projected yearly income.
        /// </summary>
        /// <value>The projected yearly income.</value>
        [JsonProperty("projected_yearly_income")]
        public float ProjectedYearlyIncome { get; set; }

        /// <summary>
        /// Gets or sets the projected yearly income before tax.
        /// </summary>
        /// <value>The projected yearly income before tax.</value>
        [JsonProperty("projected_yearly_income_before_tax")]
        public float ProjectedYearlyIncomeBeforeTax { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of overlapping income streams.
        /// </summary>
        /// <value>The maximum number of overlapping income streams.</value>
        [JsonProperty("max_number_of_overlapping_income_streams")]
        public int MaxNumberOfOverlappingIncomeStreams { get; set; }

        /// <summary>
        /// Gets or sets the total income streams.
        /// </summary>
        /// <value>The total income streams.</value>
        [JsonProperty("number_of_income_streams")]
        public int TotalIncomeStreams { get; set; }

        /// <summary>
        /// Gets or sets the icome streams.
        /// </summary>
        /// <value>The streams.</value>
        [JsonProperty("income_streams")]
        public Stream[] Streams { get; set; }

        /// <summary>
        /// Represents an income stream.
        /// </summary>
        public struct Stream
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>The name.</value>
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the days.
            /// </summary>
            /// <value>The days.</value>
            [JsonProperty("days")]
            public int Days { get; set; }

            /// <summary>
            /// Gets or sets the monthly income.
            /// </summary>
            /// <value>The monthly income.</value>
            [JsonProperty("monthly_income")]
            public float MonthlyIncome { get; set; }

            /// <summary>
            /// Gets or sets the confidence.
            /// </summary>
            /// <value>The confidence.</value>
            [JsonProperty("confidence")]
            public float Confidence { get; set; }
        }
    }
}