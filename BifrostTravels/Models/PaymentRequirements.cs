using System;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class PaymentRequirements
    {
        [JsonProperty("requires_instant_payment")]
        public bool RequiresInstantPayment { get; set; }

        [JsonProperty("price_guarantee_expires_at")]
        public DateTime? PriceGuaranteeExpiresAt { get; set; }

        [JsonProperty("payment_required_by")]
        public object? PaymentRequiredBy { get; set; }
    }
}