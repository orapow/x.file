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

        private void Setting_Load(object sender, EventArgs e)
        {
            tb_app_aud.Text = App.cfg.ExApps.Audac;
            tb_app_praat.Text = App.cfg.ExApps.Praat;
            tb_app_sol.Text = App.cfg.ExApps.Solveig;
            tb_app_yb.Text = App.cfg.ExApps.YuBao;

            if (App.cfg.Views.Docs != null)
                tb_docs.Text = string.Join(";", App.cfg.Views.Docs);
            if (App.cfg.Views.Pics != null)
                tb_pics.Text = string.Join(";", App.cfg.Views.Pics);
            if (App.cfg.Views.Vocs != null)
                tb_vocs.Text = string.Join(";", App.cfg.Views.Vocs);
            if (App.cfg.Views.Vods != null)
                tb_vods.Text = string.Join(";", App.cfg.Views.Vods);
            if (App.cfg.Views.Tabs != null)
                tb_xls.Text = string.Join(";", App.cfg.Views.Tabs);

            lb_places.Items.Clear();
            foreach (var p in App.cfg.Places) lb_places.Items.Add(p);
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (lb_places.Items.Count == 0) { MessageBox.Show("请至少添加一个采集点", Text); return; }

            DialogResult = DialogResult.OK;

            App.cfg.Views.Docs = tb_docs.Text.Split(';');
            App.cfg.Views.Pics = tb_pics.Text.Split(';');
            App.cfg.Views.Vocs = tb_vocs.Text.Split(';');
            App.cfg.Views.Vods = tb_vods.Text.Split(';');
            App.cfg.Views.Tabs = tb_xls.Text.Split(';');

            App.cfg.ExApps.Audac = tb_app_aud.Text;
            App.cfg.ExApps.Praat = tb_app_praat.Text;
            App.cfg.ExApps.Solveig = tb_app_sol.Text;
            App.cfg.ExApps.YuBao = tb_app_yb.Text;

            App.cfg.Places.Clear();
            foreach (App.Config.Place p in lb_places.Items)
                App.cfg.Places.Add(p);

            App.SaveConfig();
            Close();
        }

        private void dgv_exts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) dgv_exts.Rows.RemoveAt(e.RowIndex);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var pl = new Place();
            if (pl.ShowDialog() != DialogResult.OK) return;
            var p = new App.Config.Place() { Name = pl.PName, Work = pl.PDir };
            lb_places.Items.Add(p);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            var it = lb_places.SelectedItem as App.Config.Place;
            if (it == null) { MessageBox.Show("请选择一个地点", Text); return; }
            lb_places.Items.Remove(it);
        }

        private void lb_places_DoubleClick(object sender, EventArgs e)
        {
            var it = lb_places.SelectedItem as App.Config.Place;
            if (it == null) return;

            var pl = new Place() { PDir = it.Work, PName = it.Name };
            if (pl.ShowDialog() != DialogResult.OK) return;

            it.Name = pl.PName;
            it.Work = pl.PDir;
        }

        private void lb_places_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lb = sender as ListBox;
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index < 0) return;
            e.Graphics.DrawString(lb.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Left + 5, e.Bounds.Top + 5);
        }

        private void bt_app_aud_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "应用程序|*.exe";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            tb_app_aud.Text = ofd.FileName;// + " [file]";
        }

        private void bt_app_praat_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "应用程序|*.exe";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            tb_app_praat.Text = ofd.FileName;// + " [file]";
        }

        private void bt_app_yb_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "应用程序|*.exe";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            tb_app_yb.Text = ofd.FileName;// + " [file]";
        }

        private void bt_app_sol_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "应用程序|*.exe";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            tb_app_sol.Text = ofd.FileName;// + " [file]";
        }
    }
}
