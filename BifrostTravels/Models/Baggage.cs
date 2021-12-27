using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class Baggage
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}