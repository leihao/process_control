using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Text.RegularExpressions;
using leihao.PCPC.UI;

namespace leihao.PCPC
{
    static class Program
    {
        public static FormMain frmMain;
       public static FormStart frmStart;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (args.Length > 0)
            {
                string firstarg = "";
                //检查第一个参数
                firstarg = args[0];

//                 Updater upd = new Updater();
//                 //如果程序以临时文件启动
//                 if (upd.CheckIfUpdating(Application.ExecutablePath))
//                 {
//                     //以自身覆盖目标文件
//                     upd.CopyTempFileToTargetFile(firstarg);
//                     //重新执行目标文件
//                     Process.Start(firstarg, "updated");
//                     //退出当前程序
//                     return;
//                 }
//                 else //如果参数为"updated"，删除临时文件
//                 {
//                     if (firstarg == "updated")
//                     {
//                         upd.DeleteTempFile();
//                     }
//                 }

            }
            //启动单实例管理器
            SingleInstanceManager manager = new SingleInstanceManager();//单实例管理器
            manager.Run(args);
        }
    }

    public class SingleInstanceManager : WindowsFormsApplicationBase
    {

        public SingleInstanceManager()
        {
            this.IsSingleInstance = true;
        }

        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
        {
            //set PCPC
            if (e.CommandLine.Count > 0)
            {
                string f = e.CommandLine[0].Trim('"');
                if (Regex.IsMatch(f, @"^\w:\\.+?\.PCPC", RegexOptions.IgnoreCase))
                {
                    PCPCStartup.IsHandled = false;
                    PCPCStartup.FilePath = f;
                }
            }
            Program.frmStart = new FormStart();
            Application.Run(Program.frmStart);
            return false;
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
        {
            base.OnStartupNextInstance(e);
            if (PCPCStartup.IsPlaying)
            {
                MessageBox.Show("PCPC is running...", "PCPC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //set PCPC
            if (e.CommandLine.Count > 0)
            {
                string f = e.CommandLine[0].Trim('"');
                if (Regex.IsMatch(f, @"^\w:\\.+?\.PCPC", RegexOptions.IgnoreCase))
                {
                    PCPCStartup.IsHandled = false;
                    PCPCStartup.FilePath = f;
                }
            }
            Program.frmMain.ShowFormToFront();
        }
    }

    public class PCPCStartup
    {
        public static bool IsHandled = true;
        public static string FilePath;
        public static bool IsPlaying = false;
    }

}
