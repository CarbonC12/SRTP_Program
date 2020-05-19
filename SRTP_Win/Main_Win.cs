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
        private string connectStr = null;
        private string sql = null;
        public MySqlConnection conn = null;
        AutoResizeForm asc = new AutoResizeForm();
        //public Main_Win(Log_Win tmp_Father_Win_Son_Main)
        public Main_Win()
        {
            // Father_Log_Win = tmp_Father_Win_Son_Main;
            GetDataBaseConnection();
            InitializeComponent();
            InitDataGridView1();
            InitOrderDataGridView();
            InitPurchaseDataGridView();
            OrderTree.ExpandAll();//默认展开订单管理页面的树状菜单
            Tree_Purchase_Order.ExpandAll();//默认展开采购单管理页面的树状菜单
        }

        private void Main_Win_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Father_Log_Win.Close();
        }


        private void GetDataBaseConnection()
        {
            connectStr = "server=" + serverIP + ";user=" + username + ";password=" + password + ";database=materialinfo;Charset=utf8;";
            conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }




        //以下为对界面缩放的操作——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        private void Main_Win_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
        }

        private void Main_Win_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
        //界面缩放操作结束——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————




        //以下部分为对原材料管理页面的操作————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        private void MaterialTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string GetSelectText = MaterialTree.SelectedNode.Text;
            if (GetSelectText != "基本材料" && GetSelectText != "半成品" && GetSelectText != "电流线圈")
                ChangeMaterialDataGrid(GetSelectText);
        }
        private void InitDataGridView1()
        {
        }
        private void ChangeMaterialDataGrid(string SelectTreeNode)
        {
            //GJS
            //SelectTreeNode的值是中文材料类型（比如铜材，化工类）
            if(MaterialTree.SelectedNode.Parent.Text == "基本材料")
            {
                sql = $"select material_type_id from materialinfo.material_type where material_type_name = '{SelectTreeNode}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Object reader = cmd.ExecuteScalar();
                if(reader != null)
                {
                    sql = $"select * from materialinfo.fundamental_material where fm_type = '{reader.ToString()}'";
                }
            }else if(MaterialTree.SelectedNode.Parent.Text == "半成品" ||
                MaterialTree.SelectedNode.Parent.Text == "电流线圈")
            {
                sql = $"select * from materialinfo.intermediate_material where im_name = '{SelectTreeNode}' and im_parent is not null;";
            }else if(MaterialTree.SelectedNode.Parent.Text == "成品")
            {
                sql = $"select * from materialinfo.intermediate_material where im_name = '{SelectTreeNode}' and im_parent is null;";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        //原材料页面操作结束




        //以下部分为对订单页面的操作————————————————————————————————————————————————————————————————————————————————————————————————————————————
        private void InitOrderDataGridView()
        {
            //GJS
            //在这里初始化订单表格数据

        }
        private void OrderTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string GetSelectText = OrderTree.SelectedNode.Text;
            if (GetSelectText == "张三" || GetSelectText == "李四")
            {
                ChangeOrderGridInfo(OrderTree.SelectedNode.Text, Completed.Checked, NotCompleted.Checked);
            }

        }

        private void Completed_CheckedChanged(object sender, EventArgs e)
        {
            ChangeOrderGridInfo(OrderTree.SelectedNode.Text, Completed.Checked, NotCompleted.Checked);
        }

        private void NotCompleted_CheckedChanged(object sender, EventArgs e)
        {
            ChangeOrderGridInfo(OrderTree.SelectedNode.Text, Completed.Checked, NotCompleted.Checked);
        }

        private void ChangeOrderGridInfo(string TreeSelectNode, bool Completed, bool NotCompleted)
        {
            //GJS
            //在这里更改订单表格数据
            //订单表的格式详见随压缩包附带的EXCEL
            //需要判断Radio_Order_Run.Checked（正在进行的订单）和Radio_Order_Finish.Checked（已经完成的订单）谁为ture谁为false来进行数据库查询
            //同时需要判断树的当前选择节点GetSelectText值为张三/李四
            StringBuilder sqlBuilder = new StringBuilder();
            sql = $"select * from materialinfo.order_table where salesperson = '{TreeSelectNode}'";
            sqlBuilder.Append(sql);
            if (Completed && !NotCompleted)
            {
                sqlBuilder.Append(" and is_completed = 'Y'");
            }
            else if (NotCompleted && !Completed)
            {
                sqlBuilder.Append(" and is_completed = 'N'");
            }
            sqlBuilder.Append(";");
            MySqlDataAdapter da = new MySqlDataAdapter(sqlBuilder.ToString(), conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            OrderDataView.DataSource = dt;
        }

        private void Button_Add_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Win_Add_Order win_Add_Order = new Win_Add_Order(this, conn);
            win_Add_Order.Show();
        }
        //订单页面操作结束————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————



        //以下部分为对采购单部分的操作—————————————————————————————————————————————————————————————————————————————————————————————————————————————
        private void Button_Add_Purchase_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Win_Add_Purchase win_Add_Purchase = new Win_Add_Purchase(this, conn);
            win_Add_Purchase.Show();
        }

        private void InitPurchaseDataGridView()
        {
            //GJS
            //在这里初始化采购单表格数据
        }
        private void Tree_Purchase_Order_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Tree_Purchase_Order.SelectedNode.Text != "基本材料")
                ChangePurchaseDataGrid(Tree_Purchase_Order.SelectedNode.Text,
                    Completed1.Checked, NotCompleted1.Checked);
        }
        private void Completed1_CheckedChanged(object sender, EventArgs e)
        {
            ChangePurchaseDataGrid(Tree_Purchase_Order.SelectedNode.Text,
                Completed1.Checked, NotCompleted1.Checked);
        }
        private void NotCompleted1_CheckedChanged(object sender, EventArgs e)
        {
            ChangePurchaseDataGrid(Tree_Purchase_Order.SelectedNode.Text,
                Completed1.Checked, NotCompleted1.Checked);
        }
        private void ChangePurchaseDataGrid(string SelectTreeNode, bool Completed, bool NotCompleted)
        {
            //GJS
            //在这里更新采购单表格，基于选择的SelectTreeNode（内容就是种类的中文，比如铜材，化工类）
            sql = $"select material_type_id from materialinfo.material_type where material_type_name = '{SelectTreeNode}';";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            Object reader = cmd.ExecuteScalar();
            if (reader != null)
            {
                StringBuilder sqlBuilder = new StringBuilder();
                sql = $"select * from materialinfo.purchase_table where material_type = '{reader.ToString()}'";
                sqlBuilder.Append(sql);
                if (Completed && !NotCompleted)
                {
                    sqlBuilder.Append(" and is_completed = 'Y'");
                }
                else if (NotCompleted && !Completed)
                {
                    sqlBuilder.Append(" and is_completed = 'N'");
                }
                sqlBuilder.Append(";");
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuilder.ToString(), conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Grid_Purchase_Order.DataSource = dt;
            }
        }

        private void Grid_Purchase_Order_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        //对采购单界面操作结束————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————

        //生产管理页面——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————

       
        //生产管理页面结束——————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
    }
    class AutoResizeForm
    {
        //(1).声明结构,只记录窗体和其控件的初始位置和大小。
        public struct controlRect
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
        }
        //(2).声明 1个对象
        //注意这里不能使用控件列表记录 List nCtrl;，因为控件的关联性，记录的始终是当前的大小。
        //      public List oldCtrl= new List();//这里将西文的大于小于号都过滤掉了，只能改为中文的，使用中要改回西文
        public List<controlRect> oldCtrl = new List<controlRect>();
        int ctrlNo = 0;//1;
                       //(3). 创建两个函数
                       //(3.1)记录窗体和其控件的初始位置和大小,
        public void controllInitializeSize(Control mForm)
        {
            controlRect cR;
            cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height;
            oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可
            AddControl(mForm);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                              //this.WindowState = (System.Windows.Forms.FormWindowState)(2);//记录完控件的初始位置和大小后，再最大化
                              //0 - Normalize , 1 - Minimize,2- Maximize
        }
        private void AddControl(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {  //**放在这里，是先记录控件的子控件，后记录控件本身
               //if (c.Controls.Count > 0)
               //    AddControl(c);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                controlRect objCtrl;
                objCtrl.Left = c.Left; objCtrl.Top = c.Top; objCtrl.Width = c.Width; objCtrl.Height = c.Height;
                oldCtrl.Add(objCtrl);
                //**放在这里，是先记录控件本身，后记录控件的子控件
                if (c.Controls.Count > 0)
                    AddControl(c);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
            }
        }
        //(3.2)控件自适应大小,
        public void controlAutoSize(Control mForm)
        {
            if (ctrlNo == 0)
            { //*如果在窗体的Form1_Load中，记录控件原始的大小和位置，正常没有问题，但要加入皮肤就会出现问题，因为有些控件如dataGridView的的子控件还没有完成，个数少
              //*要在窗体的Form1_SizeChanged中，第一次改变大小时，记录控件原始的大小和位置,这里所有控件的子控件都已经形成
                controlRect cR;
                //  cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height;
                cR.Left = 0; cR.Top = 0; cR.Width = mForm.PreferredSize.Width; cR.Height = mForm.PreferredSize.Height;

                oldCtrl.Add(cR);//第一个为"窗体本身",只加入一次即可
                AddControl(mForm);//窗体内其余控件可能嵌套其它控件(比如panel),故单独抽出以便递归调用
            }
            float wScale = (float)mForm.Width / (float)oldCtrl[0].Width;//新旧窗体之间的比例，与最早的旧窗体
            float hScale = (float)mForm.Height / (float)oldCtrl[0].Height;//.Height;
            ctrlNo = 1;//进入=1，第0个为窗体本身,窗体内的控件,从序号1开始
            AutoScaleControl(mForm, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
        }
        private void AutoScaleControl(Control ctl, float wScale, float hScale)
        {
            int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
            //int ctrlNo = 1;//第1个是窗体自身的 Left,Top,Width,Height，所以窗体控件从ctrlNo=1开始
            foreach (Control c in ctl.Controls)
            { //**放在这里，是先缩放控件的子控件，后缩放控件本身
              //if (c.Controls.Count > 0)
              //   AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用
                ctrLeft0 = oldCtrl[ctrlNo].Left;
                ctrTop0 = oldCtrl[ctrlNo].Top;
                ctrWidth0 = oldCtrl[ctrlNo].Width;
                ctrHeight0 = oldCtrl[ctrlNo].Height;
                //c.Left = (int)((ctrLeft0 - wLeft0) * wScale) + wLeft1;//新旧控件之间的线性比例
                //c.Top = (int)((ctrTop0 - wTop0) * h) + wTop1;
                c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体，所以不能加 + wLeft1
                c.Top = (int)((ctrTop0) * hScale);//
                c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 (int)(c.Width * w);
                c.Height = (int)(ctrHeight0 * hScale);//
                ctrlNo++;//累加序号
                         //**放在这里，是先缩放控件本身，后缩放控件的子控件
                if (c.Controls.Count > 0)
                    AutoScaleControl(c, wScale, hScale);//窗体内其余控件还可能嵌套控件(比如panel),要单独抽出,因为要递归调用

                if (ctl is DataGridView)
                {
                    DataGridView dgv = ctl as DataGridView;
                    Cursor.Current = Cursors.WaitCursor;

                    int widths = 0;
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        dgv.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);  // 自动调整列宽  
                        widths += dgv.Columns[i].Width;   // 计算调整列后单元列的宽度和                       
                    }
                    if (widths >= ctl.Size.Width)  // 如果调整列的宽度大于设定列宽  
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;  // 调整列的模式 自动  
                    else
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // 如果小于 则填充  

                    Cursor.Current = Cursors.Default;
                }
            }
        }
    }
}

