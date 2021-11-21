using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BifrostTravels.Models
{
    public class SeriesOfOffers
    {
        [JsonProperty("data")]
        public OfferResponseData Data { get; set; }
    }

    public class OfferResponseData
    {
        [JsonProperty("slices")]
        public List<OfferResponseSlice> Slices { get; set; }

        [JsonProperty("passengers")]
        public List<Passenger> Passengers { get; set; }

        [JsonProperty("offers")]
        public List<Offer> Offers { get; set; }

        [JsonProperty("live_mode")]
        public bool LiveMode { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("cabin_class")]
        public string CabinClass { get; set; }
    }

    public class OfferResponseSlice
    {
        [JsonProperty("origin_type")]
        public string OriginType { get; set; }

        [JsonProperty("origin")]
        public Origin Origin { get; set; }

        [JsonProperty("destination_type")]
        public string DestinationType { get; set; }

        [JsonProperty("destination")]
        public Destination Destination { get; set; }

        [JsonProperty("departure_date")]
        public DateTimeOffset DepartureDate { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }

    /*public class OfferResponsePassenger
    {
        [JsonProperty("passengers")]
        public List<Passenger> Passengers { get; set; }
    }*/

    /*public class OfferResponseOffers
    {
        [JsonProperty("offers")]
        public List<Offer> Offers { get; set; }
    }*/

    public class Origin
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("icao_code")]
        public string IcaoCode { get; set; }

        [JsonProperty("iata_country_code")]
        public string IataCountryCode { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("iata_city_code")]
        public string IataCityCode { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("airports")]
        public List<Airports>? Airports { get; set; }
    }


    public class Destination
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("icao_code")]
        public string IcaoCode { get; set; }

        [JsonProperty("iata_country_code")]
        public string IataCountryCode { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("iata_city_code")]
        public string IataCityCode { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("airports")]
        public List<Airports>? Airports { get; set; }
    }

    public class Airports
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("icao_code")]
        public object IcaoCode { get; set; }

        [JsonProperty("iata_country_code")]
        public string IataCountryCode { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("iata_city_code")]
        public string IataCityCode { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }
    }

    public class City
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("time_zone")]
        public object? TimeZone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longitude")]
        public object? Longitude { get; set; }

        [JsonProperty("latitude")]
        public object? Latitude { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("icao_code")]
        public object? IcaoCode { get; set; }

        [JsonProperty("iata_country_code")]
        public string IataCountryCode { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("iata_city_code")]
        public string IataCityCode { get; set; }

        [JsonProperty("city_name")]
        public string? CityName { get; set; }
    }

    public class Passenger
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("loyalty_programme_accounts")]
        public List<LoyaltyProgrammeAccount> LoyaltyProgrammeAccounts { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("given_name")]
        public string? GivenName { get; set; }

        [JsonProperty("family_name")]
        public string? FamilyName { get; set; }

        [JsonProperty("age")]
        public int? Age { get; set; }
    }

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
        public List<OffersSlice> Slices { get; set; }

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
        public List<object> AllowedPassengerIdentityDocumentTypes { get; set; }
    }

    public class OfferConditions
    {
        [JsonProperty("refund_before_departure")]
        public object? RefundBeforeDeparture { get; set; }

        [JsonProperty("change_before_departure")]
        public object? ChangeBeforeDeparture { get; set; }
    }

    public class Owner
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }
    }

    public class PaymentRequirements
    {
        [JsonProperty("requires_instant_payment")]
        public bool RequiresInstantPayment { get; set; }

        [JsonProperty("price_guarantee_expires_at")]
        public DateTime? PriceGuaranteeExpiresAt { get; set; }

        [JsonProperty("payment_required_by")]
        public object? PaymentRequiredBy { get; set; }
    }

    public class OffersSlice
    {
        [JsonProperty("segments")]
        public List<Segment> Segments { get; set; }

        [JsonProperty("origin_type")]
        public string OriginType { get; set; }

        [JsonProperty("origin")]
        public Origin Origin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fare_brand_name")]
        public string FareBrandName { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("destination_type")]
        public string DestinationType { get; set; }

        [JsonProperty("destination")]
        public Destination Destination { get; set; }

        [JsonProperty("conditions")]
        public SliceConditions Conditions { get; set; }
    }

    public class SliceConditions
    {
        [JsonProperty("change_before_departure")]
        public object? ChangeBeforeDeparture { get; set; }
    }

    public class Segment
    {
        [JsonProperty("passengers")]
        public List<PurplePassenger> Passengers { get; set; }

        [JsonProperty("origin_terminal")]
        public string? OriginTerminal { get; set; }

        [JsonProperty("origin")]
        public Origin Origin { get; set; }

        [JsonProperty("operating_carrier_flight_number")]
        public object? OperatingCarrierFlightNumber { get; set; }

        [JsonProperty("operating_carrier")]
        public OperatingCarrier OperatingCarrier { get; set; }

        [JsonProperty("marketing_carrier_flight_number")]
        public string MarketingCarrierFlightNumber { get; set; }

        [JsonProperty("marketing_carrier")]
        public MarketingCarrier MarketingCarrier { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("distance")]
        public string? Distance { get; set; }

        [JsonProperty("destination_terminal")]
        public string? DestinationTerminal { get; set; }

        [JsonProperty("destination")]
        public Destination Destination { get; set; }

        [JsonProperty("departing_at")]
        public DateTime DepartingAt { get; set; }

        [JsonProperty("arriving_at")]
        public DateTime ArrivingAt { get; set; }

        [JsonProperty("aircraft")]
        public Aircraft? Aircraft { get; set; }
    }

    public class PurplePassenger
    {
        [JsonProperty("passenger_id")]
        public string PassengerId { get; set; }

        [JsonProperty("fare_basis_code")]
        public string FareBasisCode { get; set; }

        [JsonProperty("cabin_class_marketing_name")]
        public string CabinClassMarketingName { get; set; }

        [JsonProperty("cabin_class")]
        public string CabinClass { get; set; }

        [JsonProperty("baggages")]
        public List<Baggage> Baggages { get; set; }
    }

    public class Baggage
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class OperatingCarrier
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }
    }

    public class MarketingCarrier
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }
    }

    public class LoyaltyProgrammeAccount
    {
        [JsonProperty("airline_iata_code")]
        public string? AirlineIataCode { get; set; }

        [JsonProperty("account_number")]
        public string? AccountNumber { get; set; }
    }

    public partial class Aircraft
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iata_code")]       
        public string IataCode { get; set; }
    }



}

