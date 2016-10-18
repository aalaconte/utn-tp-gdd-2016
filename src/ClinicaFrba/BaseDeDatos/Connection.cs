using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.BaseDeDatos
{
    class Connection
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["ClinicaGD2C2016"].ConnectionString);
        }
    }
}
