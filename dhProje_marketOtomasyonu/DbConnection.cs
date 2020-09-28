using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhProje_marketOtomasyonu
{
    class DbConnection
    {

        public static SqlConnection Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConStr);

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();


            return connection;
        }

        

    }
}
