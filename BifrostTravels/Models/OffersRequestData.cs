using System.Collections.Generic;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class OffersRequestData
    {
        [JsonProperty("slices")] public List<RequestOfferSlice> Slices { get; set; }

        [JsonProperty("passengers")] public List<Passenger> Passengers { get; set; }

        [JsonProperty("cabin_class")] public string CabinClass { get; set; }
    }
}