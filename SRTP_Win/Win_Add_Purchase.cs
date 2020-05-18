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
    public partial class Win_Add_Purchase : Form
    {
        public MySqlConnection conn = null;
        private Main_Win MyFatherWin=null;
        public string Type, MaterialName, Manager, Factory;
        public int Num, Price, DayCost;
        public Win_Add_Purchase(Main_Win Furtherwin, MySqlConnection FurtherConnection)
        {
            MyFatherWin = Furtherwin;
            conn = FurtherConnection;
            InitializeComponent();
        }

        private void Win_Add_Purchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyFatherWin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type = Get_Type.Text;
            MaterialName = Get_Name.Text;
            Manager = Get_Manager.Text;
            Factory = Get_Factory.Text;
            try
            {
                Num = int.Parse(Get_Num.Text);
                Price = int.Parse(Get_Price.Text);
                DayCost = int.Parse(Get_DayCost.Text);
                addInfomationtoDataBase();
                MessageBox.Show("新建成功!");
                this.Close();
            }
            catch(Exception ae)
            {
                MessageBox.Show(ae.Message, "错误!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Win_Add_Purchase_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“sRTPDataSet.RM_TABLE”中。您可以根据需要移动或删除它。
            this.rM_TABLETableAdapter.Fill(this.sRTPDataSet.RM_TABLE);
            // TODO: 这行代码将数据加载到表“sRTPDataSet.PD_TABLE”中。您可以根据需要移动或删除它。
            this.pD_TABLETableAdapter.Fill(this.sRTPDataSet.PD_TABLE);
            // TODO: 这行代码将数据加载到表“sRTPDataSet.ORD_PD_TABLE”中。您可以根据需要移动或删除它。
            this.oRD_PD_TABLETableAdapter.Fill(this.sRTPDataSet.ORD_PD_TABLE);

        }

        private void addInfomationtoDataBase()
        {
            //GJS
            //此处代码应该对采购单管理数据库进行写入一个采购单数据
            //具体采购单数据表的格式参考随压缩包附带的Excel文档
        }

    }
}
