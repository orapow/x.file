namespace X.File.Ctrl
{
    partial class MidView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MidView));
            this.tsc_media = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsl_file = new System.Windows.Forms.ToolStripLabel();
            this.tsl_ct = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_stop = new System.Windows.Forms.PictureBox();
            this.tb_proc = new System.Windows.Forms.TrackBar();
            this.pb_pause = new System.Windows.Forms.PictureBox();
            this.pb_play = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_filename = new System.Windows.Forms.Label();
            this.ts_b1 = new System.Windows.Forms.ToolStrip();
            this.tsb_play = new System.Windows.Forms.ToolStripButton();
            this.tsb_pause = new System.Windows.Forms.ToolStripButton();
            this.tsb_stop = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.tsl_time = new System.Windows.Forms.ToolStripLabel();
            this.tsp_name = new System.Windows.Forms.ToolStripLabel();
            this.tm_play = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tsc_media.BottomToolStripPanel.SuspendLayout();
            this.tsc_media.ContentPanel.SuspendLayout();
            this.tsc_media.TopToolStripPanel.SuspendLayout();
            this.tsc_media.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_proc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).BeginInit();
            this.panel1.SuspendLayout();
            this.ts_b1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsc_media
            // 
            // 
            // tsc_media.BottomToolStripPanel
            // 
            this.tsc_media.BottomToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // tsc_media.ContentPanel
            // 
            this.tsc_media.ContentPanel.Controls.Add(this.panel2);
            this.tsc_media.ContentPanel.Controls.Add(this.panel1);
            this.tsc_media.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tsc_media.ContentPanel.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tsc_media.ContentPanel.Size = new System.Drawing.Size(419, 382);
            this.tsc_media.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc_media.LeftToolStripPanelVisible = false;
            this.tsc_media.Location = new System.Drawing.Point(0, 0);
            this.tsc_media.Name = "tsc_media";
            this.tsc_media.RightToolStripPanelVisible = false;
            this.tsc_media.Size = new System.Drawing.Size(419, 432);
            this.tsc_media.TabIndex = 17;
            // 
            // tsc_media.TopToolStripPanel
            // 
            this.tsc_media.TopToolStripPanel.Controls.Add(this.ts_b1);
            this.tsc_media.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_file,
            this.tsl_ct});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(419, 25);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 21;
            // 
            // tsl_file
            // 
            this.tsl_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsl_file.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tsl_file.Image = ((System.Drawing.Image)(resources.GetObject("tsl_file.Image")));
            this.tsl_file.Name = "tsl_file";
            this.tsl_file.Size = new System.Drawing.Size(44, 22);
            this.tsl_file.Text = "文件：";
            // 
            // tsl_ct
            // 
            this.tsl_ct.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_ct.Name = "tsl_ct";
            this.tsl_ct.Size = new System.Drawing.Size(27, 22);
            this.tsl_ct.Text = "1/1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pb_stop);
            this.panel2.Controls.Add(this.tb_proc);
            this.panel2.Controls.Add(this.pb_pause);
            this.panel2.Controls.Add(this.pb_play);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 35);
            this.panel2.TabIndex = 2;
            // 
            // pb_stop
            // 
            this.pb_stop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_stop.Enabled = false;
            this.pb_stop.Image = global::X.File.Properties.Resources.stop;
            this.pb_stop.Location = new System.Drawing.Point(41, 7);
            this.pb_stop.Name = "pb_stop";
            this.pb_stop.Size = new System.Drawing.Size(20, 20);
            this.pb_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_stop.TabIndex = 5;
            this.pb_stop.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_stop, "停止");
            this.pb_stop.Click += new System.EventHandler(this.tsb_stop_Click);
            // 
            // tb_proc
            // 
            this.tb_proc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_proc.AutoSize = false;
            this.tb_proc.LargeChange = 200;
            this.tb_proc.Location = new System.Drawing.Point(64, 1);
            this.tb_proc.Margin = new System.Windows.Forms.Padding(0);
            this.tb_proc.Name = "tb_proc";
            this.tb_proc.Size = new System.Drawing.Size(354, 33);
            this.tb_proc.SmallChange = 100;
            this.tb_proc.TabIndex = 4;
            this.tb_proc.TickFrequency = 150;
            this.tb_proc.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tb_proc.Scroll += new System.EventHandler(this.tb_proc_Scroll);
            // 
            // pb_pause
            // 
            this.pb_pause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_pause.Image = global::X.File.Properties.Resources.pa;
            this.pb_pause.Location = new System.Drawing.Point(0, 0);
            this.pb_pause.Name = "pb_pause";
            this.pb_pause.Size = new System.Drawing.Size(35, 35);
            this.pb_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pause.TabIndex = 5;
            this.pb_pause.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_pause, "暂停");
            this.pb_pause.Click += new System.EventHandler(this.tsb_pause_Click);
            // 
            // pb_play
            // 
            this.pb_play.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_play.Image = global::X.File.Properties.Resources.p;
            this.pb_play.Location = new System.Drawing.Point(0, 0);
            this.pb_play.Name = "pb_play";
            this.pb_play.Size = new System.Drawing.Size(35, 35);
            this.pb_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_play.TabIndex = 5;
            this.pb_play.TabStop = false;
            this.toolTip1.SetToolTip(this.pb_play, "播放");
            this.pb_play.Click += new System.EventHandler(this.tsb_play_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_filename);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 381);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // lb_filename
            // 
            this.lb_filename.BackColor = System.Drawing.Color.Transparent;
            this.lb_filename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_filename.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_filename.Location = new System.Drawing.Point(0, 0);
            this.lb_filename.Name = "lb_filename";
            this.lb_filename.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lb_filename.Size = new System.Drawing.Size(417, 379);
            this.lb_filename.TabIndex = 0;
            this.lb_filename.Text = "label1";
            this.lb_filename.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ts_b1
            // 
            this.ts_b1.BackColor = System.Drawing.Color.White;
            this.ts_b1.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_b1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_b1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_play,
            this.tsb_pause,
            this.tsb_stop,
            this.tsb_close,
            this.tsl_time,
            this.tsp_name});
            this.ts_b1.Location = new System.Drawing.Point(0, 0);
            this.ts_b1.Name = "ts_b1";
            this.ts_b1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_b1.Size = new System.Drawing.Size(419, 25);
            this.ts_b1.Stretch = true;
            this.ts_b1.TabIndex = 1;
            // 
            // tsb_play
            // 
            this.tsb_play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_play.Image = global::X.File.Properties.Resources.play;
            this.tsb_play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_play.Name = "tsb_play";
            this.tsb_play.Size = new System.Drawing.Size(23, 22);
            this.tsb_play.Text = "点击播放";
            this.tsb_play.Visible = false;
            this.tsb_play.Click += new System.EventHandler(this.tsb_play_Click);
            // 
            // tsb_pause
            // 
            this.tsb_pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_pause.Image = global::X.File.Properties.Resources.suspend;
            this.tsb_pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_pause.Name = "tsb_pause";
            this.tsb_pause.Size = new System.Drawing.Size(23, 22);
            this.tsb_pause.Text = "点击暂停";
            this.tsb_pause.ToolTipText = "暂停";
            this.tsb_pause.Visible = false;
            this.tsb_pause.Click += new System.EventHandler(this.tsb_pause_Click);
            // 
            // tsb_stop
            // 
            this.tsb_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_stop.Image = global::X.File.Properties.Resources.stop;
            this.tsb_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_stop.Name = "tsb_stop";
            this.tsb_stop.Size = new System.Drawing.Size(23, 22);
            this.tsb_stop.Text = "点击停止";
            this.tsb_stop.ToolTipText = "停止";
            this.tsb_stop.Visible = false;
            this.tsb_stop.Click += new System.EventHandler(this.tsb_stop_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_close.Image = global::X.File.Properties.Resources.close;
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(23, 22);
            this.tsb_close.Text = "toolStripButton2";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // tsl_time
            // 
            this.tsl_time.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_time.Name = "tsl_time";
            this.tsl_time.Size = new System.Drawing.Size(44, 22);
            this.tsl_time.Text = "时间：";
            // 
            // tsp_name
            // 
            this.tsp_name.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.tsp_name.Name = "tsp_name";
            this.tsp_name.Size = new System.Drawing.Size(32, 22);
            this.tsp_name.Text = "名称";
            // 
            // tm_play
            // 
            this.tm_play.Interval = 10;
            this.tm_play.Tick += new System.EventHandler(this.tm_play_Tick);
            // 
            // MidView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsc_media);
            this.Name = "MidView";
            this.Size = new System.Drawing.Size(419, 432);
            this.VisibleChanged += new System.EventHandler(this.MidView_VisibleChanged);
            this.tsc_media.BottomToolStripPanel.ResumeLayout(false);
            this.tsc_media.BottomToolStripPanel.PerformLayout();
            this.tsc_media.ContentPanel.ResumeLayout(false);
            this.tsc_media.TopToolStripPanel.ResumeLayout(false);
            this.tsc_media.TopToolStripPanel.PerformLayout();
            this.tsc_media.ResumeLayout(false);
            this.tsc_media.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_proc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_play)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ts_b1.ResumeLayout(false);
            this.ts_b1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsc_media;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip ts_b1;
        private System.Windows.Forms.ToolStripButton tsb_play;
        private System.Windows.Forms.ToolStripButton tsb_stop;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel tsl_file;
        private System.Windows.Forms.Label lb_filename;
        private System.Windows.Forms.Timer tm_play;
        private System.Windows.Forms.ToolStripButton tsb_pause;
        private System.Windows.Forms.ToolStripLabel tsl_time;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private System.Windows.Forms.ToolStripLabel tsl_ct;
        private System.Windows.Forms.ToolStripLabel tsp_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tb_proc;
        private System.Windows.Forms.PictureBox pb_play;
        private System.Windows.Forms.PictureBox pb_stop;
        private System.Windows.Forms.PictureBox pb_pause;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
