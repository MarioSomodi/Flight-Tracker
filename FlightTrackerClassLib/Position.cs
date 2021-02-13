using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerClassLib
{
    //Class that defines a position of a specific flight.
    public class Position
    {
        //Unique identifier for a specific position of flight.
        public int positionId { get; set; }
        //WGS-84 longitude in decimal degrees. Can be null.
        public decimal longitude { get; set; }
        //WGS-84 latitude in decimal degrees. Can be null.
        public decimal latitude { get; set; }
        //Barometric altitude in meters. Can be null.
        public decimal baroAltitude { get; set; }
        //Value which indicates if the position was retrieved from a surface position report.
        public bool onGround { get; set; }
        //True track in decimal degrees clockwise from north (north=0°). Can be null.
        public decimal trueTrack { get; set; }
        //Geometric altitude in meters. Can be null.
        public decimal geoAltitude { get; set; }
        //Origin of this state’s position: 0 = ADS-B, 1 = ASTERIX, 2 = MLAT.
        public int positionSource { get; set; }
    }
}
