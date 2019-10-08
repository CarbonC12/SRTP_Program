using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SRTP_Win
{
    public partial class Log_Win : Form
    {
        private string username = "root";
        private string password = "SRTP123456789cc!!";
        private string serverIP = "120.27.242.199";
        private string connectStr = "";
        private string sql = "";
        public MySqlConnection conn = null;
        string UserId, PassWd;
        string DataUserId, DataPaw, DataFowed;
        public Log_Win()
        {
            InitializeComponent();
            GetDataBaseConnection();
        }

        private void Log_Button_Click(object sender, EventArgs e)
        {
            UserId = "";
            PassWd = "";
            UserId = this.UserId_TextBox.Text;
            PassWd = this.PassWd_TextBox.Text;
            sql = "SELECT * FROM USER_TABLE WHERE USER="+UserId+ " and PASSWORD="+PassWd;
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = sql;
            //try
            //{
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        this.Hide();
            //        Main_Win main_Win = new Main_Win(this);
            //        main_Win.Show();
            //    }
            //}
            //catch(MySqlException ex)
            //{
            //    MessageBox.Show("账号密码错误,请重试","登陆失败",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}

            if (true)
            {
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

        private void GetDataBaseConnection()
        {
            connectStr = "server=" + serverIP + ";user=" + username + ";password=" + password + ";database=SRTP";
            conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
