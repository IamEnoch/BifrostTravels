using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class OperatingCarrier
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }
    }
}