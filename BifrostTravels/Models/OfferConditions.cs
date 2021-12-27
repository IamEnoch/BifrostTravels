using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class OfferConditions
    {
        [JsonProperty("refund_before_departure")]
        public object? RefundBeforeDeparture { get; set; }

        [JsonProperty("change_before_departure")]
        public object? ChangeBeforeDeparture { get; set; }
    }
}