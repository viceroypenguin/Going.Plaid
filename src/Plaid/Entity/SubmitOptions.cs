using Newtonsoft.Json;
using System;

namespace Acklann.Plaid.Entity
{
    public class SubmitOptions
    {
        public SubmitOptions()
        {
            EndDate = DateTime.Now;
            StartDate = DateTime.Now.Subtract(TimeSpan.FromDays(30));
        }

        [JsonProperty("webhook")]
        public string WebHook { get; set; }

        [JsonProperty("pending")]
        public bool Pending { get; set; }

        [JsonProperty("login_only")]
        public bool LoginOnly { get; set; }

        [JsonProperty("list")]
        public bool List { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }
    }
}