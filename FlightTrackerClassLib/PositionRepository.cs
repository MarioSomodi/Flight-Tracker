using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FlightTrackerClassLib
{
    //Class that works with positions of flights - creating, reading, updating them in the database also deleting them from the database.
    public class PositionRepository
    {
        //Gets the connection string from App.config of the start up project - it is nedded to establish a connection to the database.
        public string sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        //Writes all position of all flights to the DB.
        public bool WritePositionsToDB(List<Position> flightPositions) 
        {
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            {
                connection.Open();
                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM[STUDENTI_PIN].[dbo].[somodi_Positions]";
                    using (DbDataReader oReader = command.ExecuteReader()){}
                    command.CommandText = "DBCC CHECKIDENT ('[STUDENTI_PIN].[dbo].[somodi_Positions]', RESEED, 0);";
                    using (DbDataReader oReader = command.ExecuteReader()){}
                    foreach (var positionOfFlight in flightPositions)
                    {
                        command.CommandText = "INSERT INTO somodi_Positions(longitude, latitude, baroAltitude, onGround, trueTrack, geoAltitude, positionSource) VALUES('" + positionOfFlight.longitude + "', '" + positionOfFlight.latitude + "', '" + positionOfFlight.baroAltitude + "', '" + positionOfFlight.onGround + "','" + positionOfFlight.trueTrack + "', '" + positionOfFlight.geoAltitude + "', '" + positionOfFlight.positionSource + "')";
                        using (DbDataReader oReader = command.ExecuteReader()){}
                    }
                }
                connection.Close();
            }
            var positionsDB = GetPositionsFromDB();
            if (positionsDB.Count() > 0)
                return true;
            else
                return false;
        }
        //Returns a list of type Position that contains all flight's positions.
        public List<Position> GetPositionsFromDB() 
        {
            List<Position> positionsDB = new List<Position>();
            using (DbConnection connection = new SqlConnection(sSqlConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM somodi_Positions";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        positionsDB.Add(new Position()
                        {
                            positionId = (int)reader["positionId"],
                            longitude = (decimal)reader["longitude"],
                            latitude = (decimal)reader["latitude"],
                            baroAltitude = (decimal)reader["baroAltitude"],
                            onGround = (bool)reader["onGround"],
                            trueTrack = (decimal)reader["trueTrack"],
                            geoAltitude = (decimal)reader["geoAltitude"],
                            positionSource = (int)reader["positionSource"]
                        });
                    }
                }
                connection.Close();
            }
            return positionsDB;
        }
    }
}
