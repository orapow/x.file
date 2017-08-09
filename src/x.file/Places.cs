using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using X.File.Ctrl;

namespace X.File
{
    public partial class Places : Form
    {
        public string Cpid { get; set; }

        public Places()
        {
            InitializeComponent();
            Text += " - " + App.cfg.AppName;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Init();
        }

        void Init()
        {
            lb_places.Items.Clear();
            foreach (var p in App.cfg.Places) lb_places.Items.Add(p);
            lb_places.SelectedIndex = -1;
        }

        private void lb_places_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lb = sender as ListBox;
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index < 0) return;
            var color = e.ForeColor;
            var it = lb.Items[e.Index] as App.Config.Place;
            if (!System.IO.Directory.Exists(it.Work)) color = Color.FromArgb(120, Color.Red);
            e.Graphics.DrawString((e.Index + 1).ToString("000") + "" + (color == Color.FromArgb(120, Color.Red) ? "【目录失效】  " : "【目录正常】  ") + lb.Items[e.Index].ToString(), e.Font, new SolidBrush(color), e.Bounds.Left + 5, e.Bounds.Top + 5);
        }

        private void lb_places_DoubleClick(object sender, EventArgs e)
        {
            App.Config.Place p = null;
            if (lb_places.SelectedItems.Count > 0) p = lb_places.SelectedItem as App.Config.Place;
            if (p == null) return;
            if (!Directory.Exists(p.Work)) { MessageBox.Show("当前采录点工作目录不存在，请修改后再使用！", App.cfg.AppName); bt_select_Click(null, null); return; }
            Cpid = p.ID;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            lb_places.SelectedIndex = -1;
            var fod = new FolderBrowserDialog();
            fod.SelectedPath = tb_dir.Text;
            if (fod.ShowDialog() != DialogResult.OK) return;
            tb_dir.Text = fod.SelectedPath;
            if (lb_places.SelectedItems.Count == 0) tb_name.Text = (App.cfg.Places.Count + 1).ToString("000");
        }

        private void lb_places_Click(object sender, EventArgs e)
        {
            var p = lb_places.SelectedItem as App.Config.Place;
            if (p == null) return;
            tb_name.Text = p.Name;
            tb_dir.Text = p.Work;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            tb_dir.Text = "";
            tb_name.Text = (App.cfg.Places.Count + 1).ToString("000");
            lb_places.SelectedIndex = -1;
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (lb_places.SelectedItems.Count == 0) return;
            var p = lb_places.SelectedItems[0] as App.Config.Place;
            if (p == null) return;
            App.cfg.Places.Remove(p);
            App.SaveConfig();
            tb_dir.Text = "";
            tb_name.Text = "";
            Init();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_dir.Text)) { MessageBox.Show("工作目录不能为空，请选择！"); return; }
            if (!Directory.Exists(tb_dir.Text)) { MessageBox.Show("工作目录不存在，请重新选择！"); return; }
            if (!Directory.Exists(tb_dir.Text + "\\模板表") || !Directory.Exists(tb_dir.Text + "\\视频") || !Directory.Exists(tb_dir.Text + "\\录音") || !Directory.Exists(tb_dir.Text + "\\照片")) { MessageBox.Show("文件夹选择错误，请重新选择！", App.cfg.AppName); return; }

            App.Config.Place p = null;
            if (lb_places.SelectedItems.Count > 0) p = lb_places.SelectedItems[0] as App.Config.Place;
            if (p == null)
            {
                var _p = App.cfg.Places.FirstOrDefault(o => o.Work.ToLower() == tb_dir.Text.ToLower());
                if (_p != null) { MessageBox.Show("文件夹已存在，请另外选择！", App.cfg.AppName); return; }
                p = new App.Config.Place();
            }
            p.Name = tb_name.Text;
            p.Work = tb_dir.Text;
            if (string.IsNullOrEmpty(p.ID)) App.cfg.AddPlace(p);
            App.SaveConfig();
            Init();
            lb_places.SelectedIndex = App.cfg.Places.FindIndex(o => o.ID == p.ID);
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Cpid)) DialogResult = DialogResult.OK;
            Close();
        }

        private void lb_places_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_places.SelectedItems.Count > 0)
            {
                bt_ok.Text = "进入";
                var it = lb_places.SelectedItems[0] as App.Config.Place;
                Cpid = it.ID;
            }
            else bt_ok.Text = "关闭";

        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            foreach (App.Config.Place p in lb_places.Items)
                if (!Directory.Exists(p.Work)) App.cfg.Places.Remove(p);

            App.SaveConfig();

            Init();
        }
    }
}
