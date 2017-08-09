namespace X.File
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lb_appname = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lk_link = new System.Windows.Forms.LinkLabel();
            this.lb_appver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_appname
            // 
            this.lb_appname.AutoSize = true;
            this.lb_appname.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_appname.Location = new System.Drawing.Point(73, 12);
            this.lb_appname.Name = "lb_appname";
            this.lb_appname.Size = new System.Drawing.Size(126, 25);
            this.lb_appname.TabIndex = 0;
            this.lb_appname.Text = "语保文件管家";
            // 
            // pb_icon
            // 
            this.pb_icon.Image = ((System.Drawing.Image)(resources.GetObject("pb_icon.Image")));
            this.pb_icon.Location = new System.Drawing.Point(12, 12);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(55, 55);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icon.TabIndex = 1;
            this.pb_icon.TabStop = false;
            // 
            // lk_link
            // 
            this.lk_link.AutoSize = true;
            this.lk_link.Location = new System.Drawing.Point(240, 55);
            this.lk_link.Name = "lk_link";
            this.lk_link.Size = new System.Drawing.Size(41, 12);
            this.lk_link.TabIndex = 2;
            this.lk_link.TabStop = true;
            this.lk_link.Text = "语保网";
            this.lk_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_link_LinkClicked);
            // 
            // lb_appver
            // 
            this.lb_appver.AutoSize = true;
            this.lb_appver.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_appver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_appver.Location = new System.Drawing.Point(76, 46);
            this.lb_appver.Name = "lb_appver";
            this.lb_appver.Size = new System.Drawing.Size(40, 16);
            this.lb_appver.TabIndex = 3;
            this.lb_appver.Text = "V1.5";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 78);
            this.Controls.Add(this.lb_appver);
            this.Controls.Add(this.lk_link);
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.lb_appname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于软件";
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_appname;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.LinkLabel lk_link;
        private System.Windows.Forms.Label lb_appver;
    }
}