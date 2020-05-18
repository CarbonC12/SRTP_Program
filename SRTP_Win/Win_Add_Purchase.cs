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
    public partial class Win_Add_Purchase : Form {
        public MySqlConnection conn = null;
        private Main_Win MyFatherWin = null;
        // public string Type, MaterialName, Manager, Factory;
        // public int Num, Price, DayCost;

        public Win_Add_Purchase (Main_Win Furtherwin, MySqlConnection FurtherConnection) {
            MyFatherWin = Furtherwin;
            conn = FurtherConnection;
            InitializeComponent ();
        }

        // New 使材料内容随着材料类别的改变而改变
        private void Get_Type_SelectedIndexChanged (object sender, EventArgs e) {
            string Type = Get_Type.Text;
            string sql = $"select material_type_id " +
                $"from materialinfo.material_type " +
                $"where material_type_name = '{Type}';";
            MySqlCommand cmd = new MySqlCommand (sql, conn);
            Object reader = cmd.ExecuteScalar ();
            if (reader != null) {
                sql = $"select fm_name " +
                    $"from materialinfo.fundamental_material " +
                    $"where fm_type = '{reader.ToString()}';";
                MySqlDataAdapter da2 = new MySqlDataAdapter (sql, conn);
                DataSet ds2 = new DataSet ();
                da2.Fill (ds2, "materialinfo.fundamental_material");
                DataTable dt2 = ds2.Tables["materialinfo.fundamental_material"];
                Get_Name.DataSource = dt2;
                Get_Name.DisplayMember = "fm_name";
                Get_Name.ValueMember = "fm_name";
            }
        }

        private void Win_Add_Purchase_FormClosing (object sender, FormClosingEventArgs e) {
            MyFatherWin.Show ();
        }

        private void button1_Click (object sender, EventArgs e) {
            // Type = Get_Type.Text;
            // MaterialName = Get_Name.Text;
            // Manager = Get_Manager.Text;
            // Factory = Get_Factory.Text;
            try {
                // Num = int.Parse(Get_Num.Text);
                // Price = int.Parse(Get_Price.Text);
                // DayCost = int.Parse(Get_DayCost.Text);
                addInfomationtoDataBase ();
                // MessageBox.Show("新建成功!");
                // this.Close();
            } catch (Exception ae) {
                MessageBox.Show (ae.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // New 将材料类别ComboBox与数据库绑定
        private void Win_Add_Purchase_Load (object sender, EventArgs e) {
            MySqlDataAdapter da1 = new MySqlDataAdapter (
                "select material_type_name from materialinfo.material_type;", conn);
            DataSet ds1 = new DataSet ();
            da1.Fill (ds1, "materialinfo.material_type");
            DataTable dt1 = ds1.Tables["materialinfo.material_type"];
            Get_Type.DataSource = dt1;
            Get_Type.DisplayMember = "material_type_name";
            Get_Type.ValueMember = "material_type_name";
        }

        private void addInfomationtoDataBase () {
            //GJS
            //此处代码应该对采购单管理数据库进行写入一个采购单数据
            //具体采购单数据表的格式参考随压缩包附带的Excel文档
            string Material_Type_ID = null;
            string Material_ID = null;
            string Material_Name = Get_Name.Text;
            string Material_Amount = Get_Num.Text;
            string Material_Price = Get_Price.Text;
            string Total = (Convert.ToDouble (Material_Price) * Convert.ToDouble (Material_Amount)).ToString ();
            string Day_Cost = Get_DayCost.Text;
            string Manager = Get_Manager.Text;
            string Factory = Get_Factory.Text;

            string sql = $"select fm_type,fm_id " +
                $"from fundamental_material " +
                $"where fm_name = '{Material_Name}';";
            MySqlCommand cmd = new MySqlCommand (sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader ();
            while (reader.Read ()) {
                Material_Type_ID = reader[0].ToString ();
                Material_ID = reader[1].ToString ();
            }
            reader.Close ();
            DateTime Now = DateTime.Now;
            string Order_Time = Now.ToString ("yyyyMMdd");
            string Dead_Line = Now.AddDays (Convert.ToInt32 (Day_Cost)).ToString ("yyyyMMdd");
            sql = $"insert into materialinfo.purchase_table " +
                $"(material_type, material_name, amount, price, total, " +
                $"order_time, dead_line, factory, person_in_charge) values " +
                $"('{Material_Type_ID}','{Material_ID}',{Material_Amount}," +
                $"{Material_Price},{Total},{Order_Time},{Dead_Line}, '{Factory}', '{Manager}');";
            cmd = new MySqlCommand (sql, conn);
            if (cmd.ExecuteNonQuery () > 0) MessageBox.Show ("Ok!", "插入采购数据", MessageBoxButtons.OK);
            else MessageBox.Show ("Failed!", "插入采购数据", MessageBoxButtons.OK);
        }

    }
}