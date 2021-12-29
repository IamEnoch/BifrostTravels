using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class Offer
    {
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("total_emissions_kg")]
        public string TotalEmissionsKg { get; set; }

        [JsonProperty("total_currency")]
        public string TotalCurrency { get; set; }

        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        [JsonProperty("tax_currency")]
        public string TaxCurrency { get; set; }

        [JsonProperty("tax_amount")]
        public string TaxAmount { get; set; }

        [JsonProperty("slices")]
        public List<OfferSlice> Slices { get; set; }

        [JsonProperty("payment_requirements")]
        public PaymentRequirements PaymentRequirements { get; set; }

        [JsonProperty("passengers")]
        public List<Passenger> Passengers { get; set; }

        [JsonProperty("passenger_identity_documents_required")]
        public bool PassengerIdentityDocumentsRequired { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("live_mode")]
        public bool LiveMode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("conditions")]
        public OfferConditions Conditions { get; set; }

        [JsonProperty("base_currency")]
        public string BaseCurrency { get; set; }

        [JsonProperty("base_amount")]
        public string BaseAmount { get; set; }

        [JsonProperty("allowed_passenger_identity_document_types")]
        public List<string> AllowedPassengerIdentityDocumentTypes { get; set; }
    }
}