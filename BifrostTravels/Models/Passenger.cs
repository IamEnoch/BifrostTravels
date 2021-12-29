using System.Collections.Generic;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class Passenger
    {
        [JsonProperty("passenger_id")]
        public string PassengerId { get; set; }

        [JsonProperty("fare_basis_code")]
        public string FareBasisCode { get; set; }

        [JsonProperty("cabin_class_marketing_name")]
        public string CabinClassMarketingName { get; set; }

        [JsonProperty("cabin_class")]
        public string CabinClass { get; set; }

        [JsonProperty("baggages")]
        public List<Baggage> Baggages { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("loyalty_programme_accounts")]
        public List<LoyaltyProgrammeAccount> LoyaltyProgrammeAccounts { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("given_name")]
        public string? GivenName { get; set; }

        [JsonProperty("family_name")]
        public string? FamilyName { get; set; }

        [JsonProperty("age")]
        public int? Age { get; set; }

        public Passenger()
        {
            LoyaltyProgrammeAccounts = new List<LoyaltyProgrammeAccount>();

        }
    }
}