using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class selectByIdIpml
    {
        string sql;
        DDBC ddbc;

        public SqlDataReader run(string id)
        {
            ddbc = new DDBC();
            sql = "select * from Card where card_id='" + id + "'";
            SqlDataReader reader = ddbc.select(sql);
            return reader;
        }

        public void close()
        {
            ddbc.Close();
        }
    }
}
