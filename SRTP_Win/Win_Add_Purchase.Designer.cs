namespace SRTP_Win
{
    partial class Win_Add_Purchase
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.Group_Add_Purchase = new System.Windows.Forms.GroupBox();
            this.Get_Name = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Get_Factory = new System.Windows.Forms.TextBox();
            this.Get_DayCost = new System.Windows.Forms.TextBox();
            this.Get_Manager = new System.Windows.Forms.ComboBox();
            this.Get_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Get_Type = new System.Windows.Forms.ComboBox();
            this.rMTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sRTPDataSet = new SRTP_Win.SRTPDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.Get_Num = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oRDPDTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRD_PD_TABLETableAdapter = new SRTP_Win.SRTPDataSetTableAdapters.ORD_PD_TABLETableAdapter();
            this.oRDPDTABLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pDTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pD_TABLETableAdapter = new SRTP_Win.SRTPDataSetTableAdapters.PD_TABLETableAdapter();
            this.rM_TABLETableAdapter = new SRTP_Win.SRTPDataSetTableAdapters.RM_TABLETableAdapter();
            this.Group_Add_Purchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rMTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRTPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDPDTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDPDTABLEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDTABLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(274, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "增加新的采购单";
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.BTN_Submit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_Submit.ForeColor = System.Drawing.Color.White;
            this.BTN_Submit.Location = new System.Drawing.Point(318, 384);
            this.BTN_Submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(138, 36);
            this.BTN_Submit.TabIndex = 1;
            this.BTN_Submit.Text = "确认";
            this.BTN_Submit.UseVisualStyleBackColor = false;
            this.BTN_Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Group_Add_Purchase
            // 
            this.Group_Add_Purchase.Controls.Add(this.Get_Name);
            this.Group_Add_Purchase.Controls.Add(this.label11);
            this.Group_Add_Purchase.Controls.Add(this.Get_Factory);
            this.Group_Add_Purchase.Controls.Add(this.Get_DayCost);
            this.Group_Add_Purchase.Controls.Add(this.Get_Manager);
            this.Group_Add_Purchase.Controls.Add(this.Get_Price);
            this.Group_Add_Purchase.Controls.Add(this.label10);
            this.Group_Add_Purchase.Controls.Add(this.Get_Type);
            this.Group_Add_Purchase.Controls.Add(this.label9);
            this.Group_Add_Purchase.Controls.Add(this.Get_Num);
            this.Group_Add_Purchase.Controls.Add(this.label8);
            this.Group_Add_Purchase.Controls.Add(this.label7);
            this.Group_Add_Purchase.Controls.Add(this.label6);
            this.Group_Add_Purchase.Controls.Add(this.label5);
            this.Group_Add_Purchase.Controls.Add(this.label4);
            this.Group_Add_Purchase.Controls.Add(this.label3);
            this.Group_Add_Purchase.Controls.Add(this.label2);
            this.Group_Add_Purchase.Location = new System.Drawing.Point(46, 54);
            this.Group_Add_Purchase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Group_Add_Purchase.Name = "Group_Add_Purchase";
            this.Group_Add_Purchase.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Group_Add_Purchase.Size = new System.Drawing.Size(677, 314);
            this.Group_Add_Purchase.TabIndex = 2;
            this.Group_Add_Purchase.TabStop = false;
            // 
            // Get_Name
            // 
            this.Get_Name.FormattingEnabled = true;
            this.Get_Name.Location = new System.Drawing.Point(464, 42);
            this.Get_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Get_Name.Name = "Get_Name";
            this.Get_Name.Size = new System.Drawing.Size(150, 28);
            this.Get_Name.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 167);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "天";
            // 
            // Get_Factory
            // 
            this.Get_Factory.Location = new System.Drawing.Point(114, 227);
            this.Get_Factory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Get_Factory.Name = "Get_Factory";
            this.Get_Factory.Size = new System.Drawing.Size(246, 27);
            this.Get_Factory.TabIndex = 14;
            // 
            // Get_DayCost
            // 
            this.Get_DayCost.Location = new System.Drawing.Point(146, 166);
            this.Get_DayCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Get_DayCost.Name = "Get_DayCost";
            this.Get_DayCost.Size = new System.Drawing.Size(68, 27);
            this.Get_DayCost.TabIndex = 13;
            // 
            // Get_Manager
            // 
            this.Get_Manager.FormattingEnabled = true;
            this.Get_Manager.Items.AddRange(new object[] {
            "李明",
            "程松"});
            this.Get_Manager.Location = new System.Drawing.Point(444, 166);
            this.Get_Manager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Get_Manager.Name = "Get_Manager";
            this.Get_Manager.Size = new System.Drawing.Size(107, 28);
            this.Get_Manager.TabIndex = 12;
            this.Get_Manager.Text = "李明";
            // 
            // Get_Price
            // 
            this.Get_Price.Location = new System.Drawing.Point(431, 104);
            this.Get_Price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Get_Price.Name = "Get_Price";
            this.Get_Price.Size = new System.Drawing.Size(120, 27);
            this.Get_Price.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(552, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "元/单位";
            // 
            // Get_Type
            // 
            this.Get_Type.DataSource = this.rMTABLEBindingSource;
            this.Get_Type.DisplayMember = "RM_NAME";
            this.Get_Type.FormattingEnabled = true;
            this.Get_Type.Location = new System.Drawing.Point(146, 42);
            this.Get_Type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Get_Type.Name = "Get_Type";
            this.Get_Type.Size = new System.Drawing.Size(143, 28);
            this.Get_Type.TabIndex = 9;
            this.Get_Type.ValueMember = "RM_NAME";
            this.Get_Type.SelectedIndexChanged += new System.EventHandler(this.Get_Type_SelectedIndexChanged);
            // 
            // rMTABLEBindingSource
            // 
            this.rMTABLEBindingSource.DataMember = "RM_TABLE";
            this.rMTABLEBindingSource.DataSource = this.sRTPDataSet;
            // 
            // sRTPDataSet
            // 
            this.sRTPDataSet.DataSetName = "SRTPDataSet";
            this.sRTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "个/米/KG";
            // 
            // Get_Num
            // 
            this.Get_Num.Location = new System.Drawing.Point(114, 104);
            this.Get_Num.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Get_Num.Name = "Get_Num";
            this.Get_Num.Size = new System.Drawing.Size(100, 27);
            this.Get_Num.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "规定采购耗时：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "采购经办人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "采购厂家：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "采购单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "采购数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "采购材料名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "采购材料类别：";
            // 
            // oRDPDTABLEBindingSource
            // 
            this.oRDPDTABLEBindingSource.DataMember = "ORD_PD_TABLE";
            this.oRDPDTABLEBindingSource.DataSource = this.sRTPDataSet;
            // 
            // oRD_PD_TABLETableAdapter
            // 
            this.oRD_PD_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // oRDPDTABLEBindingSource1
            // 
            this.oRDPDTABLEBindingSource1.DataMember = "ORD_PD_TABLE";
            this.oRDPDTABLEBindingSource1.DataSource = this.sRTPDataSet;
            // 
            // pDTABLEBindingSource
            // 
            this.pDTABLEBindingSource.DataMember = "PD_TABLE";
            this.pDTABLEBindingSource.DataSource = this.sRTPDataSet;
            // 
            // pD_TABLETableAdapter
            // 
            this.pD_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // rM_TABLETableAdapter
            // 
            this.rM_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // Win_Add_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(774, 436);
            this.Controls.Add(this.Group_Add_Purchase);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Win_Add_Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加新采购单";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Win_Add_Purchase_FormClosing);
            this.Load += new System.EventHandler(this.Win_Add_Purchase_Load);
            this.Group_Add_Purchase.ResumeLayout(false);
            this.Group_Add_Purchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rMTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sRTPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDPDTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDPDTABLEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDTABLEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.GroupBox Group_Add_Purchase;
        private System.Windows.Forms.ComboBox Get_Type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Get_Num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private SRTPDataSet sRTPDataSet;
        private System.Windows.Forms.BindingSource oRDPDTABLEBindingSource;
        private SRTPDataSetTableAdapters.ORD_PD_TABLETableAdapter oRD_PD_TABLETableAdapter;
        private System.Windows.Forms.BindingSource oRDPDTABLEBindingSource1;
        private System.Windows.Forms.BindingSource pDTABLEBindingSource;
        private SRTPDataSetTableAdapters.PD_TABLETableAdapter pD_TABLETableAdapter;
        private System.Windows.Forms.BindingSource rMTABLEBindingSource;
        private SRTPDataSetTableAdapters.RM_TABLETableAdapter rM_TABLETableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Get_Factory;
        private System.Windows.Forms.TextBox Get_DayCost;
        private System.Windows.Forms.ComboBox Get_Manager;
        private System.Windows.Forms.TextBox Get_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Get_Name;
    }
}