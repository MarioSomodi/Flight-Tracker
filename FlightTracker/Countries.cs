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
    public partial class Countries : Form
    {
        //Generating objects of needed repositories for CRUD operations on the DB and gathering info from API.
        private CountryRepository cR = new CountryRepository();
        private FlightRepository fR = new FlightRepository();
        //Binding source for the DataGridView.
        private BindingSource _countryBindingSource = new BindingSource();
        //Global list that contains all checked countries.
        private List<Country> checkedCountries = new List<Country>();
        //Constructor for the Countries form that fills the binding source with all the countries.
        public Countries()
        {
            InitializeComponent();
            _countryBindingSource.DataSource = cR.GetCountriesFromDB();
        }
        //Triggers on form load fills the DataGridView with the binding source and sets the column SortMode to NotSortable so the alligment to center is correct.
        private void Countries_Load(object sender, EventArgs e)
        {
            dataGridViewCountries.DataSource = _countryBindingSource;
            for (int i = 0; i < dataGridViewCountries.ColumnCount; i++) 
            {
                dataGridViewCountries.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        //Clears all flight png from the folder on program start
        private void clearImageFolder()
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\Faks\Druga godina\Treci Semestar\Programiranje_u_NET_okolini\Konstrukcijska_Vjezba\FlightTracker\FlightTracker\Resources\imagesOfPlanes");

            foreach (FileInfo file in di.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch (IOException error) { Console.WriteLine(error); }
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch (IOException error) { Console.WriteLine(error); }
            }
        }
        //Gathers all flights from the selected countries.
        private void btnSelectCountries_Click(object sender, EventArgs e)
        {
            if (checkedCountries.Count() > 0)
            {
                btnSelectCountries.Text = "Selected...Gathering flighs";
                bool success = fR.WriteFlightsToDB(checkedCountries);
                if (success) 
                {
                    clearImageFolder();
                    btnSelectCountries.Text = "Select countries";
                }
                else
                    btnSelectCountries.Text = "Error occurred!";
            }
            else 
            {
                btnSelectCountries.Text = "No countries selected!";
            }
            checkedCountries.Clear();
        }
        //Refreshes the country list with new countries that might not be on the list.
        private void btnRefreshCountries_Click(object sender, EventArgs e)
        {
            btnRefreshCountries.Text = "Refreshing...";
            bool success = cR.WriteToOrUpdateCountriesInDB();
            if (success)
            {
                _countryBindingSource.DataSource = cR.GetCountriesFromDB();
                dataGridViewCountries.DataSource = _countryBindingSource;
                btnRefreshCountries.Text = "Refresh countries";
            }
            else
            {
                btnRefreshCountries.Text = "Error occurred try again!";
            }
        }
        //Live search on all countries by their name.
        private void textBoxSearchCountries_KeyUp(object sender, KeyEventArgs e)
        {
            string enteredText = textBoxSearchCountries.Text;
            var countries = cR.GetCountriesFromDB();
            List<Country> filteredCountries = countries.Where(country => country.CountryName.ToLower().Contains(enteredText.ToLower())).ToList();
            _countryBindingSource.DataSource = filteredCountries;
            dataGridViewCountries.DataSource = _countryBindingSource;
            for (int i = 0; i < checkedCountries.Count(); i++)
            {
                foreach (DataGridViewRow row in dataGridViewCountries.Rows)
                {
                    if ((int)row.Cells[1].Value == checkedCountries[i].CountryId)
                    {
                        DataGridViewCheckBoxCell chkCell = (DataGridViewCheckBoxCell)row.Cells[0];
                        chkCell.Value = "true";
                    }
                }
            }
        }
        //Listens for a click on the column in the DataGridView that contains the country name and then gathers it's flights.
        private void dataGridViewCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewCountries.Rows[e.RowIndex].Selected = true;
            }
            catch (ArgumentOutOfRangeException error) { Console.WriteLine(error); }
            if ((dataGridViewCountries.CurrentCell.ColumnIndex.Equals(1) || dataGridViewCountries.CurrentCell.ColumnIndex.Equals(2)) && e.RowIndex != -1)
            {
                int row = dataGridViewCountries.CurrentCell.RowIndex;
                List<Country> selectedCountries = new List<Country>();
                Country country = new Country()
                {
                    CountryId = (int)dataGridViewCountries.Rows[row].Cells[1].Value,
                    CountryName = (string)dataGridViewCountries.Rows[row].Cells[2].Value,
                };
                selectedCountries.Add(country);
                LoadingWarning loadingWarining = new LoadingWarning
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                loadingWarining.Show();
                bool success = fR.WriteFlightsToDB(selectedCountries);
                if (success) 
                {
                    clearImageFolder();
                    loadingWarining.Close();
                }
                else
                {
                    ErrorWarning errorWarning = new ErrorWarning();
                    errorWarning.ShowDialog();
                }
            }
        }
        //Needed for the event listener on the checkbox toggle to work.
        private void dataGridViewCountries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCountries.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        //Listens for a change in value in the checkbox column in the DataGridView and then saves it to the checkedCountries list or removes it if value is false.
        private void dataGridViewCountries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DataGridViewRow row = dataGridViewCountries.Rows[e.RowIndex];
                bool isCellChecked = false;
                bool contains = false;
                var cntry = new Country
                {
                    CountryId = (int)row.Cells[1].Value,
                    CountryName = (string)row.Cells[2].Value
                };
                if ((string)row.Cells[0].Value == "true")
                    isCellChecked = true;
                else
                    isCellChecked = false;
                foreach (Country country in checkedCountries)
                {
                    if (country.CountryId == cntry.CountryId)
                    {
                        contains = true;
                        break;
                    }
                    else
                    {
                        contains = false;
                    }
                }
                if (isCellChecked)
                {
                    if (!contains) 
                    {
                        checkedCountries.Add(cntry);
                    }
                }
                else 
                {
                    if (contains) 
                    {
                        checkedCountries.RemoveAll(x => x.CountryId == cntry.CountryId);
                    }
                }
            }
        }
    }
}
