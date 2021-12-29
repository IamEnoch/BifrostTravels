using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    internal class OfferDetailsBody
    {
        public class OfferDetailsData
        {
            [JsonProperty("data")]
            public Offer Data { get; set; }
        }
    }
}
