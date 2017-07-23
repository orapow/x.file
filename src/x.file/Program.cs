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

            if (App.cfg.Places.Count == 0)
            {
                MessageBox.Show("第一次使用请添加一个地点和工作目录", "系统提示");
                var pl = new Place();
                if (pl.ShowDialog() != DialogResult.OK) return;

                var p = new App.Config.Place() { Work = pl.PDir, Name = pl.PName };
                App.cfg.Places.Add(p);
                App.cfg.Cp = p;
            }

            if (App.cfg.Cp == null) App.cfg.Cp = App.cfg.Places[0];

            if (string.IsNullOrEmpty(App.cfg.Cp.Work) || !Directory.Exists(App.cfg.Cp.Work))
            {
                MessageBox.Show("工作文件夹【" + App.cfg.Cp.Work + "】不存在，请重新设置", "系统提示");
                var pl = new Place() { PName = App.cfg.Cp.Name, PDir = "" };
                if (pl.ShowDialog() != DialogResult.OK) return;
                var p = App.cfg.Places.FirstOrDefault(o => o.Name == pl.PName);
                if (p == null) p = new App.Config.Place() { Name = pl.PName };
                p.Work = pl.PDir;
                App.cfg.Cp = p;
            }
            App.SaveConfig();

            Application.Run(new Main());

        }
    }
}
