using System;

namespace LufthavnsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirportDBEntities AirportDBEntities = new AirportDBEntities();
            Console.WriteLine("Airports:");
            foreach (var item in AirportDBEntities.Airports)
            {
                Console.WriteLine($"IATA: {item.IATACode} | Airport Name: {item.Name} | CountryCode: {item.CountryCode} |  Country: {item.CountryName}");
            }

            Console.WriteLine("\nAirlines:");
            foreach (var item in AirportDBEntities.Airlines)
            {
                Console.WriteLine($"Airline Name: {item.Name}");
            }

            Console.WriteLine("\nRoutes:");
            foreach (var item in AirportDBEntities.Routes)
            {
                Console.WriteLine($"Airline Id: {item.Airline_Id} | Airport1: {item.PortOne} | Airport2: {item.PortTwo}");
            }

            Console.ReadKey();
        }
    }
}
