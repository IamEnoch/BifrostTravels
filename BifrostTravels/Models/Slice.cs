using System;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class Slice
    {
        [JsonProperty("origin_type")]
        public string OriginType { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination_type")]
        public string DestinationType { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("departure_date")]
        public DateTime DepartureDate { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}