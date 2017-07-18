namespace x.file
{
    partial class Media
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_proc = new System.Windows.Forms.TrackBar();
            this.tb_vol = new System.Windows.Forms.TrackBar();
            this.pl_v = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tb_proc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vol)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_proc
            // 
            this.tb_proc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_proc.AutoSize = false;
            this.tb_proc.Location = new System.Drawing.Point(5, 317);
            this.tb_proc.Name = "tb_proc";
            this.tb_proc.Size = new System.Drawing.Size(332, 26);
            this.tb_proc.TabIndex = 0;
            this.tb_proc.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_proc.Scroll += new System.EventHandler(this.tb_proc_Scroll);
            // 
            // tb_vol
            // 
            this.tb_vol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_vol.AutoSize = false;
            this.tb_vol.Location = new System.Drawing.Point(343, 317);
            this.tb_vol.Maximum = 100;
            this.tb_vol.Name = "tb_vol";
            this.tb_vol.Size = new System.Drawing.Size(125, 26);
            this.tb_vol.TabIndex = 1;
            this.tb_vol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_vol.Scroll += new System.EventHandler(this.tb_vol_Scroll);
            // 
            // pl_v
            // 
            this.pl_v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_v.Location = new System.Drawing.Point(5, 5);
            this.pl_v.Margin = new System.Windows.Forms.Padding(0);
            this.pl_v.Name = "pl_v";
            this.pl_v.Size = new System.Drawing.Size(463, 306);
            this.pl_v.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 349);
            this.Controls.Add(this.pl_v);
            this.Controls.Add(this.tb_vol);
            this.Controls.Add(this.tb_proc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Media";
            this.Text = "播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Media_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tb_proc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tb_proc;
        private System.Windows.Forms.TrackBar tb_vol;
        private System.Windows.Forms.Panel pl_v;
        private System.Windows.Forms.Timer timer1;
    }
}