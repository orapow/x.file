namespace X.File
{
    partial class Places
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Places));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt_select = new System.Windows.Forms.Button();
            this.lb_places = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_select
            // 
            this.bt_select.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_select.Location = new System.Drawing.Point(567, 86);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(66, 29);
            this.bt_select.TabIndex = 15;
            this.bt_select.Text = "选择";
            this.toolTip1.SetToolTip(this.bt_select, "选择“需交文件电子版文件夹”");
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // lb_places
            // 
            this.lb_places.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_places.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lb_places.FormattingEnabled = true;
            this.lb_places.HorizontalScrollbar = true;
            this.lb_places.IntegralHeight = false;
            this.lb_places.ItemHeight = 24;
            this.lb_places.Location = new System.Drawing.Point(12, 12);
            this.lb_places.Name = "lb_places";
            this.lb_places.Size = new System.Drawing.Size(347, 436);
            this.lb_places.TabIndex = 0;
            this.toolTip1.SetToolTip(this.lb_places, "双击采录点进入");
            this.lb_places.Click += new System.EventHandler(this.lb_places_Click);
            this.lb_places.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_places_DrawItem);
            this.lb_places.SelectedIndexChanged += new System.EventHandler(this.lb_places_SelectedIndexChanged);
            this.lb_places.DoubleClick += new System.EventHandler(this.lb_places_DoubleClick);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_remove.Location = new System.Drawing.Point(450, 12);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(63, 32);
            this.btn_remove.TabIndex = 7;
            this.btn_remove.Text = "删除";
            this.toolTip1.SetToolTip(this.btn_remove, "删除所选项");
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_new.Location = new System.Drawing.Point(381, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(63, 32);
            this.btn_new.TabIndex = 8;
            this.btn_new.Text = "新增";
            this.toolTip1.SetToolTip(this.btn_new, "选择”需交文件电子版“文件夹");
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_ok.Location = new System.Drawing.Point(567, 296);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(66, 29);
            this.bt_ok.TabIndex = 9;
            this.bt_ok.Text = "关闭";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "地点名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "工作目录：";
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(381, 118);
            this.tb_dir.Multiline = true;
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(252, 82);
            this.tb_dir.TabIndex = 14;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(381, 230);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(252, 21);
            this.tb_name.TabIndex = 13;
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_save.Location = new System.Drawing.Point(567, 261);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(66, 29);
            this.bt_save.TabIndex = 9;
            this.bt_save.Text = "保存";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(378, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 51);
            this.label3.TabIndex = 16;
            this.label3.Text = "说明：\r\n1、双击左侧采录点可切换\r\n2、红色文字代表目录失效，请修改";
            // 
            // bt_clear
            // 
            this.bt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_clear.Location = new System.Drawing.Point(519, 12);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(74, 32);
            this.bt_clear.TabIndex = 7;
            this.bt_clear.Text = "清除无效";
            this.toolTip1.SetToolTip(this.bt_clear, "清除所有无效项（红色）");
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // Places
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_places);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_dir);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Places";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   采录点管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListBox lb_places;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_clear;
    }
}