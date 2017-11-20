using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    public class Income
    {
        [JsonProperty("last_year_income")]
        public float LastYearIncome { get; set; }

        [JsonProperty("last_year_income_before_tax")]
        public float LastYearIncomeBeforeTax { get; set; }

        [JsonProperty("projected_yearly_income")]
        public float ProjectedYearlyIncome { get; set; }

        [JsonProperty("projected_yearly_income_before_tax")]
        public float ProjectedYearlyIncomeBeforeTax { get; set; }

        [JsonProperty("max_number_of_overlapping_income_streams")]
        public int MaxNumberOfOverlappingIncomeStreams { get; set; }

        [JsonProperty("number_of_income_streams")]
        public int TotalIncomeStreams { get; set; }

        [JsonProperty("income_streams")]
        public Stream[] Streams { get; set; }

        public struct Stream
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("days")]
            public int Days { get; set; }

            [JsonProperty("monthly_income")]
            public float MonthlyIncome { get; set; }

            [JsonProperty("confidence")]
            public float Confidence { get; set; }
        }
    }
}