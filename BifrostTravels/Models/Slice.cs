using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class Slice
    {
        [JsonProperty("origin_type")]
        public string OriginType { get; set; }

        [JsonProperty("destination_type")]
        public string DestinationType { get; set; }

        [JsonProperty("departure_date")]
        public DateTime DepartureDate { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

    }
    /// <summary>
    /// Request offer slice
    /// </summary>
    public class RequestOfferSlice : Slice
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
    /// <summary>
    /// Response offer slice
    /// </summary>
    public class ResponseOfferSlice : Slice
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
    /// <summary>
    /// Slice for a particular offer
    /// </summary>
    public class OfferSlice : Slice
    {
        [JsonProperty("segments")]
        public List<Segment> Segments { get; set; }

        [JsonProperty("origin")]
        public Origin Origin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fare_brand_name")]
        public string FareBrandName { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("destination")]
        public Destination Destination { get; set; }

        [JsonProperty("conditions")]
        public SliceConditions Conditions { get; set; }
    }
}