using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BifrostTravels.Models
{
    public class OfferResponseBody
    {
        [JsonProperty("data")]
        public OfferResponseData Data { get; set; }
    }
    
}

