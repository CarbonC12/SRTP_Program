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
    public partial class Main_Win : Form
    {
        private string username = "root";
        private string password = "SRTP123456789cc!!";
        private string serverIP = "120.27.242.199";
        private string connectStr = "";
        private string sql = "";
        public MySqlConnection conn = null;
        public Main_Win(Log_Win tmp_Father_Win_Son_Main)
        {
            Father_Log_Win = tmp_Father_Win_Son_Main;
            InitializeComponent();
        }

        private void Main_Win_FormClosed(object sender, FormClosedEventArgs e)
        {
            Father_Log_Win.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetData_Button_Click(object sender, EventArgs e)
        {
            connectStr = "server=" + serverIP + ";user=" + username + ";password=" + password + ";database=TEST";
            conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sql = "select * from Student";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.dataGridView1.DataSource = dataTable;

        }
    }
}
