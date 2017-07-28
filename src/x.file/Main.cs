using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;

namespace X.File
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tv_dir.ImageList = App.il20;
            tssl_pname.Text = App.cfg.Cp.Name;
            foreach (var p in App.cfg.Places) cb_places.Items.Add(p);
            cb_places.SelectedIndex = 0;
        }

        void Init()
        {
            if (string.IsNullOrEmpty(App.cfg.Cp.Dir)) rb_tpl.Checked = true;
            else
            {
                var d = App.cfg.Cp.Dir.Substring(App.cfg.Cp.Dir.LastIndexOf("\\") + 1);
                switch (d)
                {
                    case "模板表":
                        rb_tpl.Checked = true;
                        break;
                    case "视频":
                        rb_vod.Checked = true;
                        break;
                    case "录音":
                        rb_voc.Checked = true;
                        break;
                    case "照片":
                        rb_pic.Checked = true;
                        break;
                }
                App.cfg.Cp.Dir = "";
            }
        }

        void InitDir(string root, DirectoryInfo di)
        {
            tv_dir.Nodes.Clear();
            lb_tip.Text = "当前工作文件夹：" + App.cfg.Cp.Work;
            lb_tip.Tag = App.cfg.Cp.Work;
            var tn = new TreeNode() { Text = root, Tag = App.cfg.Cp.Work + "\\" + root };
            tv_dir.Tag = di.FullName;
            tv_dir.Nodes.Add(tn);
            loadDir(di, tn.Nodes);
            if (App.cfg.Cp.Nodes.ContainsKey(di.FullName.Replace(App.cfg.Cp.Work, "")) && App.cfg.Cp.Nodes[di.FullName.Replace(App.cfg.Cp.Work, "")]) tn.Expand();
            if (string.IsNullOrEmpty(App.cfg.Cp.Dir)) tv_dir.ExpandAll();
        }

        void loadDir(DirectoryInfo dir, TreeNodeCollection tns)
        {
            foreach (var d in dir.EnumerateDirectories())
            {
                Invoke(new Action(() =>
                {
                    App.getIcon("dir", d.FullName);
                    var tn = new TreeNode() { Text = d.Name, Tag = d.FullName };
                    tn.ImageKey = "dir";
                    tn.SelectedImageKey = "dir";
                    if (d.FullName.Replace(App.cfg.Cp.Work, "") == App.cfg.Cp.Path) tv_dir.SelectedNode = tn;
                    tns.Add(tn);
                    loadDir(d, tn.Nodes);
                    if (App.cfg.Cp.Nodes.ContainsKey(d.FullName.Replace(App.cfg.Cp.Work, "")) && App.cfg.Cp.Nodes[d.FullName.Replace(App.cfg.Cp.Work, "")]) tn.Expand();
                    else tn.Collapse();
                }));
            }
            if (dir.FullName.Contains("\\模板表\\"))
            {
                foreach (var f in dir.GetFiles())
                {
                    Invoke(new Action(() =>
                    {
                        var px = f.Name.Substring(f.Name.LastIndexOf("."));
                        App.getIcon(px, f.FullName);
                        var tn = new TreeNode() { Text = f.Name, Tag = f.FullName };
                        tn.ImageKey = px;
                        tn.SelectedImageKey = px;
                        tns.Add(tn);
                    }));
                }
            }
        }

        private void tsmi_setting_Click(object sender, EventArgs e)
        {
            SaveConfig();
            if (new Setting().ShowDialog() != DialogResult.OK) return;
            cb_places.Items.Clear();
            foreach (var p in App.cfg.Places) cb_places.Items.Add(p);
            cb_places.SelectedIndex = 0;
        }

        private void tv_dir_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var file = e.Node.Tag.ToString();
            if (file.EndsWith(".doc") || file.EndsWith(".docx")) { Process.Start(file); return; }
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tv_dir_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tv_dir.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Left)
            {
                var p = e.Node.Tag.ToString().ToLower();
                if (System.IO.File.Exists(p)) preView(p);
                else fv_left.LoadFile(new DirectoryInfo(p));
            }
        }

        void preView(string file)
        {
            if (string.IsNullOrEmpty(file)) return;
            var ext = file.Substring(file.LastIndexOf('.') + 1).ToLower();

            var v = App.cfg.Views.GetViewer(ext);
            switch (v)
            {
                case "文档":
                    Process.Start(file);
                    break;
                case "表格":
                    mda_View.Visible = pic_View.Visible = false;
                    xls_View.Visible = true;
                    xls_View.LoadTable(file);
                    break;
                case "图片":
                    mda_View.Visible = xls_View.Visible = false;
                    pic_View.Visible = true;
                    pic_View.PlayFiles(new string[] { file });
                    break;
                case "视频":
                case "录音":
                    xls_View.Visible = pic_View.Visible = false;
                    mda_View.Visible = true;
                    mda_View.PlayFiles(new string[] { file });
                    break;
                default:
                    Process.Start(file); return;
            }
            sp_pan2.Panel2Collapsed = false;
        }

        void preView(string[] files)
        {
            if (files == null || files.Length == 0) return;
            var fs = new List<string>();
            var tp = "";
            foreach (var f in files)
            {
                var ext = f.Substring(f.LastIndexOf('.') + 1).ToLower();
                var v = App.cfg.Views.GetViewer(ext);
                if (tp == "") tp = v;
                else if (tp != v) continue;
                switch (v)
                {
                    case "图片":
                    case "视频":
                    case "录音":
                        fs.Add(f);
                        break;
                }
            }
            if (fs.Count > 0)
            {
                sp_pan2.Panel2Collapsed = xls_View.Visible = mda_View.Visible = pic_View.Visible = false;
                if (tp == "图片") { pic_View.Visible = true; pic_View.PlayFiles(fs.ToArray()); }
                else if (tp == "视频" || tp == "录音") { mda_View.Visible = true; mda_View.PlayFiles(fs.ToArray()); }
            }
        }

        private void rb_dir_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (!rb.Checked) return;
            var di = new DirectoryInfo(App.cfg.Cp.Work + "\\" + rb.Text);
            InitDir(rb.Text, di);
            if (string.IsNullOrEmpty(App.cfg.Cp.Path)) fv_left.LoadFile(di);
            else { fv_left.LoadFile(new DirectoryInfo(App.cfg.Cp.Work + "\\" + App.cfg.Cp.Path)); App.cfg.Cp.Path = ""; }
        }

        private void tsmi_open_in_exp_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            Process.Start("explorer.exe", "/select," + tn.Tag.ToString());
        }

        private void cms_tree_Opening(object sender, CancelEventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            var p = tn.Tag.ToString();
            tsmi_use_wordopen.Visible = tsmi_use_excelopen.Visible = tsp_p3.Visible = false;
            if (System.IO.File.Exists(p))
            {
                if (p.EndsWith(".xls") || p.EndsWith(".xlsx")) { tsmi_use_excelopen.Visible = tsp_p3.Visible = true; }
                else if (p.EndsWith(".doc") || p.EndsWith(".docx")) { tsmi_use_wordopen.Visible = tsp_p3.Visible = true; }
                tsp_p1.Visible = tsmi_open_vod.Visible = tsmi_open_voc.Visible = true;
            }
            else
            {
                tsp_p1.Visible = tsmi_open_vod.Visible = tsmi_open_voc.Visible = false;
            }
        }

        private void tsmi_open_vod_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            var p = tn.FullPath;
            p = p.Replace("模板表\\", "");
            p = p.Substring(0, p.LastIndexOf("."));
            fv_left.LoadFile(new DirectoryInfo(App.cfg.Cp.Work + "\\视频\\" + p));
        }

        private void tsmi_open_voc_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            var p = tn.FullPath;
            p = p.Replace("模板表\\", "");
            p = p.Substring(0, p.LastIndexOf("."));
            fv_left.LoadFile(new DirectoryInfo(App.cfg.Cp.Work + "\\录音\\" + p));
        }

        private void tsmi_open_doc_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            var p = tn.FullPath;
            p = App.cfg.Cp.Work + "\\" + p.Replace("视频\\", "模板表\\").Replace("录音\\", "模板表\\");
            if (System.IO.File.Exists(p + ".doc")) Process.Start(p + ".doc");
            else if (System.IO.File.Exists(p + ".docx")) Process.Start(p + ".docx");
            else MessageBox.Show("文件不存在", Text);
        }

        private void tsmi_open_excel_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            var p = tn.FullPath;
            p = App.cfg.Cp.Work + "\\" + p.Replace("视频\\", "模板表\\").Replace("录音\\", "模板表\\");
            if (System.IO.File.Exists(p + ".xls") || (System.IO.File.Exists(p + ".xlsx"))) xls_View.LoadTable(p + ".xls");
            else MessageBox.Show("文件不存在", Text);
        }

        private void xls_View_Close()
        {
            xls_View.Visible = false;
            sp_pan2.Panel2Collapsed = true;
        }

        private void mda_View_Close()
        {
            mda_View.Visible = false;
            sp_pan2.Panel2Collapsed = true;
        }

        private void tsmi_use_wordopen_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            var p = tn.FullPath;
            p = App.cfg.Cp.Work + "\\" + p.Replace("视频\\", "模板表\\").Replace("录音\\", "模板表\\");
            if (System.IO.File.Exists(p)) Process.Start(p);
            else MessageBox.Show("文件不存在", Text);
        }

        private void tsmi_use_excelopen_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn == null) return;
            var p = tn.FullPath;
            p = App.cfg.Cp.Work + "\\" + p.Replace("视频\\", "模板表\\").Replace("录音\\", "模板表\\");
            if (System.IO.File.Exists(p)) Process.Start(p);
            else MessageBox.Show("文件不存在", Text);
        }

        private void tsmi_reload_Click(object sender, EventArgs e)
        {
            var dir = "";
            if (rb_pic.Checked) dir = "照片";
            else if (rb_tpl.Checked) dir = "模板表";
            else if (rb_voc.Checked) dir = "录音";
            else if (rb_vod.Checked) dir = "视频";
            InitDir(dir, new DirectoryInfo(App.cfg.Cp.Work + "\\" + dir));
        }

        private void tsmi_expall_Click(object sender, EventArgs e)
        {
            tv_dir.ExpandAll();
        }

        private void tsmi_colall_Click(object sender, EventArgs e)
        {
            tv_dir.CollapseAll();
        }

        private void fv_left_PlayFiles(string[] files)
        {
            if (files.Length == 1) preView(files[0]);
            else preView(files);
        }

        private void pic_View_Close()
        {
            pic_View.Visible = false;
            sp_pan2.Panel2Collapsed = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }

        void SaveConfig()
        {
            if (lb_tip.Tag != null && App.cfg.Places.FirstOrDefault(o => o.Work == lb_tip.Tag.ToString()) == null) return;
            if (tv_dir.Nodes.Count == 0) return;
            App.cfg.Cp.Nodes = new Dictionary<string, bool>();
            getNds(tv_dir.Nodes, App.cfg.Cp.Nodes);
            var tn = tv_dir.SelectedNode;
            if (tn != null)
            {
                if (System.IO.File.Exists(tn.Tag.ToString())) App.cfg.Cp.Path = tn.Parent.Tag.ToString().Replace(App.cfg.Cp.Work, "");
                else App.cfg.Cp.Path = tn.Tag.ToString().Replace(App.cfg.Cp.Work, "");
            }
            App.cfg.Cp.Dir = tv_dir.Nodes[0].Tag.ToString().Replace(App.cfg.Cp.Work, "");
            App.SaveConfig();
        }

        void getNds(TreeNodeCollection tnc, Dictionary<string, bool> nds)
        {
            foreach (TreeNode t in tnc)
            {
                if (System.IO.File.Exists(t.Tag.ToString())) continue;
                nds.Add(t.Tag.ToString().Replace(App.cfg.Cp.Work, ""), t.IsExpanded);
                getNds(t.Nodes, nds);
            }
        }

        private void tsmi_about_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void mda_View_Playing(string file)
        {
            fv_left.SelectFile(file);
        }

        private void bt_pl_new_Click(object sender, EventArgs e)
        {
            var pl = new Place();
            if (pl.ShowDialog() != DialogResult.OK) return;

            var p = new App.Config.Place() { Name = pl.PName, Work = pl.PDir };
            App.cfg.AddPlace(p);

            cb_places.Items.Add(p);
            cb_places.SelectedItem = p;
        }

        private void cb_places_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_places.SelectedIndex < 0) return;
            var p = cb_places.SelectedItem as App.Config.Place;
            if (p == null) return;

            SaveConfig();
            App.cfg.CpId = p.ID;

            rb_tpl.Checked = false;
            Init();
        }

        private void cb_places_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lb = sender as ComboBox;
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index < 0) return;
            e.Graphics.DrawString(lb.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + 5, e.Bounds.Top + 5);
        }

        private void pic_View_Next()
        {
            fv_left.MoveItem(1);
        }

        private void pic_View_Prev()
        {
            fv_left.MoveItem(-1);
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}