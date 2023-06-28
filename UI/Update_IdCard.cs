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
    public partial class Update_IdCard : Form
    {
        public Update_IdCard()
        {
            InitializeComponent();
        }

        private void Next_Step_Click(object sender, EventArgs e)
        {
            Update_Success_Form usf = new Update_Success_Form();
            usf.ShowDialog();
        }
    }
}
