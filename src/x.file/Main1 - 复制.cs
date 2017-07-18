using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using x.file.Properties;

namespace x.file
{
    public partial class Main1 : Form
    {
        [DllImport("shell32.DLL", EntryPoint = "ExtractAssociatedIcon")]
        private static extern int ExtractAssociatedIconA(int hInst, string lpIconPath, ref int lpiIcon); //声明函数
        Icon getIcon(string path)
        {
            int RefInt = 0;
            var hd = new IntPtr(ExtractAssociatedIconA(0, path, ref RefInt));
            return Icon.FromHandle(hd);
        }
        DB db = null;
        Media mp = null;
        string dir = "";
        public Main1()
        {
            InitializeComponent();
            App.LoadConfig();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(App.cfg.dir)) new Setting().ShowDialog();
            if (string.IsNullOrEmpty(App.cfg.dir)) { Close(); return; }
            InitDir("模板表", new DirectoryInfo(App.cfg.dir + "//模板表"));

            var il32 = new ImageList(components);
            il32.ColorDepth = ColorDepth.Depth32Bit;
            il32.ImageSize = new Size(32, 32);
            lv_files.LargeImageList = il32;

            var il16 = new ImageList(components);
            il16.ColorDepth = ColorDepth.Depth32Bit;
            il16.ImageSize = new Size(16, 16);
            lv_files.SmallImageList = il16;

            if (App.cfg.defVoc) tsb_voc_Click(null, null);
            else tsb_vod_Click(null, null);
            if (App.cfg.isHor) sp_pan2.Orientation = Orientation.Horizontal;
            if (App.cfg.openDir) { tsb_dir.Checked = App.cfg.openDir; sp_pan2.Panel2Collapsed = false; tsb_rot.Visible = true; }
            if (App.cfg.useBigicon) { lv_files.View = View.LargeIcon; tsb_view.Text = "大图标"; }
            else { lv_files.View = View.SmallIcon; tsb_view.Text = "小图标"; }

        }

        void InitDir(string root, DirectoryInfo di)
        {
            if (string.IsNullOrEmpty(App.cfg.dir)) return;
            tv_dir.Nodes.Clear();
            lb_tip.Text = "当前工作目录：" + App.cfg.dir;
            var tn = new TreeNode() { Text = root, Tag = App.cfg.dir };
            tn.Expand();
            tv_dir.Nodes.Add(tn);
            ((Action)(() =>
            {
                loadDir(di, tn.Nodes);
                tv_dir.ExpandAll();
            })).Invoke();
        }

        void loadDir(DirectoryInfo dir, TreeNodeCollection tns)
        {
            foreach (var d in dir.EnumerateDirectories())
            {
                Invoke(new Action(() =>
                {
                    var tn = new TreeNode() { Text = d.Name, Tag = d.FullName };
                    tns.Add(tn);
                    loadDir(d, tn.Nodes);
                }));
            }
            foreach (var f in dir.GetFiles())
            {
                Invoke(new Action(() =>
                {
                    var tn = new TreeNode() { Text = f.Name, Tag = f.FullName };
                    tns.Add(tn);
                }));
            }
        }
        void loadData(string name)
        {
            if (string.IsNullOrEmpty(name) || db == null) return;
            tsb_sheets.Text = name;
            dgv_list.AutoGenerateColumns = true;
            dgv_list.DataSource = db.LoadData(name);
            foreach (DataGridViewColumn c in dgv_list.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;
            tsl_data_tip.Text = "共有" + dgv_list.Rows.Count + "条数据";
        }

        private void tsmi_setting_Click(object sender, EventArgs e)
        {
            new Setting().ShowDialog();
        }

        private void tv_dir_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var file = e.Node.Tag.ToString();
            if (file.EndsWith(".doc") || file.EndsWith(".docx")) { Process.Start(file); return; }
        }

        private void loadFile(DirectoryInfo di)
        {
            if (!tsb_dir.Checked) return;
            if (di == null && App.cfg.pathes.ContainsKey(dir)) di = new DirectoryInfo(App.cfg.pathes[dir]);
            else if (di == null) di = new DirectoryInfo(App.cfg.dir + "\\" + (tsb_voc.Checked ? "录音" : "视频") + "\\" + dir);
            tsl_dir.Tag = di.FullName.Replace(App.cfg.dir, "\\").Replace("\\\\", "\\");
            tsl_dir.Text = "目录：" + tsl_dir.Tag;

            lv_files.Clear();

            if (!di.Exists) return;

            foreach (var d in di.GetDirectories())
            {
                if (!lv_files.SmallImageList.Images.ContainsKey("dir"))
                {
                    var icon = getIcon(d.FullName);
                    lv_files.SmallImageList.Images.Add("dir", icon);
                    lv_files.LargeImageList.Images.Add("dir", icon);
                }
                var lvi = new ListViewItem(d.Name, "dir");
                lvi.Tag = d.FullName;
                lv_files.Items.Add(lvi);
            }

            foreach (var f in di.GetFiles())
            {
                var px = f.FullName.Substring(f.FullName.LastIndexOf(".")).ToLower();
                if (!lv_files.SmallImageList.Images.ContainsKey(px))
                {
                    var icon = getIcon(f.FullName);
                    lv_files.SmallImageList.Images.Add(px, icon);
                    lv_files.LargeImageList.Images.Add(px, icon);
                }
                var lvi = new ListViewItem(f.Name, px);
                lvi.Tag = f.FullName;
                lv_files.Items.Add(lvi);
            }
            tsl_file_tip.Text = "文件夹 " + di.GetDirectories().LongLength + "个，文件" + di.GetFiles().LongLength + "个";

        }

        private void Tsi_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem m in tsb_sheets.DropDownItems) m.Checked = false;
            var mi = sender as ToolStripMenuItem;
            if (mi == null) mi = tsb_sheets.DropDownItems[0] as ToolStripMenuItem;
            mi.Checked = true;
            loadData(mi.Text);
        }

        private void dgv_list_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dt = dgv_list.DataSource as DataTable;
            var row = dgv_list.Rows[e.RowIndex];
            if (row == null) return;
            db.SetCellValue(e.RowIndex + 1, e.ColumnIndex, row.Cells[e.ColumnIndex].Value.ToString());
        }

        private void rb_tp_Click(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb == null) return;
            InitDir(rb.Text, new DirectoryInfo(App.cfg.dir + "/" + rb.Text));
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_list_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 && e.ColumnIndex < 0) return;
            if (e.RowIndex < 0) return;
            if (e.Button == MouseButtons.Right)
            {
                var pt = dgv_list.PointToScreen(e.Location);
                for (var c = 0; c < e.ColumnIndex; c++) pt.X += dgv_list.Columns[c].Width;
                for (var c = 0; c <= e.RowIndex; c++) pt.Y += dgv_list.Rows[c].Height;
                pt.X += 2;
                if (e.ColumnIndex >= 0) pt.X += dgv_list.RowHeadersWidth;
                pt.Y += 2 - dgv_list.VerticalScrollingOffset;
                cms_grid.Show(pt);
            }
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex < 0) dgv_list.Rows[e.RowIndex].Cells[0].Selected = true;
                else dgv_list.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            }
        }

        private void gcms_ref_Click(object sender, EventArgs e)
        {
            loadData(tsb_sheets.Text);
        }

        private void gcms_del_Click(object sender, EventArgs e)
        {
            if (dgv_list.SelectedCells.Count == 0) return;
            var c = dgv_list.SelectedCells[0];
            db.RemoveRow(c.RowIndex);
            loadData(tsb_sheets.Text);
        }

        private void tssb_dir_Click(object sender, EventArgs e)
        {
            sp_pan2.Panel2Collapsed = !sp_pan2.Panel2Collapsed;
            tsb_dir.Checked = !sp_pan2.Panel2Collapsed;
            tsb_rot.Visible = tsb_dir.Checked;
            App.cfg.openDir = tsb_dir.Checked;
            App.SaveConfig();
        }

        private void tssb_ref_Click(object sender, EventArgs e)
        {
            loadData(tsb_sheets.Text);
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mi = sender as ToolStripMenuItem;
            switch (mi.Tag + "")
            {
                case "1":
                    lv_files.View = View.SmallIcon;
                    break;
                case "2":
                    lv_files.View = View.LargeIcon;
                    break;
                case "3":
                    lv_files.View = View.Details;
                    break;
                case "4":
                    lv_files.View = View.List;
                    break;
                case "5":
                    lv_files.View = View.Tile;
                    break;
            }
            tsb_view.Text = mi.Text;
            App.cfg.useBigicon = mi.Tag + "" == "2";
            App.SaveConfig();
        }

        private void tv_dir_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tv_dir.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Left)
            {
                var file = e.Node.Tag.ToString().ToLower();
                if (!(file.Contains(".xls") || file.Contains(".doc"))) { loadFile(new DirectoryInfo(App.cfg.dir + "\\" + e.Node.FullPath)); return; }
                if (!(file.EndsWith(".xls") || file.EndsWith(".xlsx"))) return;
                loadTable(e.Node.FullPath.ToLower());
            }
        }
        void loadTable(string file)
        {
            if (db != null) db.Dispose();
            db = new DB(App.cfg.dir + "\\" + file);
            dir = file.Replace("模板表\\", "").Replace(".xls", "").Replace(".xlsx", "") + "\\";//  (e.Node.Tag + "").Replace(App.cfg.dir + "\\模板表\\", "\\").Replace(".xls", "").Replace(".xlsx", "");
            tsl_file.Text = "文件：" + file.Replace("模板表\\", "");// + (e.Node.Tag + "").Replace(App.cfg.dir, "");
            var ts = db.LoadTables();
            tsb_sheets.DropDownItems.Clear();
            foreach (var n in ts)
            {
                var tsi = new ToolStripMenuItem();
                tsi.Text = n;
                tsi.Click += Tsi_Click;
                tsb_sheets.DropDownItems.Add(tsi);
            };
            Tsi_Click(null, null);
            loadFile(null);
        }
        private void tsb_vod_Click(object sender, EventArgs e)
        {
            tsb_voc.Checked = false;
            tsb_vod.Checked = true;
            loadFile(null);
            App.cfg.defVoc = false;
            App.SaveConfig();
        }

        private void tsb_voc_Click(object sender, EventArgs e)
        {
            tsb_voc.Checked = true;
            tsb_vod.Checked = false;
            loadFile(null);
            App.cfg.defVoc = true;
            App.SaveConfig();
        }

        private void tsb_dir_sel_Click(object sender, EventArgs e)
        {
            var ofd = new Folder();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (App.cfg.pathes.ContainsKey(dir)) App.cfg.pathes[dir] = ofd.SelectedPath;
                else App.cfg.pathes.Add(dir, ofd.SelectedPath);
                App.SaveConfig();
                loadFile(new DirectoryInfo(ofd.SelectedPath));
            }
        }

        private void lv_files_DoubleClick(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var it = lv_files.SelectedItems[0];
            if (it.Tag == null) return;
            if (it.Text.ToLower().Contains(".xls")) loadTable(it.Tag.ToString().Replace(App.cfg.dir, ""));
            else if (it.Text.ToLower().Contains(".doc")) Process.Start(it.Tag.ToString());
            else if (it.Text.ToLower().Contains(".mp4") || it.Text.ToLower().Contains(".wav") || it.Text.ToLower().Contains(".mpg")) playfile(it.Tag + "");
            else if (it.Text.Contains(".")) Process.Start(it.Tag + "");
            else loadFile(new DirectoryInfo(it.Tag + ""));
        }
        void playfile(string file)
        {
            if (mp == null) { mp = new Media(); mp.FormClosed += Mp_FormClosed; mp.Show(); }
            else mp.Stop();
            mp.Play(file);
        }

        private void Mp_FormClosed(object sender, FormClosedEventArgs e)
        {
            mp.Dispose();
            mp = null;
        }

        private void tsmi_play_Click(object sender, EventArgs e)
        {
            var c = dgv_list.SelectedCells[0];
            var fn = dgv_list.Rows[c.RowIndex].Cells[0].Value.ToString() + dgv_list.Rows[c.RowIndex].Cells[1].Value.ToString();
            var di = new DirectoryInfo(App.cfg.dir + tsl_dir.Tag + "");
            var fs = di.GetFiles(fn + "*");
            if (fs.Length > 0) playfile(fs[0].FullName);
        }

        private void tsmi_playlist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在开发中");
        }

        private void gcms_insert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正在开发中");
        }

        private void tv_dir_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void 打开所在目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            Process.Start("explorer.exe", "/select," + tn.Tag.ToString());
        }

        private void 用Office打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            Process.Start(tn.Tag.ToString());
        }

        private void 重新加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitDir("模板表", new DirectoryInfo(App.cfg.dir + "\\模板表"));
        }
    }
}
