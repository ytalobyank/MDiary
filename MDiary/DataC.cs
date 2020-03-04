using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace MDiary
{
    class DataC
    {

        public NpgsqlConnection Connection()
        {
            return new NpgsqlConnection("Server = 127.0.0.1; Port=5432; Database=Monthdiary; User Id =postgres; Password=kemily;");
             
        }
        
        public void addActivity(string text,int time,int day, int month)
        {    
            NpgsqlConnection conn = Connection();
            conn.Open();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand("INSERT INTO \"Activities\"(description,timespent,day,month) VALUES(@string,@time,@day,@month)", conn);
                command.Parameters.AddWithValue("@string", text);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@day", day);
                command.Parameters.AddWithValue("@month", month);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception errur)
            {
                Console.WriteLine(errur);
            }
        }
        private string[] DescriptActivities;
        private int []  TimeInMinutes;
        public string[] getDescriptActivities()
        {
            return DescriptActivities;
        }
        public int[] getTimeInMinutes()
        {

            return  TimeInMinutes;
        }
        public void setDescriptActivities(string [] DescriptActivities)
        {
            this.DescriptActivities = DescriptActivities;
        }
        public void setTimeInMinutes(int[] TimeInMinutes)
        {
            this.TimeInMinutes = TimeInMinutes;
        }
        public int CountingRows(int day)
        {
            NpgsqlConnection conn = Connection();
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(description)FROM \"Activities\" WHERE day=@day", conn);
            command.Parameters.AddWithValue("@day", day);
            int itotal= Convert.ToInt32(command.ExecuteScalar());
            return itotal;
        }

        public void SelectingActivities(int day)
        {
            NpgsqlConnection conn = Connection();
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand("SELECT description, timespent, day FROM \"Activities\" WHERE day=@day", conn);
            command.Parameters.AddWithValue("@day", day);
            NpgsqlDataReader reader = command.ExecuteReader();
            string[] description = new string[CountingRows(day)];
            int[] timespent= new int[CountingRows(day)];
            for  (int i = 0;reader.Read();i++)
            {
                description [i] = reader.GetString(0) ;
                timespent [i] = reader.GetInt32(1);
            }
            conn.Close();
            setDescriptActivities(description);
            setTimeInMinutes(timespent);
        }
    }
}
