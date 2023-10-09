using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class AirlineCompany
    {
        public string AirlineName { get; }
        private List<Flight> flights = new List<Flight>();

        public AirlineCompany(string airlineName)
        {
            AirlineName = airlineName;
        }

        public AirlineCompany()
        {
        }

        public Flight this[int index]
        {
            get { return flights[index]; }
            set { flights[index] = value; }
        }

        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public Flight FindFlight(int flightId)
        {
            foreach (Flight flight in flights)
            {
                if (flight.Id == flightId)
                {
                    return flight;
                }
            }
            return null;
        }


        public Flight GetCheapestFlight()
        {
            Flight cheapestFlight = null;
            double minPrice = double.MaxValue;

            foreach (Flight flight in flights)
            {
                if (flight.Price < minPrice)
                {
                    minPrice = flight.Price;
                    cheapestFlight = flight;
                }
            }

            return cheapestFlight;

        }

        public Flight GetMostExpensiveFlight()
        {
            Flight mostExpensiveFlight = null;
            double maxPrice = double.MinValue;

            foreach (Flight flight in flights)
            {
                if (flight.Price > maxPrice)
                {
                    maxPrice = flight.Price;
                    mostExpensiveFlight = flight;
                }
            }

            return mostExpensiveFlight;
        }

        public void DisplayFlights()
        {
            foreach (var flight in flights)
            {
                Console.WriteLine($"Flight ID: {flight.Id}, Origin: {flight.Origin}, Destination: {flight.Destination}, Date: {flight.Date.ToShortDateString()}, Price: {flight.Price}£");
            }
        }
    }
}