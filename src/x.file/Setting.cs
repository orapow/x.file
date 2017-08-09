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
            Text += " - " + App.cfg.AppName;
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
            
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
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

            App.SaveConfig();
            Close();
        }


        private void lb_places_DrawItem(object sender, DrawItemEventArgs e)
        {
            var lb = sender as ListBox;
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index < 0) return;
            var color = e.ForeColor;
            var it = lb.Items[e.Index] as App.Config.Place;
            if (!System.IO.Directory.Exists(it.Work)) color = Color.Red;
            e.Graphics.DrawString(lb.Items[e.Index].ToString(), e.Font, new SolidBrush(color), e.Bounds.Left + 5, e.Bounds.Top + 5);
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
