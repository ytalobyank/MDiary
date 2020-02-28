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
        /*
        public void compareDay()
        {
            DateTime data = DateTime.Now;
            NpgsqlConnection conn = Connection();
            conn.Open();
            try
            {
                Console.WriteLine(daysofmonths);
                NpgsqlCommand command = new NpgsqlCommand("SELECT id, days FROM \"Months\" WHERE id=@id", conn);
                command.Parameters.AddWithValue("@id", data.Month);
                NpgsqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    daysofmonths = read.GetInt64(1);
                }
                conn.Close();
                Console.WriteLine(daysofmonths);
            }
            catch(Exception errur)
            {
                Console.WriteLine(errur);
            }
        }
        */
    }
}
