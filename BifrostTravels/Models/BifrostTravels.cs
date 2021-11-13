using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BifrostTravels.Models
{
    public class OfferRequestPayload
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("slices")]
        public List<Slice> Slices { get; set; }

        [JsonProperty("passengers")]
        public List<Passenger> Passengers { get; set; }

        [JsonProperty("cabin_class")]
        public string CabinClass { get; set; }
    }

    public class Passenger
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Slice
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("departure_date")]
        public DateTime DepartureDate { get; set; }
    }
}

