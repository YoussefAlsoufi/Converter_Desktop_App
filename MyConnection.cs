using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class MyConnection
    {
        public SqlConnection GetConnection()
        {
           return new SqlConnection() { ConnectionString = "server=DESKTOP-DTPF1JL; database=Converter; integrated Security= true" };
        }
    }
}
