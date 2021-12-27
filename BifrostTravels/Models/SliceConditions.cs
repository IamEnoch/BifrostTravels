using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class SliceConditions
    {
        [JsonProperty("change_before_departure")]
        public object? ChangeBeforeDeparture { get; set; }
    }
}