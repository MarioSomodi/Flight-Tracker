using FlightTrackerClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTracker
{
    public partial class Flights : Form
    {
        //Generating objects of needed repositories for CRUD operations on the DB and gathering info from API.
        private FlightRepository fR = new FlightRepository();
        private CountryRepository cR = new CountryRepository();
        //Binding source for the DataGridView.
        private BindingSource _flightsBindingSource = new BindingSource();
        //Constructor for Flights form sets the binding source to the flights list.
        public Flights()
        {
            InitializeComponent();
            List<FlightVM> f = fR.GetVMsOfFlights();
            Console.WriteLine(f.Count);
            if (f.Count > 0)
            {
                _flightsBindingSource.DataSource = f;
            }
            else 
            {
                dataGridViewFlights.Visible = false;
                lblFlightsEmpty.Visible = true;
            }
        }
        //Triggers on form load fills the DataGridView with the binding source and sets the column SortMode to NotSortable so the alligment to center is correct.
        private void Flights_Load(object sender, EventArgs e)
        {
            dataGridViewFlights.DataSource = _flightsBindingSource;
            for (int i = 0; i < dataGridViewFlights.ColumnCount; i++)
            {
                dataGridViewFlights.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        //Checkes for the click on the imagecolumn for adding flight details and then give the user the option to enter detailed info for that flight.
        private void dataGridViewFlights_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) 
            {
                var countries = cR.GetCountriesFromDB();
                DataGridViewRow row = dataGridViewFlights.Rows[e.RowIndex];
                panelAddDetails.Visible = true;
                lblCountryOfOrigin.Text = "Origin country: " + (string)row.Cells[4].Value;
                lblFlightId.Text = "Flight Id: " + (int)row.Cells[1].Value;
                comboBoxCountries.Items.Add("Country not on list");
                countries = countries.OrderBy(country => country.CountryName).ToList();
                foreach (Country country in countries) 
                {
                    string originCountry = String.Concat(lblCountryOfOrigin.Text.Where(c => !Char.IsWhiteSpace(c)));
                    if (country.CountryName != originCountry.Substring(14))
                    {
                        comboBoxCountries.Items.Add(country.CountryName);
                    }
                }
                textBoxNewCountry.Text = comboBoxCountries.Text = "";
                numericUpDownHours.Value = numericUpDownMinutes.Value = numericUpDownPrice.Value = numericUpDownNumOfPassangers.Value = 0;
                if (textBoxNewCountry.Visible) 
                {
                    textBoxNewCountry.Visible = false;
                    buttonBackToComboBox.Visible = false;
                    comboBoxCountries.Visible = true;
                }
            }
        }
        //Triggers on form submit checks all input fields and validates them. If all correct inputs the details in the DB for that flights.
        private void btnAddFlightDetails_Click(object sender, EventArgs e)
        {
            string validacija = "";
            var destinationCountry = "";
            //Validation of destination country
            if (comboBoxCountries.Visible)
            {
                if (comboBoxCountries.Text == "")
                {
                    lblErrorDestinationCountry.Visible = true;
                    lblErrorDestinationCountry.Text = "You have to choose the destination country!";
                }
                else
                {
                    lblErrorDestinationCountry.Visible = false;
                    destinationCountry = comboBoxCountries.Text;
                    validacija = validacija + "1";
                }

            }
            else if (textBoxNewCountry.Visible)
            {
                if (textBoxNewCountry.Text == "")
                {
                    lblErrorDestinationCountry.Visible = true;
                    lblErrorDestinationCountry.Text = "You can't leave the destination country field empty!";
                }
                else if (textBoxNewCountry.Text[0].ToString() != textBoxNewCountry.Text[0].ToString().ToUpper())
                {
                    lblErrorDestinationCountry.Visible = true;
                    lblErrorDestinationCountry.Text = "The destination country can't have a lowercase letter as its first letter!";
                }
                else
                {
                    destinationCountry = textBoxNewCountry.Text;
                    lblErrorDestinationCountry.Visible = false;
                    validacija = validacija + "1";
                }
            }
            //Validation of hour duration
            if (numericUpDownHours.Value < 0)
            {
                lblErrorHours.Visible = true;
                lblErrorHours.Text = "Hours can't be less then 1!";
            }
            else if (numericUpDownHours.Value == 0 && numericUpDownMinutes.Value <= 0)
            {
                lblErrorHours.Visible = true;
                lblErrorHours.Text = "Hours can't be zero!";
            }
            else
            {
                lblErrorHours.Visible = false;
                validacija = validacija + "2";
            }
            //Validation of minute duration
            if (numericUpDownMinutes.Value < 0)
            {
                lblErrorMinutes.Visible = true;
                lblErrorMinutes.Text = "Minutes can't be less then 1!";
            }
            else if (numericUpDownHours.Value <= 0 && numericUpDownMinutes.Value == 0)
            {
                lblErrorMinutes.Visible = true;
                lblErrorMinutes.Text = "Minutes can't be zero!";
            }
            else if (numericUpDownMinutes.Value > 59) 
            {
                lblErrorMinutes.Visible = true;
                lblErrorMinutes.Text = "Minutes can't bigger than 59!";
            }
            else
            {
                lblErrorMinutes.Visible = false;
                validacija = validacija + "3";
            }
            //Validation of flight price 
            if (numericUpDownPrice.Value == 0)
            {
                lblErrorFlightPrice.Visible = true;
                lblErrorFlightPrice.Text = "Price can't be zero!";
            }
            else if (numericUpDownPrice.Value < 0)
            {
                lblErrorFlightPrice.Visible = true;
                lblErrorFlightPrice.Text = "Price can't be negative!";
            }
            else
            {
                lblErrorFlightPrice.Visible = false;
                validacija = validacija + "4";
            }
            //Validation of passanger number
            if (numericUpDownNumOfPassangers.Value == 0 || numericUpDownNumOfPassangers.Value < 0)
            {
                lblErrorNumOfPassangers.Visible = true;
                lblErrorNumOfPassangers.Text = "Passangers can't be less then 1!";
            }
            else
            {
                lblErrorNumOfPassangers.Visible = false;
                validacija = validacija + "5";
            }
            if (validacija == "12345")
            {
                string originCountry = String.Concat(lblCountryOfOrigin.Text.Where(c => !Char.IsWhiteSpace(c)));
                originCountry = originCountry.Substring(14);
                int flightId = Convert.ToInt32(lblFlightId.Text.Substring(11));
                FlightDetails flightDetails = new FlightDetails
                {
                    originCountry = originCountry,
                    flightId = flightId,
                    destinationCountry = destinationCountry,
                    flightDuration = numericUpDownHours.Value + ":" + numericUpDownMinutes.Value,
                    flightPrice = numericUpDownPrice.Value,
                    numberOfPassangers = Convert.ToInt32(numericUpDownNumOfPassangers.Value)
                };
                fR.UpdateFlightInDBWithTheDetails(flightDetails);
                panelAddDetails.Visible = false;
            }
            else 
            {
                btnAddFlightDetails.Text = "Error, try again..";
            }
        }
        //Hides the combobox if the option is to input a new country shows the textbox for the new country.
        private void comboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountries.SelectedIndex == 0) 
            {
                comboBoxCountries.Visible = false;
                textBoxNewCountry.Visible = true;
                buttonBackToComboBox.Visible = true;
            }
        }
        //Show the combobox back to the user hides the button and the textbox for new country.
        private void buttonBackToComboBox_Click(object sender, EventArgs e)
        {
            comboBoxCountries.Visible = true;
            comboBoxCountries.Text = "";
            textBoxNewCountry.Text = "";
            textBoxNewCountry.Visible = false;
            buttonBackToComboBox.Visible = false;
        }
        //If user inputs something random in the combobox and resets the combobox.
        private void comboBoxCountries_Leave(object sender, EventArgs e)
        {
            var countries = cR.GetCountriesFromDB();
            var contains = false;
            if (comboBoxCountries.Text == "Country not on list")
            {
                contains = true;
            }
            foreach (Country country in countries) 
            {
                if (comboBoxCountries.Text == country.CountryName) 
                {
                    contains = true;
                }
            }
            if (!contains) 
            {
                comboBoxCountries.Text = "";
            }
        }
    }
}
