using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlicoopmart_nam3_24_10_2021
{
    class Chuoiketnoi
    {
        string str;
        public Chuoiketnoi()
        {
            str = "Data Source=DESKTOP-LRQ8VCB\\SQLEXPRESS;Initial Catalog=manager_market_smart;Integrated Security=True";
        }

        public SqlConnection sqlConnection()
        {
            return new SqlConnection(str);
        }
    }
}
