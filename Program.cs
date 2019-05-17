using System;
using System.Windows.Forms;

namespace 个人财产管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main ( )
        {
            Application.EnableVisualStyles ( );
            Application.SetCompatibleTextRenderingDefault ( false );
            Application.Run ( new 登陆界面 ( ) );
        }
    }
}
