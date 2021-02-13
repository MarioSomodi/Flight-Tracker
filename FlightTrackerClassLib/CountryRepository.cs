using System;
using System.Linq;
using System.Text;
using System.Data.Common;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;

namespace FlightTrackerClassLib
{
    //Class that works with countries - creating, reading, updating them in the database also deleting them from the database.
    public class CountryRepository
    {
        //Gets the connection string from App.config of the start up project - it is nedded to establish a connection to the database.
        public string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        //Returns a list of all unique origin country's of all flights.
        public List<Country> GetCountriesFromAPI()
        {
            RESTAPIHandlerer RAH = new RESTAPIHandlerer();
            var flights = RAH.GetAllFlightsFromAPI();
            var countryName = "/";
            List<String> sCountriesAPI = new List<String>();
            List<Country> objCountriesAPI = new List<Country>();
            for (int i = 0; i < flights.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace((string)flights[i][2]))
                {
                    countryName = (string)flights[i][2];
                }
                sCountriesAPI.Add(countryName);
            }
            sCountriesAPI = sCountriesAPI.Distinct().ToList();
            foreach (var country in sCountriesAPI)
            {
                objCountriesAPI.Add(new Country
                {
                    CountryId = 0,
                    CountryName = country
                });
            }
            return objCountriesAPI;
        }
        //Return a list of type Country that contains all countries currently in the database.
        public List<Country> GetCountriesFromDB()
        {
            List<Country> countriesDB = new List<Country>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM somodi_Countries";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        countriesDB.Add(new Country()
                        {
                            CountryId = (int)reader["countryId"],
                            CountryName = (string)reader["countryName"],
                        });
                    }
                }
                connection.Close();
            }
            return countriesDB;
        }
        //Uses the list of countries and then writes them in the database to be used and modified later.
        public void WriteCountriesToDB(List<Country> countries)
        {
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "DBCC CHECKIDENT ('[STUDENTI_PIN].[dbo].[somodi_Countries]', RESEED, 0);";
                using (DbDataReader oReader = command.ExecuteReader()){}
                foreach (var country in countries)
                {
                    if (country.CountryName.Contains("'"))
                        country.CountryName = country.CountryName.Replace("'", "`");
                    command.CommandText = "INSERT INTO somodi_Countries(countryName) VALUES('" + country.CountryName + "')";
                    using (DbDataReader oReader = command.ExecuteReader()){}
                }
                connection.Close();
            }
        }
        //Writes single country to the database.
        public void WriteSingleCountryToDB(Country country)
        {
            var countriesDB = GetCountriesFromDB();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                int dbLength = countriesDB.Count() + 1;
                command.CommandText = "DBCC CHECKIDENT ('[STUDENTI_PIN].[dbo].[somodi_Countries]', RESEED, " + dbLength + ");";
                using (DbDataReader oReader = command.ExecuteReader()){}
                if (country.CountryName.Contains("'"))
                    country.CountryName = country.CountryName.Replace("'", "`");
                command.CommandText = "INSERT INTO somodi_Countries(countryName) VALUES('" + country.CountryName + "')";
                using (DbDataReader oReader = command.ExecuteReader()){}
                connection.Close();
            }
        }
        //Returns the current flights origin country Id 
        public int GetCountryIdForSpecificFlight(string originCountry) 
        {
            int countryId;
            var countriesDB = GetCountriesFromDB();
            if (!string.IsNullOrWhiteSpace(originCountry))
            {
                if (originCountry.Contains("'"))
                    originCountry = originCountry.Replace("'", "`");
                if (countriesDB.Exists(x => x.CountryName == originCountry))
                {
                    countryId = countriesDB.Where(x => x.CountryName == originCountry).Select(x => x.CountryId).FirstOrDefault();
                    return countryId;
                }
                else
                {
                    Country newCountry = new Country()
                    {
                        CountryId = 0,
                        CountryName = originCountry,
                    };
                    WriteSingleCountryToDB(newCountry);
                    countriesDB.Clear();
                    countriesDB = GetCountriesFromDB();
                    countryId = countriesDB.Where(x => x.CountryName == originCountry).Select(x => x.CountryId).FirstOrDefault();
                    return countryId;
                }

            }
            else
            {
                countryId = countriesDB.Where(x => x.CountryName == "/").Select(x => x.CountryId).FirstOrDefault();
                return countryId;
            }
        }
        /**
         * Uses the previously made methods(GetCountriesFromAPI to get the new information of flights origin country from the REST API, GetCountriesFromDB to get all 
         * the countries currently in the database, and WriteCountriesToDB) adds all countries from the database to a list then checks if the list is empty if it is it 
         * will use the method WriteCountriesToDB to write all countries from the REST API to the database if the list is not empty it will check if there are any new 
         * flights with a origin country that is not already in the database if there are it will write that new origin country to the list.
        **/
        public bool WriteToOrUpdateCountriesInDB()
        {
            bool contains = false;
            var countriesDB = GetCountriesFromDB();
            var countriesAPI = GetCountriesFromAPI();
            if (countriesDB.Count() > 0)
            {
                foreach (var apiCountry in countriesAPI)
                {
                    foreach (var dbCountry in countriesDB)
                    {
                        if (dbCountry.CountryName == apiCountry.CountryName)
                        {
                            contains = true;
                        }
                    }
                    if (!contains)
                    {
                        WriteSingleCountryToDB(new Country()
                        {
                            CountryId = 0,
                            CountryName = apiCountry.CountryName,
                        });
                    }
                }
            }
            else
            {
                WriteCountriesToDB(countriesAPI);
            }
            countriesDB = GetCountriesFromDB();
            if (countriesDB.Count() > 0)
                return true;
            else 
                return false;
        }
    }
}