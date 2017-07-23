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
            public View Views { get; set; }
            public ExApp ExApps { get; set; }
            public List<Place> Places { get; set; }
            public Place Cp { get; set; }

            public Config()
            {
                Places = new List<Place>();
                Views = new View();
                ExApps = new ExApp();
            }

            public class ExApp
            {
                public string Audac { get; set; }
                public string Praat { get; set; }
                public string YuBao { get; set; }
                public string Solveig { get; set; }
            }

            public class View
            {
                public string[] Tabs { get; set; }
                public string[] Docs { get; set; }
                public string[] Pics { get; set; }
                public string[] Vods { get; set; }
                public string[] Vocs { get; set; }

                public string GetViewer(string ext)
                {
                    if (Tabs != null && Tabs.Contains(ext)) return "表格";
                    if (Docs != null && Docs.Contains(ext)) return "文档";
                    if (Pics != null && Pics.Contains(ext)) return "图片";
                    if (Vods != null && Vods.Contains(ext)) return "视频";
                    if (Vocs != null && Vocs.Contains(ext)) return "录音";
                    return "";
                }
            }

            public class Place
            {
                /// <summary>
                /// 地点名称
                /// </summary>
                public string Name { get; set; }
                /// <summary>
                /// 工作路径
                /// </summary>
                public string Work { get; set; }
                /// <summary>
                /// 当前目录
                /// </summary>
                public string Dir { get; set; }
                /// <summary>
                /// 右侧加载路径
                /// </summary>
                public string Path { get; set; }
                public Dictionary<string, bool> Nodes { get; set; }
                public Place()
                {
                    Nodes = new Dictionary<string, bool>();
                }
                public override string ToString()
                {
                    return Name + "　" + Work;
                }
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
