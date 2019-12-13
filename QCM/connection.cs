using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCM
{
    class connection
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-740ARVG;Initial Catalog=qcm;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static DataTable dt = new DataTable();
        public static SqlDataReader dr;
    }
}
