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

            var msg = "";
            if (App.cfg.Places.Count == 0) msg = "请点击“新增”按钮\r\n选择“需交文件电子版”文件夹！";
            //else if (!Directory.Exists(App.cfg.Cp.Work)) msg = "采录点【" + App.cfg.Cp.Name + "】工作目录【" + App.cfg.Cp.Work + "】不存在，请重新选择或设置采录点！";

            if (!string.IsNullOrEmpty(msg) || App.cfg.Places.Count() > 1)
            {
                if (!string.IsNullOrEmpty(msg)) MessageBox.Show(msg, App.cfg.AppName);
                var pl = new Places();
                if (pl.ShowDialog() != DialogResult.OK) return;
                App.cfg.CpId = pl.Cpid;
            }
            else if (App.cfg.Places.Count() == 1)
            {
                App.cfg.CpId = App.cfg.Places[0].ID;
            }

            App.SaveConfig();
            Application.Run(new Main());

        }
    }
}
