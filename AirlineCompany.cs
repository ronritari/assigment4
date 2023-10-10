using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class AirlineCompany
    {
        

        private SortedList<int, Flight> flights = new SortedList<int, Flight>(); //sorted list that needs key(int) and object flight

        private string AirlineName { get; }

        public AirlineCompany(string airlineName)
        {
            AirlineName = airlineName;
        }

        public Flight this[int index]
        {
            get { return flights[index]; }  // use Values to access the flight objects
            set { flights[flights.Keys[index]] = value; } //flights.Insert(index, value); does not work. maybe because of sorted list
        }

        public void AddFlight(Flight flight)
        {
            flights.Add(flight.Id, flight); // use the flights ID as the key
        }

        public Flight FindFlight(int flightId) //finds the key of the list with the flight id
        {
            if (flights.ContainsKey(flightId))
            {
                return flights[flightId];
            }

            return null;
        }

        
        public Flight GetCheapestFlight()
        {
            //initialize cheapest flight with first object
            Flight cheapestFlight = flights.Values[0];
            //set lits first object as the lowest price
            double minPrice = flights.Values[0].Price;


            foreach (var flight in flights.Values)
            {
                //replace lowest if this flight is lower price
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
            Flight mostExpensiveFlight = flights.Values[0];

            double maxPrice = flights.Values[0].Price;

            foreach (var flight in flights.Values)
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
            foreach (var flight in flights.Values)
            {
                Console.WriteLine($"Flight ID: {flight.Id}, Origin: {flight.Origin}, Destination: {flight.Destination}, Date: {flight.Date}, Price: {flight.Price}£");
            }
        }
    }
}