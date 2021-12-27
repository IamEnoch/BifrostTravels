using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class Owner
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }
    }
}