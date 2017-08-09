namespace X.File
{
    partial class Place
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt_select = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flp_places = new System.Windows.Forms.FlowLayoutPanel();
            this.cms_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dmi_del = new System.Windows.Forms.ToolStripMenuItem();
            this.dmi_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.cms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(347, 142);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(34, 23);
            this.bt_select.TabIndex = 2;
            this.bt_select.Text = "...";
            this.toolTip1.SetToolTip(this.bt_select, "选择");
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地点名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "工作目录：";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(347, 46);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(313, 21);
            this.tb_name.TabIndex = 0;
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(347, 85);
            this.tb_dir.Multiline = true;
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.Size = new System.Drawing.Size(313, 51);
            this.tb_dir.TabIndex = 1;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(594, 142);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(66, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "确定";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flp_places);
            this.groupBox2.Location = new System.Drawing.Point(346, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 299);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "地点列表";
            // 
            // flp_places
            // 
            this.flp_places.AutoScroll = true;
            this.flp_places.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_places.Location = new System.Drawing.Point(3, 17);
            this.flp_places.Name = "flp_places";
            this.flp_places.Size = new System.Drawing.Size(308, 279);
            this.flp_places.TabIndex = 5;
            // 
            // cms_menu
            // 
            this.cms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dmi_del,
            this.dmi_edit});
            this.cms_menu.Name = "cms_menu";
            this.cms_menu.Size = new System.Drawing.Size(118, 48);
            // 
            // dmi_del
            // 
            this.dmi_del.Name = "dmi_del";
            this.dmi_del.Size = new System.Drawing.Size(117, 22);
            this.dmi_del.Text = "删除(&D)";
            // 
            // dmi_edit
            // 
            this.dmi_edit.Name = "dmi_edit";
            this.dmi_edit.Size = new System.Drawing.Size(117, 22);
            this.dmi_edit.Text = "编辑(&E)";
            // 
            // Place
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_dir);
            this.Controls.Add(this.tb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Place";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地点编辑";
            this.groupBox2.ResumeLayout(false);
            this.cms_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flp_places;
        private System.Windows.Forms.ContextMenuStrip cms_menu;
        private System.Windows.Forms.ToolStripMenuItem dmi_del;
        private System.Windows.Forms.ToolStripMenuItem dmi_edit;
    }
}