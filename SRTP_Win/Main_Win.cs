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
            GetDataBaseConnection();
            InitializeComponent();
            InitDataGridView1();
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
            sql = "select * from RM_TABLE";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.dataGridView1.DataSource = dataTable;
            

        }

        private void Raw_Material_Tab_Click(object sender, EventArgs e)
        {
            //
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



        private void DataGridView1_Enter(object sender, EventArgs e)
        {
            //
        }

        private void InitDataGridView1()
        {
            sql = "select * from RM_TABLE";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            this.dataGridView1.DataSource = dataTable;
            this.dataGridView1.Columns[0].HeaderCell.Value = "编号";
            this.dataGridView1.Columns[1].HeaderCell.Value = "名称";
            this.dataGridView1.Columns[2].HeaderCell.Value = "数量";
            this.dataGridView1.Columns[3].HeaderCell.Value = "单位";
            this.dataGridView1.Columns[4].HeaderCell.Value = "仓储地址";
            this.dataGridView1.Columns[5].HeaderCell.Value = "每单位进价";
            this.dataGridView1.Columns[6].HeaderCell.Value = "最低保有量";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
