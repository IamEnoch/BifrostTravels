using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public partial class Aircraft
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iata_code")]       
        public string IataCode { get; set; }
    }
}