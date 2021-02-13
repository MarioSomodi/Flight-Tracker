using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerClassLib
{
    public class FlightVM
    {
        //View model class of flight contains all same variables except it has the name of origin country need for display.
        public int VMflightId { get; set; }
        public string VMicao24 { get; set; }
        public string VMcallSign { get; set; }
        public string VMoriginCountry { get; set; }
        public decimal VMvelocity { get; set; }
        public decimal VMverticalRate { get; set; }
        public string VMsquawk { get; set; }
    }
}
