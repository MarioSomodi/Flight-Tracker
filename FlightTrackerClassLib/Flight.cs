using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerClassLib
{
    //Class that defines a flight.
    public class Flight
    {
        //Unique identifier of the flight and connetion to the position of that flight.
        public int flightId { get; set; }
        //Unique ICAO 24-bit address of the transponder in hex string representation.
        public string icao24 { get; set; }
        //Callsign of the vehicle (8 chars). Can be null if no callsign has been received.
        public string callSign { get; set; }
        //Unique id that points to the country of the specified flight.
        public int flightCountryId { get; set; }
        //Velocity over ground in m/s. Can be null.
        public decimal velocity { get; set; }
        //Vertical rate in m/s. A positive value indicates that the airplane is climbing, a negative value indicates that it descends. Can be null.
        public decimal verticalRate { get; set; }
        //The transponder code aka Squawk. Can be null.
        public string squawk { get; set; }
        //Whether flight status indicates special purpose indicator.
        public bool spi { get; set; }
    }
}
