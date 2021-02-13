using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTrackerClassLib
{
    //Class that works with flights - creating, reading, updating them in the database also deleting them from the database.
    public class FlightRepository
    {
        //Gets the connection string from App.config of the start up project - it is nedded to establish a connection to the database.
        public string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        //Creating needed objects of repositories so we can use the CRUD operations on the DB.
        public PositionRepository pR = new PositionRepository();
        public CountryRepository cR = new CountryRepository();
        //Returns a list of flight objects in a list and also a bool variable that defines the success of the function (If successful returns true if not false.)
        public (List<Flight>,bool) GetFlightsFromAPI(List<Country> selectedCountries) 
        {
            RESTAPIHandlerer RAH = new RESTAPIHandlerer();
            var flights = RAH.GetAllFlightsFromAPI();
            ArgumentException thrownError;
            string callSign = "", squawk = "";
            decimal velocity, verticalRate, longitude, latitude, trueTrack, baroAltitude, geoAltitude;
            velocity = verticalRate = longitude = latitude = trueTrack = baroAltitude = geoAltitude = (decimal)0.0;
            List<Flight> flightsFromSelectedCountries = new List<Flight>();
            List<Position> flightPositions = new List<Position>();
            foreach (var country in selectedCountries) 
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    if (country.CountryName == (string)flights[i][2])
                    {
                        //Validate all data that can be null.
                        //Callsign
                        try
                        {
                            callSign = (string)flights[i][1];
                            if (string.IsNullOrWhiteSpace(callSign))
                            {
                                callSign = "Unidentified";
                            }
                        }
                        catch (ArgumentException e)
                        {
                            callSign = "Unidentified";
                            thrownError = e;
                        }
                        //Velocity
                        try
                        {
                            velocity = Convert.ToDecimal(flights[i][9]);
                        }
                        catch (ArgumentException e)
                        {
                            thrownError = e;
                        }
                        //VerticalRate
                        try
                        {
                            verticalRate = Convert.ToDecimal(flights[i][11]);
                        }
                        catch (ArgumentException e)
                        {
                            thrownError = e;
                        }
                        //Squawk
                        try
                        {
                            squawk = (string)flights[i][14];
                            if (string.IsNullOrWhiteSpace(squawk))
                            {
                                squawk = "Unidentified";
                            }
                        }
                        catch (ArgumentException e)
                        {
                            squawk = "Unidentified";
                            thrownError = e;
                        }
                        //Longitude
                        try
                        {
                            longitude = Convert.ToDecimal(flights[i][5]);
                        }
                        catch (ArgumentException e)
                        {
                            thrownError = e;
                        }
                        //Latitude
                        try
                        {
                            latitude = Convert.ToDecimal(flights[i][6]);
                        }
                        catch (ArgumentException e)
                        {
                            thrownError = e;
                        }
                        //TrueTrack
                        try
                        {
                            trueTrack = Convert.ToDecimal(flights[i][10]);
                        }
                        catch (ArgumentException e)
                        {
                            thrownError = e;
                        }
                        //BaroAltitude
                        try
                        {
                            baroAltitude = Convert.ToDecimal(flights[i][7]);
                        }
                        catch (ArgumentException e)
                        {
                            thrownError = e;
                        }
                        //GeoAltitude
                        try
                        {
                            geoAltitude = Convert.ToDecimal(flights[i][13]);
                        }
                        catch (ArgumentException e)
                        {
                            thrownError = e;
                        }

                        //Validation of possible null values complete.
                        flightPositions.Add(new Position
                        {
                            positionId = 0,
                            longitude = longitude,
                            latitude = latitude,
                            baroAltitude = baroAltitude,
                            onGround = (bool)flights[i][8],
                            trueTrack = trueTrack,
                            geoAltitude = geoAltitude,
                            positionSource = (int)flights[i][16]
                        });
                        flightsFromSelectedCountries.Add(new Flight 
                        {
                            flightId = 0,
                            icao24 = (string)flights[i][0],
                            callSign = callSign,
                            flightCountryId = country.CountryId,
                            velocity = velocity,
                            verticalRate = verticalRate,
                            squawk = squawk,
                            spi = (bool)flights[i][15]
                        });
                    }
                }
            }
            bool success = pR.WritePositionsToDB(flightPositions);
            return (flightsFromSelectedCountries, success);
        }
        //Writes all flights to the DB.
        public bool WriteFlightsToDB(List<Country> selectedCountries)
        {
            var result = GetFlightsFromAPI(selectedCountries);
            var flights = result.Item1;
            using (DbConnection connection = new SqlConnection(sSqlConnectionString)) 
            {
                connection.Open();
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM[STUDENTI_PIN].[dbo].[somodi_Flights]";
                    using (DbDataReader oReader = command.ExecuteReader()){}
                    command.CommandText = "DBCC CHECKIDENT ('[STUDENTI_PIN].[dbo].[somodi_Flights]', RESEED, 0);";
                    using (DbDataReader oReader = command.ExecuteReader()){}
                    foreach (var flight in flights)
                    {
                        command.CommandText = "INSERT INTO somodi_Flights(icao24, callSign, flightCountryId, velocity, verticalRate, squawk, spi) VALUES('" + flight.icao24 + "', '" + flight.callSign + "', '" + flight.flightCountryId + "','" + flight.velocity + "', '" + flight.verticalRate + "', '" + flight.squawk + "','" + flight.spi + "')";
                        using (DbDataReader oReader = command.ExecuteReader()){}
                    }
                }
                connection.Close();
            }
            var flightsDB = GetFlightsFromDB();
            if (flightsDB.Count() > 0 && result.Item2)
                return true;
            else
                return false;
        }
        //Gets all flights from the DB and inserts them in a list of type Flight.
        public List<Flight> GetFlightsFromDB() 
        {
            List<Flight> flightsDB = new List<Flight>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM somodi_Flights";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flightsDB.Add(new Flight()
                        {
                            flightId = (int)reader["flightId"],
                            icao24 = (string)reader["icao24"],
                            callSign = (string)reader["callSign"],
                            flightCountryId = (int)reader["flightCountryId"],
                            velocity = (decimal)reader["velocity"],
                            verticalRate = (decimal)reader["verticalRate"],
                            squawk = (string)reader["squawk"],
                            spi = (bool)reader["spi"]
                        });
                    }
                }
            }
            return flightsDB;
        }
        //Gets the view models of the flights to be shown in the DataGridView.
        public List<FlightVM> GetVMsOfFlights()
        {
            var flightsDB = GetFlightsFromDB();
            var countriesDB = cR.GetCountriesFromDB();
            List<FlightVM> flightsVMs = new List<FlightVM>();
            foreach (var flight in flightsDB)
            {
                flightsVMs.Add(new FlightVM
                {
                    VMflightId = flight.flightId,
                    VMicao24 = flight.icao24,
                    VMcallSign = flight.callSign,
                    VMoriginCountry = countriesDB.Where(country => country.CountryId == flight.flightCountryId).Select(countryN => countryN.CountryName).FirstOrDefault(),
                    VMvelocity = flight.velocity,
                    VMverticalRate = flight.verticalRate,
                    VMsquawk = flight.squawk,
                });
            }
            return flightsVMs;
        }
        //Updates a flight with it's inputed details.
        public void UpdateFlightInDBWithTheDetails(FlightDetails detailsOfFlight)
        {
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                connection.Open();
                command.CommandText = "UPDATE somodi_Flights SET destinationCountry = '" + detailsOfFlight.destinationCountry + "', flightDuration = '" + detailsOfFlight.flightDuration + "', flightPrice = '" + detailsOfFlight.flightPrice + "', numberOfPassangers = '" + detailsOfFlight.numberOfPassangers + "' WHERE flightId = " + detailsOfFlight.flightId + ";";
                using (DbDataReader oReader = command.ExecuteReader()) { }
                connection.Close();
            }
        }
        //Get's all flight details of flights from the DB and returns them as a list.
        public List<FlightDetails> GetFlightDetailsFromDB() 
        {
            InvalidCastException thrownError;
            var countriesDB = cR.GetCountriesFromDB();
            List<FlightDetails> flightDetailsDB = new List<FlightDetails>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM somodi_Flights";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string destinationCountry = "undefined", flightDuration = "undefined";
                        decimal flightPrice = (decimal)0.00;
                        int numberOfPassangers = 0;
                        bool detailsOfFlightEntered = true;
                        try
                        {
                            destinationCountry = (string)reader["destinationCountry"];
                        }
                        catch(InvalidCastException e)
                        {
                            thrownError = e;
                        }
                        try
                        {
                            flightDuration = (string)reader["flightDuration"];
                        }
                        catch (InvalidCastException e)
                        {
                            thrownError = e;
                        }
                        try
                        {
                            flightPrice = (decimal)reader["flightPrice"];
                        }
                        catch (InvalidCastException e)
                        {
                            thrownError = e;
                        }
                        try
                        {
                            numberOfPassangers = (int)reader["numberOfPassangers"];
                        }
                        catch (InvalidCastException e)
                        {
                            thrownError = e;
                        }
                        if (destinationCountry == "undefined" || flightDuration == "undefined" || flightPrice == (decimal)0.00 || numberOfPassangers == 0) 
                        {
                            detailsOfFlightEntered = false;
                        }
                        if (detailsOfFlightEntered) 
                        {
                            flightDetailsDB.Add(new FlightDetails()
                            {
                                flightId = (int)reader["flightId"],
                                originCountry = countriesDB.Where(country => country.CountryId == (int)reader["flightCountryId"]).Select(countryN => countryN.CountryName).FirstOrDefault(),
                                destinationCountry = destinationCountry,
                                flightDuration = flightDuration,
                                flightPrice = flightPrice,
                                numberOfPassangers = numberOfPassangers
                            });
                        }
                    }
                }
            }
            return flightDetailsDB;
        }
        //Get's the number of flight's currently tracked by the REST API.
        public int getNumOfFlights() 
        {
            RESTAPIHandlerer RAH = new RESTAPIHandlerer();
            var flights = RAH.GetAllFlightsFromAPI();
            return flights.Count();
        }
    }
}
