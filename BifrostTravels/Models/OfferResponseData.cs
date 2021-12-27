using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class OfferResponseData
    {
        [JsonProperty("slices")]
        public List<Slice> Slices { get; set; }

        [JsonProperty("passengers")]
        public List<Passenger> Passengers { get; set; }

        [JsonProperty("offers")]
        public List<Offer> Offers { get; set; }

        [JsonProperty("live_mode")]
        public bool LiveMode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("cabin_class")]
        public string CabinClass { get; set; }
    }
}