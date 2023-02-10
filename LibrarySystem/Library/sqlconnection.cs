using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library
{
    class sqlconnection
    {
        public SqlConnection baglanti()
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-0EUS3MP\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            sc.Open();
            return sc;
        }
    }
}
