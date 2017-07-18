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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void bt_sel_Click(object sender, EventArgs e)
        {
            var ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK) tb_dir.Text = ofd.SelectedPath;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            tb_dir.Text = App.cfg.work;
            foreach (var ex in App.cfg.exts.OrderBy(o => o.Value))
            {
                if (string.IsNullOrEmpty(ex.Key)) continue;
                dgv_exts.Rows.Add(ex.Key, ex.Value, "删除");
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            App.cfg.work = tb_dir.Text;
            App.cfg.exts.Clear();
            foreach (DataGridViewRow dr in dgv_exts.Rows) { if (dr.IsNewRow) continue; App.cfg.exts.Add(dr.Cells[0].Value + "", dr.Cells[1].Value + ""); }

            App.SaveConfig();
            Close();
        }

        private void dgv_exts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) dgv_exts.Rows.RemoveAt(e.RowIndex);
        }
    }
}
