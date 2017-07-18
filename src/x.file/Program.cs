using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X.File
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


            App.LoadConfig();
            while (string.IsNullOrEmpty(App.cfg.work) || !Directory.Exists(App.cfg.work))
            {
                MessageBox.Show(string.IsNullOrEmpty(App.cfg.work) ? "第一次使用请指定工作文件夹" : "工作文件夹“" + App.cfg.work + "”不存在，请重新设置", "系统提示");
                if (new Setting().ShowDialog() != DialogResult.OK) { break; }
            }

            if (!string.IsNullOrEmpty(App.cfg.work) && Directory.Exists(App.cfg.work)) Application.Run(new Main());

        }
    }
}
