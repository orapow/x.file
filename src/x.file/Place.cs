using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X.File
{
    public partial class Place : Form
    {
        public string PName { get; set; }
        public string PDir { get; set; }
        public Place()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!string.IsNullOrEmpty(PName)) tb_name.Text = PName;
            if (!string.IsNullOrEmpty(PDir)) tb_dir.Text = PDir;
            if (string.IsNullOrEmpty(PName)) tb_name.Text = (App.cfg.Places.Count() + 1).ToString("000");
            else tb_name.Text = PName;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text)) { MessageBox.Show("请输入名称", Text); return; }
            if (string.IsNullOrEmpty(tb_dir.Text)) { MessageBox.Show("请选择或输入路径", Text); return; }
            if (!Directory.Exists(tb_dir.Text + "\\模板表") || !Directory.Exists(tb_dir.Text + "\\视频") || !Directory.Exists(tb_dir.Text + "\\照片") || !Directory.Exists(tb_dir.Text + "\\录音")) { MessageBox.Show(tb_dir.Text + "当前选择目录结构不正确，请重新选择"); return; }

            DialogResult = DialogResult.OK;
            PName = tb_name.Text;
            PDir = tb_dir.Text;
            Close();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            var fod = new FolderBrowserDialog();
            fod.SelectedPath = PDir;
            if (fod.ShowDialog() != DialogResult.OK) return;
            tb_dir.Text = fod.SelectedPath;
        }
    }
}
