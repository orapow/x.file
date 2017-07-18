using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using X.Core.Utility;

namespace X.File
{
    public class App
    {
        public static Config cfg { get; set; }

        public static void LoadConfig()
        {
            try
            {
                var json = System.IO.File.ReadAllText(Application.StartupPath + "\\cfg.x");
                if (!string.IsNullOrEmpty(json)) cfg = Serialize.FromJson<Config>(json);
            }
            catch
            {
                cfg = new Config();
            }
        }

        public static void SaveConfig()
        {
            var json = Serialize.ToJson(cfg);
            System.IO.File.WriteAllText(Application.StartupPath + "\\cfg.x", json);
        }

        public class Config
        {
            /// <summary>
            /// 工作文件夹
            /// </summary>
            public string work { get; set; }
            /// <summary>
            /// 当前文件夹
            /// </summary>
            public string dir { get; set; }
            /// <summary>
            /// 右侧窗口加载路径
            /// </summary>
            public string path { get; set; }
            public Dictionary<string, bool> nds { get; set; }
            public Dictionary<string, string> exts { get; set; }
            public Config()
            {
                exts = new Dictionary<string, string>();
                nds = new Dictionary<string, bool>();
            }
        }

        #region Icon
        public static ImageList
                il16 = new ImageList() { ColorDepth = ColorDepth.Depth32Bit, ImageSize = new Size(16, 16) },
                il20 = new ImageList() { ColorDepth = ColorDepth.Depth32Bit, ImageSize = new Size(20, 20) },
                il32 = new ImageList() { ColorDepth = ColorDepth.Depth32Bit, ImageSize = new Size(32, 32) };

        [DllImport("shell32.DLL", EntryPoint = "ExtractAssociatedIcon")]
        private static extern int ExtractAssociatedIconA(int hInst, string lpIconPath, ref int lpiIcon); //声明函数
        public static void getIcon(string key, string path)
        {
            if (il16.Images.ContainsKey(key)) return;
            int RefInt = 0;
            var hd = new IntPtr(ExtractAssociatedIconA(0, path, ref RefInt));
            var icon = Icon.FromHandle(hd);
            il16.Images.Add(key, icon);
            il20.Images.Add(key, icon);
            il32.Images.Add(key, icon);
        }
        #endregion
    }
}
