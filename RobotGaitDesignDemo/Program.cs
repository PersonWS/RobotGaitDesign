using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotGaitDesign
{
    internal static class Program
    {
        public static readonly LogHelper.ILogEntity LogRecorder_business = LogHelper.EasyLogger.GetLoggerInstance_log4Net("form1");
        public static readonly LogHelper.ILogEntity LogRecorder_runLog = LogHelper.EasyLogger.GetLoggerInstance_log4Net("form1");
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += ShowThreadException;
            Application.Run(new Frm_RobotMotorControlMain());
        }

        private static void ShowThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            LogRecorder_runLog.Fatal($"意料之外的异常! , ex ;{e.Exception.StackTrace}");
            ThreadExceptionDialog threadExceptionDialog = new ThreadExceptionDialog(e.Exception);
            threadExceptionDialog.ShowDialog();
            if (threadExceptionDialog.DialogResult == DialogResult.Cancel)
            {
                LogRecorder_runLog.Fatal($"意料之外的异常! , 用户选择继续！");
                threadExceptionDialog.Close();
            }
            else if (threadExceptionDialog.DialogResult == DialogResult.Abort)
            {
                LogRecorder_runLog.Fatal($"意料之外的异常! , 用户选择退出！");
                Application.Exit();
            }
            //BaseFrmControl.ShowErrorMessageBox(threadExceptionDialog, e.Exception.StackTrace.ToString());
        }


    }
}
