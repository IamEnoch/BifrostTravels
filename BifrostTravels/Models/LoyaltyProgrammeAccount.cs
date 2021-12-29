using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class LoyaltyProgrammeAccount
    {
        [JsonProperty("airline_iata_code")]
        public string AirlineIataCode { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }
    }
}