using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SRTP_Win
{
    public partial class Log_Win : Form
    {
        public Log_Win()
        {
            InitializeComponent();
        }

        private void Log_Button_Click(object sender, EventArgs e)
        {
            string UserId,PassWd;
            UserId= this.UserId_TextBox.Text;
            PassWd = this.PassWd_TextBox.Text;
            //if (UserId.Equals("")|| PassWd .Equals(""))
                //MessageBox.Show("请勿输入空的用户名或者密码","警告!",MessageBoxButtons.OK,MessageBoxIcon.Error);


            //此处需要获得来自于服务器的许可


            if(true)
            {
                //MessageBox.Show("登陆成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                Main_Win main_Win = new Main_Win(this);
                main_Win.Show();
            }

        }



        private void LoglinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register_Win register_Win = new Register_Win(this);
            register_Win.Show();
        }
    }
}
