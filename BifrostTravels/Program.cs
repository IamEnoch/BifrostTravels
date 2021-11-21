using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

            Console.WriteLine("Enter the city of origin");
            var origin = GetOrigin();

            Console.WriteLine("Enter the city of destination");
            var destination = GetDestination();

            Console.WriteLine("Enter the date of departure");
            var departureDate = GetDepartureDate();

            Console.WriteLine("Enter the cabin class");
            var cabinclass = GetCabinClass();

            var passengers = GetPassengers();

            //A list of slices where we can house multiple slices
            //Payload only accepts a list of slices
            var slices = new List<OfferRequestSlice>();
            var slice1 = new OfferRequestSlice
            {
                DepartureDate = departureDate,
                Origin = origin,
                Destination = destination
            };
            slices.Add(slice1);

            var data = new OffersRequestData
            {
                Slices = slices,
                Passengers = passengers,
                CabinClass = cabinclass
            };
            OfferRequestPayload payload = new OfferRequestPayload { Data = data };

            var result = await DataHelper.PostItemAsync("offer_requests", payload);
            Console.WriteLine();

            Console.ForegroundColor = result.IsSuccessful ? ConsoleColor.Green : ConsoleColor.Red;

            var objectString = JsonConvert.SerializeObject(result.ReturnObj);
            var OfferResponseObject = JsonConvert.DeserializeObject<SeriesOfOffers>(objectString);

            var table = new ConsoleTable("Number of slices", "livemode");
            table.AddRow(OfferResponseObject.Data.Slices.Count, OfferResponseObject.Data.LiveMode);

            table.Write();

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
        /// Method gets the number of passengers and their specififed types
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
            Console.WriteLine("Enter the cabin class. \n1.first \n2.business \n3.premium_economy \n4.economy");
            var cabinclassInput = Console.ReadLine();

            var cabinClass = CabinClass.economy;

            try
            {
                if (string.IsNullOrEmpty(cabinclassInput))
                {
                    Console.WriteLine("Invalid entry!! Enter the cabin class. \n1.first \n2.business \n3.premium_economy \n4.economy");
                    GetCabinClass();
                }
                else
                {
                    cabinClass = (CabinClass)Enum.Parse(typeof(CabinClass), cabinclassInput);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry!! Enter the cabin class. \n1.first \n2.business \n3.premium_economy \n4.economy");
                GetCabinClass();
            }
            return cabinClass.ToString();
            
        }

    }
}
