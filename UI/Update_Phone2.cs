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
    public partial class Update_Phone2 : Form
    {
        public Update_Phone2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "131231";
        }

        private void Return_Button2_Click(object sender, EventArgs e)
        {

        }

        private void Sure_Button2_Click(object sender, EventArgs e)
        {
            Update_Success_Form usf = new Update_Success_Form(); 
            usf.ShowDialog();
        }
    }
}
