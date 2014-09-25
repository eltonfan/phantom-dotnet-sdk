using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavplus.Phantom.Win
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

            PhantomConfiguration config = PhantomConfiguration.Default;
            config.AppId = "9aa886e3a8a7d93a23136772835f1f40";
            config.AppSecret = "963bb7362c4cb3d4e3af86da4eb10fac";
            config.UserAgent = "chuangen@live.cn/1.0.0 (Windows 8.1)";
            config.RequestInterval = 2000;

            Application.Run(new MainForm());
        }
    }
}
