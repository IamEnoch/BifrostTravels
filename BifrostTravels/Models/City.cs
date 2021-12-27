using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class City
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("time_zone")]
        public object? TimeZone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longitude")]
        public object? Longitude { get; set; }

        [JsonProperty("latitude")]
        public object? Latitude { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("icao_code")]
        public object? IcaoCode { get; set; }

        [JsonProperty("iata_country_code")]
        public string IataCountryCode { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("iata_city_code")]
        public string IataCityCode { get; set; }

        [JsonProperty("city_name")]
        public string? CityName { get; set; }
    }
}