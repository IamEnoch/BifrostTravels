using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BifrostTravels.Models
{
    public class Segment
    {
        [JsonProperty("passengers")]
        public List<Passenger> Passengers { get; set; }

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
}