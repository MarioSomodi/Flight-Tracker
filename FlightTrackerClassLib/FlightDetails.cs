using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerClassLib
{
    //Flight details class that contains all detailed info of flight.
    public class FlightDetails
    {
        //Flights id.
        public int flightId { get; set; }
        //Destination country of flight.
        public string destinationCountry {get; set;}
        //Origin country of flight.
        public string originCountry { get; set; }
        //Duration of the flight.
        public string flightDuration { get; set; }
        //Price of the flight.
        public decimal flightPrice { get; set; }
        //Number of passangers.
        public int numberOfPassangers { get; set; }
    }
}
