using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BifrostTravels.Models
{
    public class OfferRequestPayload
    {
        [JsonProperty("data")]
        public OffersRequestData Data { get; set; }
    }
}

