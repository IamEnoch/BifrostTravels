using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using BifrostTravels.Helpers;
using BifrostTravels.Models;
using Newtonsoft.Json;
using ConsoleTables;


namespace BifrostTravels
{
    class Program
    {
        public static HttpDataHelper DataHelper { get; set; }
        static async Task Main(string[] args)
        {
            var headers = new List<(string name, string value)>
            {
                ("Accept", "application/json"),
                ("Duffel-Version", "beta")
            };

            DataHelper = new HttpDataHelper("https://api.duffel.com/air/", "duffel_test_bQFowLbLyIEq-1xdZUKxOibMlO9xMFs5Us5NTK-l-SY", headers);

            //A list of slices where we can house multiple slices
            //Payload only accepts a list of slices
            var slices = new List<OfferRequestSlice>();

            Console.WriteLine("Enter the journey mode. \n1.oneway \n2.returnflight \n3.multi_city");
            var journeyMode = GetJourneyMode();

            if (journeyMode == JourneyMode.oneway.ToString())
            {
                Console.WriteLine("Enter the city of origin");
                var origin = GetOrigin();

                Console.WriteLine("Enter the city of destination");
                var destination = GetDestination();

                Console.WriteLine("Enter the date of departure");
                var departureDate = GetDepartureDate();

                var slice = new OfferRequestSlice
                {
                    DepartureDate = departureDate,
                    Origin = origin,
                    Destination = destination
                };
                slices.Add(slice);
            }

            else if (journeyMode == JourneyMode.returnflight.ToString()) 
            {
                Console.WriteLine("Enter the city of origin");
                var origin = GetOrigin();

                Console.WriteLine("Enter the city of destination");
                var destination = GetDestination();

                Console.WriteLine("Enter the date of departure");
                var departureDate = GetDepartureDate();

                Console.WriteLine("Enter the return date");
                var returnDate = GetDepartureDate();

                var slice1 = new OfferRequestSlice
                {
                    DepartureDate = departureDate,
                    Origin = origin,
                    Destination = destination
                };
                var slice2 = new OfferRequestSlice
                {
                    DepartureDate = returnDate,
                    Origin = destination,
                    Destination = origin
                };
                slices.Add(slice1);
                slices.Add(slice2);
            }
            else
            {
                Console.WriteLine("Enter the number of flights you wish to book flights for");
                var numberOfFlights = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numberOfFlights; i++)
                {
                    Console.WriteLine("Enter the city of origin");
                    var origin = GetOrigin();

                    Console.WriteLine("Enter the city of destination");
                    var destination = GetDestination();

                    Console.WriteLine("Enter the date of departure");
                    var departureDate = GetDepartureDate();

                    var slice = new OfferRequestSlice
                    {
                        DepartureDate = departureDate,
                        Origin = origin,
                        Destination = destination
                    };

                    slices.Add(slice);
                }
            }

            Console.WriteLine("Enter the cabin class. \n1.first \n2.business \n3.premium_economy \n4.economy");
            var cabinClass = GetCabinClass();

            var passengers = GetPassengers();

            var data = new OffersRequestData
            {
                Slices = slices,
                Passengers = passengers,
                CabinClass = cabinClass
            };
            OfferRequestPayload payload = new OfferRequestPayload { Data = data };

            var result = await DataHelper.PostItemAsync("offer_requests", payload);
            Console.WriteLine();

            Console.ForegroundColor = result.IsSuccessful ? ConsoleColor.Green : ConsoleColor.Red;

            var objectString = JsonConvert.SerializeObject(result.ReturnObj);
            var offerResponseObject = JsonConvert.DeserializeObject<SeriesOfOffers>(objectString);

            
            var vitals = new ConsoleTable("Journey Mode", "Date of departure", "Number of passengers", "Cabin class");
            vitals.AddRow(journeyMode, offerResponseObject.Data.Slices[0].DepartureDate, offerResponseObject.Data.Passengers.Count,offerResponseObject.Data.CabinClass);
            vitals.Write();

            //Iterate through the offers
            for (int i = 0; i < offerResponseObject.Data.Offers.Count; i++)
            {
                Console.WriteLine($"Offer number {i + 1}\nPrice: {offerResponseObject.Data.Offers[i].TotalAmount}");
                var offers = new ConsoleTable("Origin", "Destination", "Flight duration", "Operating Carrier");

                //Iterate through the slices
                foreach (var t in offerResponseObject.Data.Offers[i].Slices)
                {
                    foreach (var t1 in t.Segments)
                    {
                        var hours = Convert.ToInt32(XmlConvert.ToTimeSpan(t1.Duration).TotalHours);
                        var minutes = XmlConvert.ToTimeSpan(t1.Duration).Minutes;
                        var departureTime = t1.DepartingAt;
                        var arrivalTime = t1.ArrivingAt;

                        offers.AddRow(t1.Origin.IataCityCode + "" + departureTime, t1.Destination.IataCityCode + "" + arrivalTime,
                            hours + "H " + minutes + "M", t1.OperatingCarrier.Name);
                    }
                }
                offers.Write();
            }
            //Console.WriteLine(JsonConvert.SerializeObject(result.ReturnObj, Formatting.Indented));
            Console.ForegroundColor = ConsoleColor.White;

        }
        
        /// <summary>
        /// Get the city of origin
        /// </summary>
        /// <returns></returns>
        public static string GetOrigin()
        {            
            var origin = Console.ReadLine();

            if (string.IsNullOrEmpty(origin))
            {
                Console.WriteLine("Invalid entry");
                GetOrigin();
            }

            return origin;
        }

        /// <summary>
        /// Method thet gets the destination
        /// </summary>
        /// <returns></returns>
        public static string GetDestination()
        {           
            var destination = Console.ReadLine();

            if (string.IsNullOrEmpty(destination))
            {
                Console.WriteLine("Invalid entry!!!");
                GetOrigin();
            }

            return destination;
        }

        /// <summary>
        /// Method that obtains the departure date from the user
        /// </summary>
        /// <returns></returns>
        public static DateTime GetDepartureDate()
        {
            DateTime departureDate = new DateTime();

            var departureDateString = Console.ReadLine();

            try
            {
                if (string.IsNullOrEmpty(departureDateString))
                {
                    Console.WriteLine("Invalid entry!!!");
                    GetDepartureDate();
                }
                else
                {
                    departureDate = DateTime.Parse(departureDateString);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid format");
                GetDepartureDate();
            }

            return departureDate;
        }

        /// <summary>
        /// Method gets the number of passengers and their specified types
        /// </summary>
        /// <returns></returns>
        public static List<OfferRequestPassenger> GetPassengers()
        {
            var passengers = new List<OfferRequestPassenger>();

            Console.WriteLine("How many adults are travelling");
            var adults = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < adults; i++)
            {
                var passenger = new OfferRequestPassenger()
                {
                    Type = PassengerType.adult.ToString()
                };
                passengers.Add(passenger);
            }

            Console.WriteLine("How many children are travelling");
            var children = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < children; i++)
            {
                var passenger = new OfferRequestPassenger()
                {
                    Type = PassengerType.child.ToString()
                };
                passengers.Add(passenger);
            }

            Console.WriteLine("How many infants without seats are travelling");
            var infants = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < infants; i++)
            {
                var passenger = new OfferRequestPassenger()
                {
                    Type = PassengerType.infant_without_seat.ToString()
                };
                passengers.Add(passenger);
            }
            return passengers;
        }

        /// <summary>
        /// Method gets the preferred cabin class of the offer being created
        /// </summary>
        public static string GetCabinClass()
        {            
            
            var cabinClassInput = Console.ReadLine();

            var cabinClass = CabinClass.economy;

            try
            {
                if (string.IsNullOrEmpty(cabinClassInput))
                {
                    Console.WriteLine("Invalid entry!! Enter the cabin class. \n1.first \n2.business \n3.premium_economy \n4.economy");
                    GetCabinClass();
                }
                else
                {
                    cabinClass = (CabinClass)Enum.Parse(typeof(CabinClass), cabinClassInput);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry!! Enter the cabin class. \n1.first \n2.business \n3.premium_economy \n4.economy");
                GetCabinClass();
            }
            return cabinClass.ToString();
            
        }

        /// <summary>
        /// Method that gets the journey mode of a particular offer request
        /// </summary>
        /// <returns></returns>
        public static string GetJourneyMode()
        {
            var journeyModeInput = Console.ReadLine();

            var journeyMode = JourneyMode.oneway;

            try
            {
                if (string.IsNullOrEmpty(journeyModeInput))
                {
                    Console.WriteLine("Invalid entry!! Enter the journey mode. \n1.oneway \n2.returnflight \n3.multi_city");
                    GetJourneyMode();
                }
                else
                {
                    journeyMode = (JourneyMode)Enum.Parse(typeof(JourneyMode), journeyModeInput);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry!! Enter the journey mode. \n1.oneway \n2.returnflight \n3.multi_city");
                GetJourneyMode();
            }

            return journeyMode.ToString();
        }

    }
}
