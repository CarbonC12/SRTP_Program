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
    public partial class Win_Add_Order : Form
    {
        public string FactoryLocation, Product, Saler, Factory;
        public int Num, Price, DayCost;
        private Main_Win MyFatherWin = null;
        public MySqlConnection conn = null;
        public Win_Add_Order(Main_Win FurtherWin, MySqlConnection FurtherCoon)
        {
            conn = FurtherCoon;
            MyFatherWin = FurtherWin;
            InitializeComponent();
        }

        private void Win_Add_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyFatherWin.Show();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            FactoryLocation = Get_Location.Text;//送货地址
            Product = Get_Need_Name.Text;//产品名称
            Saler = Get_Saler.Text;//销售员
            Factory = Get_Need_Factory.Text;//厂家
            try
            {
                Num = int.Parse(Get_Num.Text);//产品数量
                Price = int.Parse(Get_Price.Text);//产品单价
                DayCost = int.Parse(Get_DayCost.Text);//规定送货时延
                addInfomationtoDataBase();
                MessageBox.Show("新建成功!");
                this.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addInfomationtoDataBase()
        {
            //GJS
            //此处代码应该对采购单管理数据库进行写入一个采购单数据
            //具体采购单数据表的格式参考随压缩包附带的Excel文档
        }
    }
}
