using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BifrostTravels.Models
{
    public class OffersResponseBody
    {
        [JsonProperty("data")]
        public OffersResponseData Data { get; set; }
    }
    
}

