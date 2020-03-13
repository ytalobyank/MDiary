using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;
using MDiary.Models;

namespace MDiary.Repositories
{
    class ActivitiesRepository : BaseRepository
    {
        public ActivitiesRepository()
        {
            EnsureTablesExist();
        }

        private void EnsureTablesExist()
        {
            string creationScript = 
                "CREATE TABLE IF NOT EXISTS \"Activities\" (description CHARACTER VARYING (512), TIMESPENT INT, DAY INT, MONTH INT)";

            var command = new NpgsqlCommand(creationScript, Connection());
            command.ExecuteNonQuery();
        }
        
        public void AddActivity(Activity activity)
        {
            try
            {
                NpgsqlConnection conn = Connection();
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"Activities\"(description,timespent,day,month) VALUES(@string,@time,@day,@month);", conn);
                command.Parameters.AddWithValue("@string", activity.Description);
                command.Parameters.AddWithValue("@time", activity.TimeSpent);
                command.Parameters.AddWithValue("@day", activity.Day);
                command.Parameters.AddWithValue("@month", activity.Month);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception errur)
            {
                Console.WriteLine(errur);
            }
        }

        public List<Activity> GetActivitiesForDay(int day, int month)
        {
            var result = new List<Activity>();
            var conn = Connection();

            var command = new NpgsqlCommand("SELECT description, timespent, day FROM \"Activities\" WHERE day=@day AND month=@month", conn);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@month", month);

            NpgsqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                var atual = new Activity
                {
                    Description = reader.GetString(reader.GetOrdinal("description")),
                    Day = day,
                    Month = month,
                    TimeSpent = reader.GetInt32(reader.GetOrdinal("timespent"))
                };
                result.Add(atual);
            }

            conn.Close();

            return result;
        }

        public int GetAvailableTime(int day, int month)
        {
            var conn = Connection();

            var command = new NpgsqlCommand("SELECT SUM(timespent) FROM \"Activities\" WHERE day=@day AND month=@month", conn);
            command.Parameters.AddWithValue("@day", day);
            command.Parameters.AddWithValue("@month", month);

            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
