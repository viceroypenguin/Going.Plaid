using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    public class Score
    {
        [JsonProperty(JName.Location)]
        public Place Location { get; set; }

        [JsonProperty(JName.Name)]
        public float Value { get; set; }

        public struct Place
        {
            [JsonProperty(JName.Address)]
            public int? Address { get; set; }

            [JsonProperty(JName.City)]
            public int? City { get; set; }

            [JsonProperty(JName.State)]
            public int? State { get; set; }

            [JsonProperty(JName.Zip)]
            public int? Zip { get; set; }
        }
    }
}