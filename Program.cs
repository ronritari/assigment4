using assignment4;
using System;
using System.Collections.Generic;

namespace assignment4
{
    class Program
    {
        static void Main()
        {
            AirlineCompany airline = new AirlineCompany("Finnair");

            airline.AddFlight(new Flight(1, "helsinki", "lontoo", "2023-09-20", 450.0));
            airline.AddFlight(new Flight(2, "helsinki", "munchen", "2023-09-22", 300.0));
            airline.AddFlight(new Flight(3, "helsinki", "tel aviv", "2023-09-23", 225.0));

            Console.WriteLine("all Flights:");
            airline.DisplayFlights();

            //finds flight with ID 2
            int flightIdToFind = 2;
            Flight foundFlight = airline.FindFlight(flightIdToFind);

            //checks that the flight id is real
            if (foundFlight != null)
            {
                Console.WriteLine($"\nflight with ID {flightIdToFind} found: {foundFlight.Origin} to {foundFlight.Destination}");
            }

            Flight cheapestFlight = airline.GetCheapestFlight();
            Console.WriteLine($"\ncheapest flight: {cheapestFlight.Origin} to {cheapestFlight.Destination}, Price: {cheapestFlight.Price}£");

            Flight mostExpensiveFlight = airline.GetMostExpensiveFlight();
            Console.WriteLine($"\nmost expensive flight: {mostExpensiveFlight.Origin} to {mostExpensiveFlight.Destination}, Price: {mostExpensiveFlight.Price}£");
        }
    }
}
