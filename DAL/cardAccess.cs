using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cardAccess
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();

        //卡号登录的方法
        public int cardLogin(string cardID, string psw)
        {
            string strsql = "select * from CardInfo where cardID = '" + cardID + "' and cardPwd = '" + psw + "'";
            return db.returnRowCount(strsql);
        }
    }
}
