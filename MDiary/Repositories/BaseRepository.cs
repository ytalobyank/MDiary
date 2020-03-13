using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDiary.Repositories
{
    public abstract class BaseRepository
    {
        protected NpgsqlConnection Connection()
        {
            var connection = new NpgsqlConnection("Server=127.0.0.1; Port=5432; Database=Monthdiary; User Id=postgres; Password=kemily;");
            connection.Open();
            return connection;
        }
    }
}
