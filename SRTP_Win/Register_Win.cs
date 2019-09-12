using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SRTP_Win
{
    public partial class Register_Win : Form
    {
        public Register_Win(Log_Win tmp_Father_win)
        {
            Father_Win = tmp_Father_win;
            InitializeComponent();
        }

        private void Register_Win_FormClosed(object sender, FormClosedEventArgs e)
        {
            Father_Win.Show();
        }

        private void Re_Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
            Father_Win.Show();
        }
    }
}
