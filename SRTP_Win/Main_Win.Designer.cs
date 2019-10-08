namespace SRTP_Win
{
    partial class Main_Win
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Log_Win Father_Log_Win;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Win));
            this.Original_Tab = new System.Windows.Forms.TabControl();
            this.Tab_A = new System.Windows.Forms.TabPage();
            this.Tab_A_Store = new System.Windows.Forms.TabControl();
            this.Raw_Material_Tab = new System.Windows.Forms.TabPage();
            this.GetData_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Tab = new System.Windows.Forms.TabPage();
            this.Tab_B = new System.Windows.Forms.TabPage();
            this.Tab_C = new System.Windows.Forms.TabPage();
            this.Tab_D = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Original_Tab.SuspendLayout();
            this.Tab_A.SuspendLayout();
            this.Tab_A_Store.SuspendLayout();
            this.Raw_Material_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Product_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Original_Tab
            // 
            this.Original_Tab.Controls.Add(this.Tab_A);
            this.Original_Tab.Controls.Add(this.Tab_B);
            this.Original_Tab.Controls.Add(this.Tab_C);
            this.Original_Tab.Controls.Add(this.Tab_D);
            this.Original_Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Original_Tab.Location = new System.Drawing.Point(0, 0);
            this.Original_Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Original_Tab.Name = "Original_Tab";
            this.Original_Tab.SelectedIndex = 0;
            this.Original_Tab.Size = new System.Drawing.Size(852, 525);
            this.Original_Tab.TabIndex = 0;
            // 
            // Tab_A
            // 
            this.Tab_A.Controls.Add(this.Tab_A_Store);
            this.Tab_A.Location = new System.Drawing.Point(4, 26);
            this.Tab_A.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_A.Name = "Tab_A";
            this.Tab_A.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_A.Size = new System.Drawing.Size(844, 495);
            this.Tab_A.TabIndex = 0;
            this.Tab_A.Text = "仓储管理";
            this.Tab_A.UseVisualStyleBackColor = true;
            // 
            // Tab_A_Store
            // 
            this.Tab_A_Store.Controls.Add(this.Raw_Material_Tab);
            this.Tab_A_Store.Controls.Add(this.Product_Tab);
            this.Tab_A_Store.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_A_Store.Location = new System.Drawing.Point(4, 4);
            this.Tab_A_Store.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_A_Store.Name = "Tab_A_Store";
            this.Tab_A_Store.SelectedIndex = 0;
            this.Tab_A_Store.Size = new System.Drawing.Size(836, 487);
            this.Tab_A_Store.TabIndex = 0;
            // 
            // Raw_Material_Tab
            // 
            this.Raw_Material_Tab.Controls.Add(this.GetData_Button);
            this.Raw_Material_Tab.Controls.Add(this.dataGridView1);
            this.Raw_Material_Tab.Location = new System.Drawing.Point(4, 26);
            this.Raw_Material_Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Raw_Material_Tab.Name = "Raw_Material_Tab";
            this.Raw_Material_Tab.Padding = new System.Windows.Forms.Padding(4);
            this.Raw_Material_Tab.Size = new System.Drawing.Size(828, 457);
            this.Raw_Material_Tab.TabIndex = 0;
            this.Raw_Material_Tab.Text = "原材料仓储";
            this.Raw_Material_Tab.UseVisualStyleBackColor = true;
            this.Raw_Material_Tab.Click += new System.EventHandler(this.Raw_Material_Tab_Click);
            // 
            // GetData_Button
            // 
            this.GetData_Button.Location = new System.Drawing.Point(639, 7);
            this.GetData_Button.Name = "GetData_Button";
            this.GetData_Button.Size = new System.Drawing.Size(82, 35);
            this.GetData_Button.TabIndex = 1;
            this.GetData_Button.Text = "查询";
            this.GetData_Button.UseVisualStyleBackColor = true;
            this.GetData_Button.Click += new System.EventHandler(this.GetData_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.Size = new System.Drawing.Size(698, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.Enter += new System.EventHandler(this.DataGridView1_Enter);
            // 
            // Product_Tab
            // 
            this.Product_Tab.Controls.Add(this.button1);
            this.Product_Tab.Location = new System.Drawing.Point(4, 26);
            this.Product_Tab.Margin = new System.Windows.Forms.Padding(4);
            this.Product_Tab.Name = "Product_Tab";
            this.Product_Tab.Padding = new System.Windows.Forms.Padding(4);
            this.Product_Tab.Size = new System.Drawing.Size(828, 457);
            this.Product_Tab.TabIndex = 1;
            this.Product_Tab.Text = "成品仓储";
            this.Product_Tab.UseVisualStyleBackColor = true;
            // 
            // Tab_B
            // 
            this.Tab_B.Location = new System.Drawing.Point(4, 26);
            this.Tab_B.Margin = new System.Windows.Forms.Padding(4);
            this.Tab_B.Name = "Tab_B";
            this.Tab_B.Padding = new System.Windows.Forms.Padding(4);
            this.Tab_B.Size = new System.Drawing.Size(844, 495);
            this.Tab_B.TabIndex = 1;
            this.Tab_B.Text = "订单管理";
            this.Tab_B.UseVisualStyleBackColor = true;
            // 
            // Tab_C
            // 
            this.Tab_C.Location = new System.Drawing.Point(4, 26);
            this.Tab_C.Name = "Tab_C";
            this.Tab_C.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_C.Size = new System.Drawing.Size(844, 495);
            this.Tab_C.TabIndex = 2;
            this.Tab_C.Text = "采购单管理";
            this.Tab_C.UseVisualStyleBackColor = true;
            // 
            // Tab_D
            // 
            this.Tab_D.Location = new System.Drawing.Point(4, 26);
            this.Tab_D.Name = "Tab_D";
            this.Tab_D.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_D.Size = new System.Drawing.Size(844, 495);
            this.Tab_D.TabIndex = 3;
            this.Tab_D.Text = "生产管理";
            this.Tab_D.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Main_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 525);
            this.Controls.Add(this.Original_Tab);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SRTP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Win_FormClosed);
            this.Original_Tab.ResumeLayout(false);
            this.Tab_A.ResumeLayout(false);
            this.Tab_A_Store.ResumeLayout(false);
            this.Raw_Material_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Product_Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Original_Tab;
        private System.Windows.Forms.TabPage Tab_A;
        private System.Windows.Forms.TabPage Tab_B;
        private System.Windows.Forms.TabControl Tab_A_Store;
        private System.Windows.Forms.TabPage Raw_Material_Tab;
        private System.Windows.Forms.TabPage Product_Tab;
        private System.Windows.Forms.TabPage Tab_C;
        private System.Windows.Forms.TabPage Tab_D;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetData_Button;
        private System.Windows.Forms.Button button1;
    }
}