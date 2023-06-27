using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class cardAccess
    {
        DAL.cardAccess d_cardAccess = new DAL.cardAccess();

        public int cardLogin(Model.cardInfo m_cardInfo)
        {
            return d_cardAccess.cardLogin(m_cardInfo.cardID, m_cardInfo.psw);
        }
    }
}
