using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Update_Phone1 : Form
    {
        public Update_Phone1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Next_Step_Click(object sender, EventArgs e)
        {
            Update_Phone2 up2= new Update_Phone2();
            up2.ShowDialog();
        }
    }
}
