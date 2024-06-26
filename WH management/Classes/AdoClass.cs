using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WH_management.Classes
{
    public class AdoClass
    {
        public static SqlConnection sqlcn;

        public static void setConnection()
        {
            sqlcn = new SqlConnection(WH_management.Properties.Settings.Default.connection);
        }
    }
}
