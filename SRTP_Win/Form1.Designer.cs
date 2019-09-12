namespace SRTP_Win
{
    partial class Log_Win
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_Win));
            this.Log_Button = new System.Windows.Forms.Button();
            this.User_Lable = new System.Windows.Forms.Label();
            this.Passwd_Lable = new System.Windows.Forms.Label();
            this.UserId_TextBox = new System.Windows.Forms.TextBox();
            this.PassWd_TextBox = new System.Windows.Forms.TextBox();
            this.LoglinkLabel = new System.Windows.Forms.LinkLabel();
            this.ForgetlinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Log_Button
            // 
            this.Log_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.Log_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.Log_Button.Font = new System.Drawing.Font("微软雅黑", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Log_Button.ForeColor = System.Drawing.Color.White;
            this.Log_Button.Location = new System.Drawing.Point(223, 178);
            this.Log_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Log_Button.Name = "Log_Button";
            this.Log_Button.Size = new System.Drawing.Size(212, 34);
            this.Log_Button.TabIndex = 0;
            this.Log_Button.Text = "登录";
            this.Log_Button.UseVisualStyleBackColor = false;
            this.Log_Button.Click += new System.EventHandler(this.Log_Button_Click);
            // 
            // User_Lable
            // 
            this.User_Lable.AutoSize = true;
            this.User_Lable.BackColor = System.Drawing.Color.Transparent;
            this.User_Lable.ForeColor = System.Drawing.Color.White;
            this.User_Lable.Location = new System.Drawing.Point(220, 33);
            this.User_Lable.Name = "User_Lable";
            this.User_Lable.Size = new System.Drawing.Size(108, 17);
            this.User_Lable.TabIndex = 2;
            this.User_Lable.Text = "用户名/Username";
            // 
            // Passwd_Lable
            // 
            this.Passwd_Lable.AutoSize = true;
            this.Passwd_Lable.BackColor = System.Drawing.Color.Transparent;
            this.Passwd_Lable.ForeColor = System.Drawing.Color.White;
            this.Passwd_Lable.Location = new System.Drawing.Point(220, 91);
            this.Passwd_Lable.Name = "Passwd_Lable";
            this.Passwd_Lable.Size = new System.Drawing.Size(93, 17);
            this.Passwd_Lable.TabIndex = 3;
            this.Passwd_Lable.Text = "密码/Password";
            // 
            // UserId_TextBox
            // 
            this.UserId_TextBox.Location = new System.Drawing.Point(223, 53);
            this.UserId_TextBox.Name = "UserId_TextBox";
            this.UserId_TextBox.Size = new System.Drawing.Size(209, 23);
            this.UserId_TextBox.TabIndex = 4;
            // 
            // PassWd_TextBox
            // 
            this.PassWd_TextBox.Location = new System.Drawing.Point(223, 111);
            this.PassWd_TextBox.Name = "PassWd_TextBox";
            this.PassWd_TextBox.Size = new System.Drawing.Size(209, 23);
            this.PassWd_TextBox.TabIndex = 5;
            this.PassWd_TextBox.UseSystemPasswordChar = true;
            // 
            // LoglinkLabel
            // 
            this.LoglinkLabel.AutoSize = true;
            this.LoglinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoglinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LoglinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(214)))), ((int)(((byte)(51)))));
            this.LoglinkLabel.Location = new System.Drawing.Point(376, 147);
            this.LoglinkLabel.Name = "LoglinkLabel";
            this.LoglinkLabel.Size = new System.Drawing.Size(56, 17);
            this.LoglinkLabel.TabIndex = 6;
            this.LoglinkLabel.TabStop = true;
            this.LoglinkLabel.Text = "立即注册";
            this.LoglinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoglinkLabel_LinkClicked);
            // 
            // ForgetlinkLabel
            // 
            this.ForgetlinkLabel.AutoSize = true;
            this.ForgetlinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForgetlinkLabel.ForeColor = System.Drawing.Color.Black;
            this.ForgetlinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ForgetlinkLabel.LinkColor = System.Drawing.Color.Silver;
            this.ForgetlinkLabel.Location = new System.Drawing.Point(224, 147);
            this.ForgetlinkLabel.Name = "ForgetlinkLabel";
            this.ForgetlinkLabel.Size = new System.Drawing.Size(56, 17);
            this.ForgetlinkLabel.TabIndex = 7;
            this.ForgetlinkLabel.TabStop = true;
            this.ForgetlinkLabel.Text = "忘记密码";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Log_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SRTP_Win.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 255);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ForgetlinkLabel);
            this.Controls.Add(this.LoglinkLabel);
            this.Controls.Add(this.PassWd_TextBox);
            this.Controls.Add(this.UserId_TextBox);
            this.Controls.Add(this.Passwd_Lable);
            this.Controls.Add(this.User_Lable);
            this.Controls.Add(this.Log_Button);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "Log_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Log_Button;
        private System.Windows.Forms.Label User_Lable;
        private System.Windows.Forms.Label Passwd_Lable;
        private System.Windows.Forms.TextBox UserId_TextBox;
        private System.Windows.Forms.TextBox PassWd_TextBox;
        private System.Windows.Forms.LinkLabel LoglinkLabel;
        private System.Windows.Forms.LinkLabel ForgetlinkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

