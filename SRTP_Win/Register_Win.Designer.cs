namespace SRTP_Win
{
    partial class Register_Win
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Log_Win Father_Win;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Win));
            this.Re_Button = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Re_User_Lable = new System.Windows.Forms.Label();
            this.Re_Passwd_Lable = new System.Windows.Forms.Label();
            this.Re_User_TextBox = new System.Windows.Forms.TextBox();
            this.Re_Passwd_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Re_Button
            // 
            this.Re_Button.Location = new System.Drawing.Point(108, 265);
            this.Re_Button.Name = "Re_Button";
            this.Re_Button.Size = new System.Drawing.Size(105, 47);
            this.Re_Button.TabIndex = 0;
            this.Re_Button.Text = "注册";
            this.Re_Button.UseVisualStyleBackColor = true;
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(408, 267);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(114, 44);
            this.Return_Button.TabIndex = 1;
            this.Return_Button.Text = "返回";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Re_Return_Button_Click);
            // 
            // Re_User_Lable
            // 
            this.Re_User_Lable.AutoSize = true;
            this.Re_User_Lable.Location = new System.Drawing.Point(114, 81);
            this.Re_User_Lable.Name = "Re_User_Lable";
            this.Re_User_Lable.Size = new System.Drawing.Size(107, 38);
            this.Re_User_Lable.TabIndex = 2;
            this.Re_User_Lable.Text = "用户名";
            // 
            // Re_Passwd_Lable
            // 
            this.Re_Passwd_Lable.AutoSize = true;
            this.Re_Passwd_Lable.Location = new System.Drawing.Point(114, 174);
            this.Re_Passwd_Lable.Name = "Re_Passwd_Lable";
            this.Re_Passwd_Lable.Size = new System.Drawing.Size(77, 38);
            this.Re_Passwd_Lable.TabIndex = 3;
            this.Re_Passwd_Lable.Text = "密码";
            // 
            // Re_User_TextBox
            // 
            this.Re_User_TextBox.Location = new System.Drawing.Point(270, 77);
            this.Re_User_TextBox.Name = "Re_User_TextBox";
            this.Re_User_TextBox.Size = new System.Drawing.Size(252, 42);
            this.Re_User_TextBox.TabIndex = 4;
            // 
            // Re_Passwd_TextBox
            // 
            this.Re_Passwd_TextBox.Location = new System.Drawing.Point(270, 170);
            this.Re_Passwd_TextBox.Name = "Re_Passwd_TextBox";
            this.Re_Passwd_TextBox.Size = new System.Drawing.Size(252, 42);
            this.Re_Passwd_TextBox.TabIndex = 5;
            this.Re_Passwd_TextBox.UseSystemPasswordChar = true;
            // 
            // Register_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 365);
            this.Controls.Add(this.Re_Passwd_TextBox);
            this.Controls.Add(this.Re_User_TextBox);
            this.Controls.Add(this.Re_Passwd_Lable);
            this.Controls.Add(this.Re_User_Lable);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.Re_Button);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_Win_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Re_Button;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Label Re_User_Lable;
        private System.Windows.Forms.Label Re_Passwd_Lable;
        private System.Windows.Forms.TextBox Re_User_TextBox;
        private System.Windows.Forms.TextBox Re_Passwd_TextBox;
    }
}