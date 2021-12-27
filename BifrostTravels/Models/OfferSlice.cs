using System.Collections.Generic;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class OfferSlice
    {
        [JsonProperty("segments")]
        public List<Segment> Segments { get; set; }

        [JsonProperty("origin_type")]
        public string OriginType { get; set; }

        [JsonProperty("origin")]
        public Origin Origin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fare_brand_name")]
        public string FareBrandName { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("destination_type")]
        public string DestinationType { get; set; }

        [JsonProperty("destination")]
        public Destination Destination { get; set; }

        [JsonProperty("conditions")]
        public SliceConditions Conditions { get; set; }
    }
}