namespace X.File
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.bt_sel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_xls = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_docs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_vocs = new System.Windows.Forms.TextBox();
            this.tb_vods = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pics = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_app_yb = new System.Windows.Forms.TextBox();
            this.bt_app_yb = new System.Windows.Forms.Button();
            this.tb_app_sol = new System.Windows.Forms.TextBox();
            this.bt_app_sol = new System.Windows.Forms.Button();
            this.tb_app_praat = new System.Windows.Forms.TextBox();
            this.bt_app_praat = new System.Windows.Forms.Button();
            this.tb_app_aud = new System.Windows.Forms.TextBox();
            this.bt_app_aud = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(6, 20);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.ReadOnly = true;
            this.tb_dir.Size = new System.Drawing.Size(307, 21);
            this.tb_dir.TabIndex = 1;
            // 
            // bt_sel
            // 
            this.bt_sel.Location = new System.Drawing.Point(319, 19);
            this.bt_sel.Name = "bt_sel";
            this.bt_sel.Size = new System.Drawing.Size(50, 23);
            this.bt_sel.TabIndex = 2;
            this.bt_sel.Text = "选择";
            this.bt_sel.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ok.Location = new System.Drawing.Point(285, 460);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(66, 29);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "确定";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_dir);
            this.groupBox1.Controls.Add(this.bt_sel);
            this.groupBox1.Location = new System.Drawing.Point(12, 612);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工作文件夹：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_xls);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_docs);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_vocs);
            this.groupBox2.Controls.Add(this.tb_vods);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_pics);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 206);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查看器：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "录音：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "视频：";
            // 
            // tb_xls
            // 
            this.tb_xls.Location = new System.Drawing.Point(83, 20);
            this.tb_xls.Multiline = true;
            this.tb_xls.Name = "tb_xls";
            this.tb_xls.Size = new System.Drawing.Size(244, 30);
            this.tb_xls.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "图片：";
            // 
            // tb_docs
            // 
            this.tb_docs.Location = new System.Drawing.Point(83, 56);
            this.tb_docs.Multiline = true;
            this.tb_docs.Name = "tb_docs";
            this.tb_docs.Size = new System.Drawing.Size(244, 30);
            this.tb_docs.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "文档：";
            // 
            // tb_vocs
            // 
            this.tb_vocs.Location = new System.Drawing.Point(83, 164);
            this.tb_vocs.Multiline = true;
            this.tb_vocs.Name = "tb_vocs";
            this.tb_vocs.Size = new System.Drawing.Size(244, 30);
            this.tb_vocs.TabIndex = 1;
            // 
            // tb_vods
            // 
            this.tb_vods.Location = new System.Drawing.Point(83, 128);
            this.tb_vods.Multiline = true;
            this.tb_vods.Name = "tb_vods";
            this.tb_vods.Size = new System.Drawing.Size(244, 30);
            this.tb_vods.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "表格：";
            // 
            // tb_pics
            // 
            this.tb_pics.Location = new System.Drawing.Point(83, 92);
            this.tb_pics.Multiline = true;
            this.tb_pics.Name = "tb_pics";
            this.tb_pics.Size = new System.Drawing.Size(244, 30);
            this.tb_pics.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tb_app_yb);
            this.groupBox3.Controls.Add(this.bt_app_yb);
            this.groupBox3.Controls.Add(this.tb_app_sol);
            this.groupBox3.Controls.Add(this.bt_app_sol);
            this.groupBox3.Controls.Add(this.tb_app_praat);
            this.groupBox3.Controls.Add(this.bt_app_praat);
            this.groupBox3.Controls.Add(this.tb_app_aud);
            this.groupBox3.Controls.Add(this.bt_app_aud);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 225);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "第三方软件配置：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "SolveigMM：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "语宝标注：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Praat：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Audacity：";
            // 
            // tb_app_yb
            // 
            this.tb_app_yb.Location = new System.Drawing.Point(83, 122);
            this.tb_app_yb.Multiline = true;
            this.tb_app_yb.Name = "tb_app_yb";
            this.tb_app_yb.Size = new System.Drawing.Size(206, 43);
            this.tb_app_yb.TabIndex = 1;
            // 
            // bt_app_yb
            // 
            this.bt_app_yb.Location = new System.Drawing.Point(295, 122);
            this.bt_app_yb.Name = "bt_app_yb";
            this.bt_app_yb.Size = new System.Drawing.Size(32, 23);
            this.bt_app_yb.TabIndex = 2;
            this.bt_app_yb.Text = "...";
            this.bt_app_yb.UseVisualStyleBackColor = true;
            this.bt_app_yb.Click += new System.EventHandler(this.bt_app_yb_Click);
            // 
            // tb_app_sol
            // 
            this.tb_app_sol.Location = new System.Drawing.Point(83, 171);
            this.tb_app_sol.Multiline = true;
            this.tb_app_sol.Name = "tb_app_sol";
            this.tb_app_sol.Size = new System.Drawing.Size(206, 43);
            this.tb_app_sol.TabIndex = 1;
            // 
            // bt_app_sol
            // 
            this.bt_app_sol.Location = new System.Drawing.Point(295, 171);
            this.bt_app_sol.Name = "bt_app_sol";
            this.bt_app_sol.Size = new System.Drawing.Size(32, 23);
            this.bt_app_sol.TabIndex = 2;
            this.bt_app_sol.Text = "...";
            this.bt_app_sol.UseVisualStyleBackColor = true;
            this.bt_app_sol.Click += new System.EventHandler(this.bt_app_sol_Click);
            // 
            // tb_app_praat
            // 
            this.tb_app_praat.Location = new System.Drawing.Point(83, 73);
            this.tb_app_praat.Multiline = true;
            this.tb_app_praat.Name = "tb_app_praat";
            this.tb_app_praat.Size = new System.Drawing.Size(206, 43);
            this.tb_app_praat.TabIndex = 1;
            // 
            // bt_app_praat
            // 
            this.bt_app_praat.Location = new System.Drawing.Point(295, 73);
            this.bt_app_praat.Name = "bt_app_praat";
            this.bt_app_praat.Size = new System.Drawing.Size(32, 23);
            this.bt_app_praat.TabIndex = 2;
            this.bt_app_praat.Text = "...";
            this.bt_app_praat.UseVisualStyleBackColor = true;
            this.bt_app_praat.Click += new System.EventHandler(this.bt_app_praat_Click);
            // 
            // tb_app_aud
            // 
            this.tb_app_aud.Location = new System.Drawing.Point(83, 24);
            this.tb_app_aud.Multiline = true;
            this.tb_app_aud.Name = "tb_app_aud";
            this.tb_app_aud.Size = new System.Drawing.Size(206, 43);
            this.tb_app_aud.TabIndex = 1;
            // 
            // bt_app_aud
            // 
            this.bt_app_aud.Location = new System.Drawing.Point(295, 24);
            this.bt_app_aud.Name = "bt_app_aud";
            this.bt_app_aud.Size = new System.Drawing.Size(32, 23);
            this.bt_app_aud.TabIndex = 2;
            this.bt_app_aud.Text = "...";
            this.bt_app_aud.UseVisualStyleBackColor = true;
            this.bt_app_aud.Click += new System.EventHandler(this.bt_app_aud_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Setting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.Button bt_sel;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_app_aud;
        private System.Windows.Forms.Button bt_app_aud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_app_praat;
        private System.Windows.Forms.Button bt_app_praat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_app_yb;
        private System.Windows.Forms.Button bt_app_yb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_app_sol;
        private System.Windows.Forms.Button bt_app_sol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_xls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_docs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_vocs;
        private System.Windows.Forms.TextBox tb_vods;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pics;
    }
}