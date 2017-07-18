using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace x.file
{
    public partial class Media : Form
    {
        private VlcPlayer vlc_player_;
        private bool isplaying = false;

        public Media()
        {
            InitializeComponent();
            string pluginPath = Application.StartupPath + "\\plugins\\";
            vlc_player_ = new VlcPlayer(pluginPath);
        }

        public void Play(string file)
        {
            vlc_player_.SetRenderWindow((int)pl_v.Handle);
            vlc_player_.PlayFile(file);
            tb_vol.Value = vlc_player_.GetVolume();
            tb_proc.SetRange(0, (int)vlc_player_.Duration() * 1000);
            timer1.Enabled = true;
            isplaying = true;
            tb_proc.Value = 0;
        }
        public void Stop()
        {
            vlc_player_.Stop();
        }
        private void Media_FormClosing(object sender, FormClosingEventArgs e)
        {
            vlc_player_.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isplaying) return;
            if (tb_proc.Value == tb_proc.Maximum)
            {
                isplaying = false;
                vlc_player_.Stop();
                timer1.Stop();
            }
            else
            {
                tb_proc.Value = (int)vlc_player_.GetPlayTime() * 1000;
            }
        }

        private void tb_proc_Scroll(object sender, EventArgs e)
        {
            if (!isplaying) return;
            vlc_player_.SetPlayTime(tb_proc.Value / 1000.0);
        }

        private void tb_vol_Scroll(object sender, EventArgs e)
        {
            vlc_player_.SetVolume(tb_vol.Value);
        }
    }
}
