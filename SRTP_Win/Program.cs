using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SRTP_Win
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Log_Win log_Win = new Log_Win();
            Application.Run(log_Win);
        }
    }
}
