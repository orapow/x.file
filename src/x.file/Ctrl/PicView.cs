﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace X.File.Ctrl
{
    public partial class PicView : UserControl
    {
        public delegate void CloseHandler();
        public event CloseHandler Close;

        string[] files = null;
        int idx = 0;

        public PicView()
        {
            InitializeComponent();
        }

        public void PlayFiles(string[] fs)
        {
            files = fs;
            idx = 0;
            showImage();
        }

        void showImage()
        {
            if (idx < 0 || idx > files.Length - 1) return;
            var img = Image.FromFile(files[idx]);
            tsl_file.Text = files[idx].ToLower().Replace(App.cfg.work.ToLower(), "");
            pb_show.Tag = files[idx];
            pb_show.Image = img; //img.Clone() as Image;
            img.Dispose();
            tsl_ct.Text = (idx + 1) + "/" + files.Length;
        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            Close?.Invoke();
        }

        private void pb_show_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(pb_show.Tag.ToString());
        }

        private void tsb_prev_Click(object sender, EventArgs e)
        {
            idx--;
            if (idx < 0) idx = 0;
            showImage();
        }

        private void tsb_next_Click(object sender, EventArgs e)
        {
            idx++;
            if (idx > files.Length - 1) idx = files.Length - 1;
            showImage();
        }

        private void PicView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) tsb_prev_Click(null, null);
            else if (e.KeyData == Keys.Right) tsb_next_Click(null, null);
        }
    }
}