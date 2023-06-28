using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class UserMain : Form
    {
        public string id,pwd;

        public UserMain()
        {
            InitializeComponent();
        }

        private void archButton3_Click(object sender, EventArgs e)
        {
            Withdraw_Money withdraw = new Withdraw_Money();
            withdraw.id = id;
            withdraw.ShowDialog();

        }

        private void UserMain_Load(object sender, EventArgs e)
        {

        }
    }
}
