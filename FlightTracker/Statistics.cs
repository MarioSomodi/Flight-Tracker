using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightTrackerClassLib;

namespace FlightTracker
{
    public partial class Statistics : Form
    {
        //Generating objects of needed repositories for CRUD operations on the DB and gathering info from API.
        private FlightRepository fR = new FlightRepository();
        private PositionRepository pR = new PositionRepository();
        //Cnostructor for Statistics form.
        public Statistics()
        {
            InitializeComponent();
        }
        //Triggers on form load and generates the needed statistics and the graph
        private void Statistics_Load(object sender, EventArgs e)
        {
            int numOfFlights = fR.getNumOfFlights();
            var flightsDB = fR.GetFlightsFromDB();
            var positionsDB = pR.GetPositionsFromDB();
            lblNumOfFlights.Text = "Number of flights that we track: " + numOfFlights + "   Number of currently selected flights: " + flightsDB.Count();
            chartVelocity.Series.Clear();
            int index = 0;
            flightsDB = flightsDB.OrderByDescending(x => x.velocity).ToList();
            foreach (var flight in flightsDB) 
            {
                chartVelocity.Series.Add(flight.icao24.ToString());
                chartVelocity.Series[index].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chartVelocity.Series[index].Points.AddXY(index, flight.velocity);
                index++;
            }
        }
    }
}
