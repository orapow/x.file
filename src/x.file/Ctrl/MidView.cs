using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace X.File.Ctrl
{
    public partial class MidView : UserControl
    {
        public delegate void CloseHandler();
        public event CloseHandler Close;

        public delegate void PlayingHandler(string file);
        public event PlayingHandler Playing;

        string pluginPath = Application.StartupPath + "\\plugins\\";
        VlcPlayer vlc_player_;
        string[] files = null;
        int idx = 0;
        string totaltime = "";
        double cp = 0;
        int cpct = 0;

        public MidView()
        {
            InitializeComponent();
        }

        public void PlayFiles(string[] fs)
        {
            if (vlc_player_ == null)
            {
                vlc_player_ = new VlcPlayer(pluginPath);
                vlc_player_.SetRenderWindow((int)panel1.Handle);
            }
            else vlc_player_.Stop();
            files = fs;
            idx = 0;
            play();
        }

        void play()
        {
            cp = 0;
            cpct = 0;
            var file = files[idx];
            vlc_player_.LoadFile(file);
            vlc_player_.Play();
            totaltime = getTime(vlc_player_.Duration * 1000);
            tb_proc.SetRange(0, (int)(vlc_player_.Duration * 1000));
            tsl_file.Text = "文件：" + file.ToLower().Replace(App.cfg.Cp.Work.ToLower(), "");
            lb_filename.Text = file.Substring(file.LastIndexOf('\\') + 1);
            tsb_play.Visible = false;
            tsl_ct.Text = (idx + 1) + "/" + files.Length;
            Thread.Sleep(50);
            tm_play.Enabled = tsb_stop.Enabled = tsb_pause.Visible = true;
            Playing?.Invoke(file);
        }

        public void Stop()
        {
            idx = 0;
            if (vlc_player_ == null) return;
            vlc_player_.Stop();
            files = new string[1];
        }

        string getTime(double sec)
        {
            var t = "" + (sec / 1000.0).ToString(".000");
            var mt = sec % 1000;
            sec = (sec - mt) / 1000;

            t = ((int)sec % 60).ToString("00") + ":" + mt; sec /= 60;
            t = ((int)sec % 60).ToString("00") + ":" + t; sec /= 60;
            t = ((int)sec % 60).ToString("00") + ":" + t; sec /= 60;

            //if (sec >= 60) { t = (sec % 60).ToString("00") + "." + mt; sec /= 60; }
            //else t = "00" + t;
            //if (sec >= 60) { t = (sec % 60).ToString("00") + ":" + t; sec /= 60; }
            //else t = ((int)sec).ToString("00") + ":" + t;
            //if (sec >= 60) { t = (sec % 60).ToString("00") + ":" + t; sec /= 60; }
            //else t = "00:" + (int)sec;
            return t;
        }

        private void tm_play_Tick(object sender, EventArgs e)
        {
            try
            {
                var p = vlc_player_.GetPlayTime();
                if (p != cp) cpct = 0;
                else cpct++;
                cp = p;
                if (cpct >= 50)
                {
                    if (idx >= files.Length - 1) tsb_stop_Click(null, null);
                    else { Thread.Sleep(500); tm_play.Enabled = false; idx++; play(); }
                }
                else
                {
                    tb_proc.Value = (int)(vlc_player_.GetPlayTime() * 1000);
                    tsl_time.Text = "时间：" + getTime(vlc_player_.GetPlayTime() * 1000) + "/" + totaltime;
                }
            }
            catch { }
        }

        private void tsb_stop_Click(object sender, EventArgs e)
        {
            tm_play.Enabled = tsb_pause.Visible = tsb_stop.Enabled = false;
            if (vlc_player_ != null) { vlc_player_.Stop(); vlc_player_ = null; }
            tsb_play.Visible = true;
            tb_proc.Value = tb_proc.Maximum;
            tsl_time.Text = "时间：" + totaltime + "/" + totaltime;
        }

        private void tsb_pause_Click(object sender, EventArgs e)
        {
            if (vlc_player_ == null) return;
            tm_play.Enabled = false;
            vlc_player_.Pause();
            tsb_pause.Visible = false;
            tsb_play.Visible = tsb_stop.Enabled = true;
        }

        private void tsb_play_Click(object sender, EventArgs e)
        {
            if (vlc_player_ == null) { idx = -1; PlayFiles(files); return; }
            tm_play.Enabled = true;
            vlc_player_.Pause();
            tsb_play.Visible = false;
            tsb_pause.Visible = tsb_stop.Enabled = true;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (vlc_player_ == null) return;
            vlc_player_.SetFullScreen(true);
        }

        private void tsb_close_Click(object sender, EventArgs e)
        {
            Stop();
            Close?.Invoke();
        }

        private void tb_proc_Scroll(object sender, EventArgs e)
        {

        }

        private void MidView_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible) Stop();
        }
    }
}
