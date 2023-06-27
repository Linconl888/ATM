using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class cardInfo
    {
        private string _cardID;
        private string _psw;

        public string cardID
        {
            set { _cardID = value; }
            get { return _cardID; }
        }
        public string psw
        {
            set { _psw = value; }
            get { return _psw; }
        }

    }
}
