using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text)) { MessageBox.Show("请输入名称", Text); return; }
            if (string.IsNullOrEmpty(tb_dir.Text)) { MessageBox.Show("请选择或输入路径", Text); return; }
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
