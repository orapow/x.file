using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X.File.Ctrl
{
    public partial class XlsView : UserControl
    {
        public delegate void CloseHandler();
        public event CloseHandler Close;

        DB db = null;
        public XlsView()
        {
            InitializeComponent();
        }

        public void LoadTable(string file)
        {
            if (db != null) db.Dispose();
            db = new DB(file);
            tsl_file.Text = "文件：" + file.ToLower().Replace(App.cfg.work.ToLower(), "");// + (e.Node.Tag + "").Replace(App.cfg.dir, "");
            var ts = db.LoadTables();
            if (ts == null) return;
            tsd_sheets.DropDownItems.Clear();
            foreach (var n in ts)
            {
                var tsi = new ToolStripMenuItem();
                tsi.Text = n;
                tsi.Click += Tsi_Click;
                tsd_sheets.DropDownItems.Add(tsi);
            };
            Tsi_Click(null, null);
        }

        void loadData(string name)
        {
            if (string.IsNullOrEmpty(name) || db == null) return;
            tsd_sheets.Text = name;
            dgv_list.AutoGenerateColumns = true;
            dgv_list.DataSource = db.LoadData(name);
            foreach (DataGridViewColumn c in dgv_list.Columns) c.SortMode = DataGridViewColumnSortMode.NotSortable;
            tsl_data_tip.Text = "共有" + dgv_list.Rows.Count + "条数据";
        }

        void dgv_list_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var dt = dgv_list.DataSource as DataTable;
            var row = dgv_list.Rows[e.RowIndex];
            if (row == null) return;
            db.SetCellValue(e.RowIndex + 1, e.ColumnIndex, row.Cells[e.ColumnIndex].Value + "");
        }

        void dgv_list_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
        void Tsi_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem m in tsd_sheets.DropDownItems) m.Checked = false;
            var mi = sender as ToolStripMenuItem;
            if (mi == null) mi = tsd_sheets.DropDownItems[0] as ToolStripMenuItem;
            mi.Checked = true;
            loadData(mi.Text);
        }
        void tssb_ref_Click(object sender, EventArgs e)
        {
            loadData(tsd_sheets.Text);
        }

        void gcms_ref_Click(object sender, EventArgs e)
        {
            loadData(tsd_sheets.Text);
        }

        void gcms_del_Click(object sender, EventArgs e)
        {
            if (dgv_list.SelectedCells.Count == 0) return;
            var c = dgv_list.SelectedCells[0];
            db.RemoveRow(c.RowIndex);
            loadData(tsd_sheets.Text);
        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            Close?.Invoke();
        }
    }
}
