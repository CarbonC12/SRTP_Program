using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SRTP_Win {
    public partial class Win_Add_Order : Form {
        // public string FactoryLocation, Product, Saler, Factory;
        // public int Num, Price, DayCost;
        private Main_Win MyFatherWin = null;
        public MySqlConnection conn = null;
        public Win_Add_Order (Main_Win FurtherWin, MySqlConnection FurtherCoon) {
            conn = FurtherCoon;
            MyFatherWin = FurtherWin;
            InitializeComponent ();
        }

        // New 填充产品选择框
        private void Win_Add_Order_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da1 = new MySqlDataAdapter(
                "select im_name from materialinfo.intermediate_material where im_parent is null;", conn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "materialinfo.intermediate_material");
            DataTable dt1 = ds1.Tables["materialinfo.intermediate_material"];
            Get_Need_Name.DataSource = dt1;
            Get_Need_Name.DisplayMember = "im_name";
            Get_Need_Name.ValueMember = "im_name";
        }


        private void Win_Add_Order_FormClosing (object sender, FormClosingEventArgs e) {
            MyFatherWin.Show ();
        }

        private void BTN_Submit_Click (object sender, EventArgs e) {
            //FactoryLocation = Get_Location.Text;//送货地址
            //Product = Get_Need_Name.Text;//产品名称
            //Saler = Get_Saler.Text;//销售员
            //Factory = Get_Need_Factory.Text;//厂家
            try {
                //Num = int.Parse(Get_Num.Text);//产品数量
                //Price = int.Parse(Get_Price.Text);//产品单价
                //DayCost = int.Parse(Get_DayCost.Text);//规定送货时延
                addInfomationtoDataBase ();
                //MessageBox.Show("新建成功!");
                //this.Close();
            } catch (Exception ae) {
                MessageBox.Show (ae.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addInfomationtoDataBase () {
            //GJS
            //此处代码应该对采购单管理数据库进行写入一个采购单数据
            //具体采购单数据表的格式参考随压缩包附带的Excel文档
            string Boss = Get_Need_Factory.Text;
            string ProductName = Get_Need_Name.Text;
            string Amount = Get_Num.Text;
            string Price = Get_Price.Text;
            string Profit = (Convert.ToDouble (Amount) * Convert.ToDouble (Price)).ToString ();
            string DayCost = Get_DayCost.Text;
            string Salesperson = Get_Saler.Text;
            string Location = Get_Location.Text;

            string sql = $"select im_id from materialinfo.intermediate_material where im_name = '{ProductName}';";
            MySqlCommand cmd = new MySqlCommand (sql, conn);
            Object reader = cmd.ExecuteScalar ();
            if (reader != null) {
                string ProductID = reader.ToString ();
                DateTime Now = DateTime.Now;
                string Order_Time = Now.ToString ("yyyyMMdd");
                string Dead_Line = Now.AddDays (Convert.ToInt32 (DayCost)).ToString ("yyyyMMdd");

                sql = $"insert into materialinfo.order_table " +
                    $"(product_name, amount, price, profit, salesperson, " +
                    $"factory, delivery_address, order_time, dead_line) values " +
                    $"('{ProductID}',{Amount},{Price},{Profit},'{Salesperson}','{Boss}','{Location}',{Order_Time},{Dead_Line});";
                cmd = new MySqlCommand (sql, conn);
                if (cmd.ExecuteNonQuery () > 0) MessageBox.Show ("Ok!", "插入订单数据", MessageBoxButtons.OK);
                else MessageBox.Show ("Failed!", "插入订单数据", MessageBoxButtons.OK);
            }
        }
    }
}