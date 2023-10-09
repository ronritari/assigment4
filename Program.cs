using assignment4;
using System;
using System.Collections.Generic;

namespace assignment4
{
    class Program
    {


        static void Main()
        {
            AirlineCompany airline = new AirlineCompany();
            //Flight flight = new Flight();

            airline.AddFlight(new Flight(1, "New York", "Los Angeles", DateTime.Parse("2023-09-20"), 450.0));
            airline.AddFlight(new Flight(2, "Chicago", "Miami", DateTime.Parse("2023-09-22"), 300.0));
            airline.AddFlight(new Flight(3, "San Francisco", "Las Vegas", DateTime.Parse("2023-09-23"), 225.0));

            Console.WriteLine("All Flights:");
            airline.DisplayFlights();

            int flightIdToFind = 2;
            Flight foundFlight = airline.FindFlight(flightIdToFind);
            if (foundFlight != null)
            {
                Console.WriteLine($"\nFlight with ID {flightIdToFind} found: {foundFlight.Origin} to {foundFlight.Destination}");
            }

            Flight cheapestFlight = airline.GetCheapestFlight();
            Console.WriteLine($"\nCheapest Flight: {cheapestFlight.Origin} to {cheapestFlight.Destination}, Price: {cheapestFlight.Price}£");

            Flight mostExpensiveFlight = airline.GetMostExpensiveFlight();
            Console.WriteLine($"\nMost Expensive Flight: {mostExpensiveFlight.Origin} to {mostExpensiveFlight.Destination}, Price: {mostExpensiveFlight.Price}£");
        }
    }
}
