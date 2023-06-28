using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class selectById
    {
        DAL.selectByIdIpml select = new DAL.selectByIdIpml();
        public SqlDataReader runSelect(string id)
        {
            SqlDataReader reader = select.run(id);
            return reader;
        }

        public void close()
        {
            select.close();
        }
    }
}
