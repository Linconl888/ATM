using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class CardLogin : Form
    {
        //实例化model层中 cardInfo类用于传递数据
        Model.cardInfo m_cardInfo = new Model.cardInfo();

        //实例化BLL层中 cardAccess方法衔接用户输入与数据库匹配
        BLL.cardAccess b_cardAccess = new BLL.cardAccess();
        public CardLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //将用户输入的账号密码 赋值给cardInfo类 cardname、psw属性
            m_cardInfo.cardID = tB_cardID.Text.Trim().ToString();
            m_cardInfo.psw = tb_cardPwd.Text.Trim().ToString();

            //如果BLL层中 useLogin调用返回记录条数 大于1 则账号密码正确
            if (b_cardAccess.cardLogin(m_cardInfo) > 0)
            {
                this.Hide();
                UserOperation userOperation = new UserOperation();
                userOperation.Show();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
