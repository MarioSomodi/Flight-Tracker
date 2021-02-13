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
    public partial class FlightDetailsStatistics : Form
    {
        //Generating object of needed repository for CRUD operations on the DB and gathering info from API.
        private FlightRepository fR = new FlightRepository();
        //Form constructor.
        public FlightDetailsStatistics()
        {
            InitializeComponent();
        }
        //Triggers on form load gets the num of flights currently tracked and the num of details of those flights sets the label and generates a graph on prices.
        private void FlightDetailsStatistics_Load(object sender, EventArgs e)
        {
            int numOfFlights = fR.GetFlightsFromDB().Count();
            var flightDetails = fR.GetFlightDetailsFromDB();
            int numOfDetailsOfFlights = flightDetails.Count();
            lblNumOfDetailsAndFlights.Text = "Currently tracking |" + numOfFlights + "| flights out of which |" + numOfDetailsOfFlights + "| have detailed information";
            chartPrice.Series.Clear();
            int index = 1;
            foreach (var flight in flightDetails)
            {
                chartPrice.Series.Add(flight.flightId.ToString());
                chartPrice.Series[index-1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chartPrice.Series[index-1].Points.AddXY(1, flight.flightPrice);
                chartPrice.Series[index-1].IsXValueIndexed = true;
                index += 1;
            }
        }
    }
}