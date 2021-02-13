using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightTrackerClassLib;

namespace FlightTracker
{
    public partial class FlightDetailsForm : Form
    {
        //Generating object of needed repository for CRUD operations on the DB and gathering info from API.
        private FlightRepository fR = new FlightRepository();
        //Binding source for the DataGridView.
        private BindingSource _flightDetalisBindingSource = new BindingSource();
        //Constructor for the flight details form that fills the binding source with the flight details.
        public FlightDetailsForm()
        {
            InitializeComponent();
            List<FlightDetails> fD = fR.GetFlightDetailsFromDB();
            if (fD.Count > 0)
            {
                _flightDetalisBindingSource.DataSource = fD;
            }
            else 
            {
                dataGridViewFlightDetails.Visible = false;
                lblEmptyList.Visible = true;
                comboBoxSearchParam.Enabled = false;
                comboBoxSearchParam.Text = "Disabled";
                btnExportFlightsToTxt.Enabled = false;
                btnExportFlightsToTxt.Text = "No flights to export";
            }
        }
        //Triggers on form load fills the DataGridView with the binding source and sets the column SortMode to NotSortable so the alligment to center is correct.
        private void FlightDetailsForm_Load(object sender, EventArgs e)
        {
            dataGridViewFlightDetails.DataSource = _flightDetalisBindingSource;
            for (int i = 0; i < dataGridViewFlightDetails.ColumnCount; i++)
            {
                dataGridViewFlightDetails.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        //Combobox to choose what to search by and when choosen shows the text box for search on that param.
        private void comboBoxSearchParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchLabel.Text = comboBoxSearchParam.Text;
            comboBoxSearchParam.Visible = false;
            textBoxSearch.Visible = true;
            buttonBackToComboBox.Visible = true;
        }
        //Button that shows the combobox again and let's you choose a diffrent param.
        private void buttonBackToComboBox_Click(object sender, EventArgs e)
        {
            comboBoxSearchParam.Visible = true;
            textBoxSearch.Visible = false;
            searchLabel.Text = "Choose what to search by";
            buttonBackToComboBox.Visible = false;
            textBoxSearch.Text = "";
            comboBoxSearchParam.Text = "";
            var flightDetails = fR.GetFlightDetailsFromDB();
            _flightDetalisBindingSource.DataSource = flightDetails;
            dataGridViewFlightDetails.DataSource = _flightDetalisBindingSource;
        }
        //Live search on a choosen param.
        private void textBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string enteredText = textBoxSearch.Text;
            string choosenParam = searchLabel.Text;
            var flightDetails = fR.GetFlightDetailsFromDB();
            List<FlightDetails> filteredFlightDetails = new List<FlightDetails>();
            switch (choosenParam)
            {
                case "Origin country":
                    filteredFlightDetails = flightDetails.Where(flightDetail => flightDetail.originCountry.ToLower().Contains(enteredText.ToLower())).ToList();
                    break;
                case "Destination country":
                    filteredFlightDetails = flightDetails.Where(flightDetail => flightDetail.destinationCountry.ToLower().Contains(enteredText.ToLower())).ToList();
                    break;
                case "Flight duration":
                    filteredFlightDetails = flightDetails.Where(flightDetail => flightDetail.flightDuration.ToLower().Contains(enteredText.ToLower())).ToList();
                    break;
                case "Flight price":
                    filteredFlightDetails = flightDetails.Where(flightDetail => flightDetail.flightPrice.ToString().Contains(enteredText.ToLower())).ToList();
                    break;
                case "Number of passangers":
                    filteredFlightDetails = flightDetails.Where(flightDetail => flightDetail. numberOfPassangers.ToString().Contains(enteredText.ToLower())).ToList();
                    break;
                default:
                    MessageBox.Show("Wrong param", "You have choosen the wrong search parameter!");
                    break;
            }
            _flightDetalisBindingSource.DataSource = filteredFlightDetails;
            dataGridViewFlightDetails.DataSource = _flightDetalisBindingSource;
        }
        //Export resulting flights from the DataGridView to the txt file in a form of a table.
        private void btnExportFlightsToTxt_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:/Users/fpsdr/Desktop/Flights.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter file = new StreamWriter(fs))
            {
                int location = 1;
                file.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (DataGridViewColumn column in dataGridViewFlightDetails.Columns)
                {
                    switch (location) 
                    {
                        case 1:
                            file.Write("| {0, -25} |", column.HeaderText);
                            break;
                        default:
                            file.Write(" {0, -25} |", column.HeaderText);
                            break;
                    }
                    location++;
                }
                file.WriteLine("\n|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|");
                foreach (DataGridViewRow row in dataGridViewFlightDetails.Rows)
                {
                    location = 1;
                    foreach (DataGridViewColumn column in dataGridViewFlightDetails.Columns)
                    {
                        switch (location)
                        {
                            case 1:
                                file.Write("| {0, -25} |", row.Cells[column.Index].Value.ToString());
                                break;
                            default:
                                file.Write(" {0, -25} |", row.Cells[column.Index].Value.ToString());
                                break;
                        }
                        location++;
                    }
                    if (row.Index == dataGridViewFlightDetails.Rows.Count-1) 
                        file.WriteLine("\n-------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    else
                        file.WriteLine("\n|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|---------------------------|");
                }
            }
            btnExportFlightsToTxt.Text = "Flights exported";
        }
    }
}
