using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class Airports
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("icao_code")]
        public object IcaoCode { get; set; }

        [JsonProperty("iata_country_code")]
        public string IataCountryCode { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("iata_city_code")]
        public string IataCityCode { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }
    }
}