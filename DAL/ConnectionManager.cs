using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectionManager
    {
        public string ConnectionString;
        internal SqlConnection connection;
        public ConnectionManager(string connetionString)
        {
            ConnectionString = connetionString;
            connection = new SqlConnection(ConnectionString);
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection.Close();
        }
    }
}
