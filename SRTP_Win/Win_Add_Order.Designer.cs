namespace SRTP_Win
{
    partial class Win_Add_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Group_Add_Purchase = new System.Windows.Forms.GroupBox();
            this.Get_Need_Factory = new System.Windows.Forms.TextBox();
            this.Get_Need_Name = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Get_Location = new System.Windows.Forms.TextBox();
            this.Get_DayCost = new System.Windows.Forms.TextBox();
            this.Get_Saler = new System.Windows.Forms.ComboBox();
            this.Get_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Get_Num = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.Group_Add_Purchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(582, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "增加新的订单";
            // 
            // Group_Add_Purchase
            // 
            this.Group_Add_Purchase.Controls.Add(this.Get_Need_Factory);
            this.Group_Add_Purchase.Controls.Add(this.Get_Need_Name);
            this.Group_Add_Purchase.Controls.Add(this.label11);
            this.Group_Add_Purchase.Controls.Add(this.Get_Location);
            this.Group_Add_Purchase.Controls.Add(this.Get_DayCost);
            this.Group_Add_Purchase.Controls.Add(this.Get_Saler);
            this.Group_Add_Purchase.Controls.Add(this.Get_Price);
            this.Group_Add_Purchase.Controls.Add(this.label10);
            this.Group_Add_Purchase.Controls.Add(this.label9);
            this.Group_Add_Purchase.Controls.Add(this.Get_Num);
            this.Group_Add_Purchase.Controls.Add(this.label8);
            this.Group_Add_Purchase.Controls.Add(this.label7);
            this.Group_Add_Purchase.Controls.Add(this.label6);
            this.Group_Add_Purchase.Controls.Add(this.label5);
            this.Group_Add_Purchase.Controls.Add(this.label4);
            this.Group_Add_Purchase.Controls.Add(this.label3);
            this.Group_Add_Purchase.Controls.Add(this.label2);
            this.Group_Add_Purchase.Location = new System.Drawing.Point(102, 128);
            this.Group_Add_Purchase.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Add_Purchase.Name = "Group_Add_Purchase";
            this.Group_Add_Purchase.Padding = new System.Windows.Forms.Padding(4);
            this.Group_Add_Purchase.Size = new System.Drawing.Size(1345, 589);
            this.Group_Add_Purchase.TabIndex = 3;
            this.Group_Add_Purchase.TabStop = false;
            // 
            // Get_Need_Factory
            // 
            this.Get_Need_Factory.Location = new System.Drawing.Point(242, 90);
            this.Get_Need_Factory.Margin = new System.Windows.Forms.Padding(4);
            this.Get_Need_Factory.Name = "Get_Need_Factory";
            this.Get_Need_Factory.Size = new System.Drawing.Size(387, 27);
            this.Get_Need_Factory.TabIndex = 17;
            // 
            // Get_Need_Name
            // 
            this.Get_Need_Name.FormattingEnabled = true;
            this.Get_Need_Name.Location = new System.Drawing.Point(905, 85);
            this.Get_Need_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Get_Need_Name.Name = "Get_Need_Name";
            this.Get_Need_Name.Size = new System.Drawing.Size(364, 28);
            this.Get_Need_Name.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "天";
            // 
            // Get_Location
            // 
            this.Get_Location.Location = new System.Drawing.Point(242, 507);
            this.Get_Location.Margin = new System.Windows.Forms.Padding(4);
            this.Get_Location.Name = "Get_Location";
            this.Get_Location.Size = new System.Drawing.Size(885, 27);
            this.Get_Location.TabIndex = 14;
            // 
            // Get_DayCost
            // 
            this.Get_DayCost.Location = new System.Drawing.Point(308, 368);
            this.Get_DayCost.Margin = new System.Windows.Forms.Padding(4);
            this.Get_DayCost.Name = "Get_DayCost";
            this.Get_DayCost.Size = new System.Drawing.Size(84, 27);
            this.Get_DayCost.TabIndex = 13;
            // 
            // Get_Saler
            // 
            this.Get_Saler.FormattingEnabled = true;
            this.Get_Saler.Items.AddRange(new object[] {
            "张三",
            "李四"});
            this.Get_Saler.Location = new System.Drawing.Point(876, 368);
            this.Get_Saler.Margin = new System.Windows.Forms.Padding(4);
            this.Get_Saler.Name = "Get_Saler";
            this.Get_Saler.Size = new System.Drawing.Size(251, 28);
            this.Get_Saler.TabIndex = 12;
            this.Get_Saler.Text = "张三";
            // 
            // Get_Price
            // 
            this.Get_Price.Location = new System.Drawing.Point(905, 229);
            this.Get_Price.Margin = new System.Windows.Forms.Padding(4);
            this.Get_Price.Name = "Get_Price";
            this.Get_Price.Size = new System.Drawing.Size(222, 27);
            this.Get_Price.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1135, 229);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "元/台";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "台";
            // 
            // Get_Num
            // 
            this.Get_Num.Location = new System.Drawing.Point(242, 229);
            this.Get_Num.Margin = new System.Windows.Forms.Padding(4);
            this.Get_Num.Name = "Get_Num";
            this.Get_Num.Size = new System.Drawing.Size(150, 27);
            this.Get_Num.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "规定送货时延：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(756, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "销售员：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 507);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "送货地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(756, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "订购单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "订购数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "产品名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "订购厂家：";
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.BTN_Submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_Submit.ForeColor = System.Drawing.Color.White;
            this.BTN_Submit.Location = new System.Drawing.Point(614, 743);
            this.BTN_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(332, 92);
            this.BTN_Submit.TabIndex = 17;
            this.BTN_Submit.Text = "确认";
            this.BTN_Submit.UseVisualStyleBackColor = false;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // Win_Add_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 872);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.Group_Add_Purchase);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Win_Add_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加新订单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Win_Add_Order_FormClosing);
            this.Load += new System.EventHandler(this.Win_Add_Order_Load);
            this.Group_Add_Purchase.ResumeLayout(false);
            this.Group_Add_Purchase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Group_Add_Purchase;
        private System.Windows.Forms.ComboBox Get_Need_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Get_Location;
        private System.Windows.Forms.TextBox Get_DayCost;
        private System.Windows.Forms.ComboBox Get_Saler;
        private System.Windows.Forms.TextBox Get_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Get_Num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.TextBox Get_Need_Factory;
    }
}