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
    public partial class Withdraw_Money : Form
    {
        public string id;

        public Withdraw_Money()
        {
            InitializeComponent();
        }

        private void archButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id);

            BLL.selectById select = new BLL.selectById();
            SqlDataReader s = select.runSelect(id);
            //MessageBox.Show(s[0].ToString());

        }

        private void archButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
