namespace X.File
{
    partial class Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sp_pan1 = new System.Windows.Forms.SplitContainer();
            this.rb_tpl = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_places = new System.Windows.Forms.ComboBox();
            this.bt_pl_new = new System.Windows.Forms.Button();
            this.rb_pic = new System.Windows.Forms.RadioButton();
            this.rb_vod = new System.Windows.Forms.RadioButton();
            this.tv_dir = new System.Windows.Forms.TreeView();
            this.cms_tree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_open_in_exp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_p1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_use_excelopen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_use_wordopen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_p3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_open_vod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_open_voc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_p2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_reload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_expall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_colall = new System.Windows.Forms.ToolStripMenuItem();
            this.rb_voc = new System.Windows.Forms.RadioButton();
            this.sp_pan2 = new System.Windows.Forms.SplitContainer();
            this.fv_left = new X.File.Ctrl.FileView();
            this.mda_View = new X.File.Ctrl.MidView();
            this.xls_View = new X.File.Ctrl.XlsView();
            this.pic_View = new X.File.Ctrl.PicView();
            this.ss_status = new System.Windows.Forms.StatusStrip();
            this.lb_tip = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_pname = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.sp_pan1)).BeginInit();
            this.sp_pan1.Panel1.SuspendLayout();
            this.sp_pan1.Panel2.SuspendLayout();
            this.sp_pan1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cms_tree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_pan2)).BeginInit();
            this.sp_pan2.Panel1.SuspendLayout();
            this.sp_pan2.Panel2.SuspendLayout();
            this.sp_pan2.SuspendLayout();
            this.ss_status.SuspendLayout();
            this.ms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_pan1
            // 
            this.sp_pan1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sp_pan1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sp_pan1.Location = new System.Drawing.Point(0, 28);
            this.sp_pan1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.sp_pan1.Name = "sp_pan1";
            // 
            // sp_pan1.Panel1
            // 
            this.sp_pan1.Panel1.Controls.Add(this.rb_tpl);
            this.sp_pan1.Panel1.Controls.Add(this.groupBox1);
            this.sp_pan1.Panel1.Controls.Add(this.rb_pic);
            this.sp_pan1.Panel1.Controls.Add(this.rb_vod);
            this.sp_pan1.Panel1.Controls.Add(this.tv_dir);
            this.sp_pan1.Panel1.Controls.Add(this.rb_voc);
            this.sp_pan1.Panel1.Padding = new System.Windows.Forms.Padding(3, 0, 1, 3);
            this.sp_pan1.Panel1MinSize = 200;
            // 
            // sp_pan1.Panel2
            // 
            this.sp_pan1.Panel2.Controls.Add(this.sp_pan2);
            this.sp_pan1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.sp_pan1.Size = new System.Drawing.Size(1266, 556);
            this.sp_pan1.SplitterDistance = 200;
            this.sp_pan1.SplitterWidth = 2;
            this.sp_pan1.TabIndex = 4;
            // 
            // rb_tpl
            // 
            this.rb_tpl.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_tpl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rb_tpl.Image = global::X.File.Properties.Resources.order;
            this.rb_tpl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_tpl.Location = new System.Drawing.Point(3, 56);
            this.rb_tpl.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.rb_tpl.Name = "rb_tpl";
            this.rb_tpl.Size = new System.Drawing.Size(97, 28);
            this.rb_tpl.TabIndex = 1;
            this.rb_tpl.Text = "模板表";
            this.rb_tpl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_tpl.UseVisualStyleBackColor = true;
            this.rb_tpl.CheckedChanged += new System.EventHandler(this.rb_dir_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_places);
            this.groupBox1.Controls.Add(this.bt_pl_new);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采录点";
            // 
            // cb_places
            // 
            this.cb_places.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_places.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_places.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_places.FormattingEnabled = true;
            this.cb_places.ItemHeight = 20;
            this.cb_places.Location = new System.Drawing.Point(5, 20);
            this.cb_places.Name = "cb_places";
            this.cb_places.Size = new System.Drawing.Size(159, 26);
            this.cb_places.TabIndex = 6;
            this.cb_places.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cb_places_DrawItem);
            this.cb_places.SelectedValueChanged += new System.EventHandler(this.cb_places_SelectedValueChanged);
            // 
            // bt_pl_new
            // 
            this.bt_pl_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_pl_new.Image = global::X.File.Properties.Resources.add;
            this.bt_pl_new.Location = new System.Drawing.Point(167, 20);
            this.bt_pl_new.Margin = new System.Windows.Forms.Padding(0);
            this.bt_pl_new.Name = "bt_pl_new";
            this.bt_pl_new.Size = new System.Drawing.Size(26, 26);
            this.bt_pl_new.TabIndex = 7;
            this.toolTip1.SetToolTip(this.bt_pl_new, "新增采录点");
            this.bt_pl_new.UseVisualStyleBackColor = true;
            this.bt_pl_new.Click += new System.EventHandler(this.bt_pl_new_Click);
            // 
            // rb_pic
            // 
            this.rb_pic.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_pic.Image = global::X.File.Properties.Resources.picture;
            this.rb_pic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_pic.Location = new System.Drawing.Point(103, 56);
            this.rb_pic.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.rb_pic.Name = "rb_pic";
            this.rb_pic.Size = new System.Drawing.Size(96, 28);
            this.rb_pic.TabIndex = 3;
            this.rb_pic.Text = "照片";
            this.rb_pic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_pic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_pic.UseVisualStyleBackColor = true;
            this.rb_pic.CheckedChanged += new System.EventHandler(this.rb_dir_CheckedChanged);
            // 
            // rb_vod
            // 
            this.rb_vod.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_vod.Image = global::X.File.Properties.Resources.video;
            this.rb_vod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_vod.Location = new System.Drawing.Point(3, 87);
            this.rb_vod.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.rb_vod.Name = "rb_vod";
            this.rb_vod.Size = new System.Drawing.Size(97, 28);
            this.rb_vod.TabIndex = 0;
            this.rb_vod.Text = "视频";
            this.rb_vod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_vod.UseVisualStyleBackColor = true;
            this.rb_vod.CheckedChanged += new System.EventHandler(this.rb_dir_CheckedChanged);
            // 
            // tv_dir
            // 
            this.tv_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_dir.ContextMenuStrip = this.cms_tree;
            this.tv_dir.HideSelection = false;
            this.tv_dir.Location = new System.Drawing.Point(3, 118);
            this.tv_dir.Margin = new System.Windows.Forms.Padding(0);
            this.tv_dir.Name = "tv_dir";
            this.tv_dir.ShowNodeToolTips = true;
            this.tv_dir.Size = new System.Drawing.Size(196, 434);
            this.tv_dir.TabIndex = 4;
            this.tv_dir.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_dir_NodeMouseClick);
            // 
            // cms_tree
            // 
            this.cms_tree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_open_in_exp,
            this.tsp_p1,
            this.tsmi_use_excelopen,
            this.tsmi_use_wordopen,
            this.tsp_p3,
            this.tsmi_open_vod,
            this.tsmi_open_voc,
            this.tsp_p2,
            this.tsmi_reload,
            this.toolStripMenuItem1,
            this.tsmi_expall,
            this.tsmi_colall});
            this.cms_tree.Name = "cms_tree";
            this.cms_tree.Size = new System.Drawing.Size(178, 204);
            this.cms_tree.Opening += new System.ComponentModel.CancelEventHandler(this.cms_tree_Opening);
            // 
            // tsmi_open_in_exp
            // 
            this.tsmi_open_in_exp.Name = "tsmi_open_in_exp";
            this.tsmi_open_in_exp.Size = new System.Drawing.Size(177, 22);
            this.tsmi_open_in_exp.Text = "打开所在文件夹(&D)";
            this.tsmi_open_in_exp.Click += new System.EventHandler(this.tsmi_open_in_exp_Click);
            // 
            // tsp_p1
            // 
            this.tsp_p1.Name = "tsp_p1";
            this.tsp_p1.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmi_use_excelopen
            // 
            this.tsmi_use_excelopen.Name = "tsmi_use_excelopen";
            this.tsmi_use_excelopen.Size = new System.Drawing.Size(177, 22);
            this.tsmi_use_excelopen.Text = "用Excel打开";
            this.tsmi_use_excelopen.Click += new System.EventHandler(this.tsmi_use_excelopen_Click);
            // 
            // tsmi_use_wordopen
            // 
            this.tsmi_use_wordopen.Name = "tsmi_use_wordopen";
            this.tsmi_use_wordopen.Size = new System.Drawing.Size(177, 22);
            this.tsmi_use_wordopen.Text = "用Word打开";
            this.tsmi_use_wordopen.Click += new System.EventHandler(this.tsmi_use_wordopen_Click);
            // 
            // tsp_p3
            // 
            this.tsp_p3.Name = "tsp_p3";
            this.tsp_p3.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmi_open_vod
            // 
            this.tsmi_open_vod.Name = "tsmi_open_vod";
            this.tsmi_open_vod.Size = new System.Drawing.Size(177, 22);
            this.tsmi_open_vod.Text = "打开视频文件夹";
            this.tsmi_open_vod.Click += new System.EventHandler(this.tsmi_open_vod_Click);
            // 
            // tsmi_open_voc
            // 
            this.tsmi_open_voc.Name = "tsmi_open_voc";
            this.tsmi_open_voc.Size = new System.Drawing.Size(177, 22);
            this.tsmi_open_voc.Text = "打开录音文件夹";
            this.tsmi_open_voc.Click += new System.EventHandler(this.tsmi_open_voc_Click);
            // 
            // tsp_p2
            // 
            this.tsp_p2.Name = "tsp_p2";
            this.tsp_p2.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmi_reload
            // 
            this.tsmi_reload.Name = "tsmi_reload";
            this.tsmi_reload.Size = new System.Drawing.Size(177, 22);
            this.tsmi_reload.Text = "重新加载(&R)";
            this.tsmi_reload.Click += new System.EventHandler(this.tsmi_reload_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmi_expall
            // 
            this.tsmi_expall.Name = "tsmi_expall";
            this.tsmi_expall.Size = new System.Drawing.Size(177, 22);
            this.tsmi_expall.Text = "展开所有树状菜单";
            this.tsmi_expall.Click += new System.EventHandler(this.tsmi_expall_Click);
            // 
            // tsmi_colall
            // 
            this.tsmi_colall.Name = "tsmi_colall";
            this.tsmi_colall.Size = new System.Drawing.Size(177, 22);
            this.tsmi_colall.Text = "收缩所有树状菜单";
            this.tsmi_colall.Click += new System.EventHandler(this.tsmi_colall_Click);
            // 
            // rb_voc
            // 
            this.rb_voc.Appearance = System.Windows.Forms.Appearance.Button;
            this.rb_voc.Image = global::X.File.Properties.Resources.playon;
            this.rb_voc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rb_voc.Location = new System.Drawing.Point(103, 87);
            this.rb_voc.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.rb_voc.Name = "rb_voc";
            this.rb_voc.Size = new System.Drawing.Size(96, 28);
            this.rb_voc.TabIndex = 2;
            this.rb_voc.Text = "录音";
            this.rb_voc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_voc.UseVisualStyleBackColor = true;
            this.rb_voc.CheckedChanged += new System.EventHandler(this.rb_dir_CheckedChanged);
            // 
            // sp_pan2
            // 
            this.sp_pan2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_pan2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sp_pan2.Location = new System.Drawing.Point(0, 0);
            this.sp_pan2.Margin = new System.Windows.Forms.Padding(0);
            this.sp_pan2.Name = "sp_pan2";
            // 
            // sp_pan2.Panel1
            // 
            this.sp_pan2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sp_pan2.Panel1.Controls.Add(this.fv_left);
            this.sp_pan2.Panel1.Padding = new System.Windows.Forms.Padding(1);
            this.sp_pan2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sp_pan2.Panel1MinSize = 300;
            // 
            // sp_pan2.Panel2
            // 
            this.sp_pan2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sp_pan2.Panel2.Controls.Add(this.mda_View);
            this.sp_pan2.Panel2.Controls.Add(this.xls_View);
            this.sp_pan2.Panel2.Controls.Add(this.pic_View);
            this.sp_pan2.Panel2.Padding = new System.Windows.Forms.Padding(1);
            this.sp_pan2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sp_pan2.Panel2Collapsed = true;
            this.sp_pan2.Size = new System.Drawing.Size(1061, 553);
            this.sp_pan2.SplitterDistance = 560;
            this.sp_pan2.SplitterWidth = 2;
            this.sp_pan2.TabIndex = 10;
            // 
            // fv_left
            // 
            this.fv_left.AllowDrop = true;
            this.fv_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fv_left.Location = new System.Drawing.Point(1, 1);
            this.fv_left.Name = "fv_left";
            this.fv_left.Size = new System.Drawing.Size(1059, 551);
            this.fv_left.TabIndex = 0;
            this.fv_left.PlayFiles += new X.File.Ctrl.FileView.PlayFilesHandler(this.fv_left_PlayFiles);
            // 
            // mda_View
            // 
            this.mda_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mda_View.Location = new System.Drawing.Point(1, 1);
            this.mda_View.Name = "mda_View";
            this.mda_View.Size = new System.Drawing.Size(94, 98);
            this.mda_View.TabIndex = 0;
            this.mda_View.Visible = false;
            this.mda_View.Close += new X.File.Ctrl.MidView.CloseHandler(this.mda_View_Close);
            this.mda_View.Playing += new X.File.Ctrl.MidView.PlayingHandler(this.mda_View_Playing);
            // 
            // xls_View
            // 
            this.xls_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xls_View.Location = new System.Drawing.Point(1, 1);
            this.xls_View.Name = "xls_View";
            this.xls_View.Size = new System.Drawing.Size(94, 98);
            this.xls_View.TabIndex = 2;
            this.xls_View.Visible = false;
            this.xls_View.Close += new X.File.Ctrl.XlsView.CloseHandler(this.xls_View_Close);
            // 
            // pic_View
            // 
            this.pic_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_View.Location = new System.Drawing.Point(1, 1);
            this.pic_View.Name = "pic_View";
            this.pic_View.Size = new System.Drawing.Size(94, 98);
            this.pic_View.TabIndex = 1;
            this.pic_View.Visible = false;
            this.pic_View.Close += new X.File.Ctrl.PicView.CloseHandler(this.pic_View_Close);
            // 
            // ss_status
            // 
            this.ss_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_tip,
            this.tssl_pname});
            this.ss_status.Location = new System.Drawing.Point(0, 584);
            this.ss_status.Name = "ss_status";
            this.ss_status.Size = new System.Drawing.Size(1266, 22);
            this.ss_status.TabIndex = 5;
            this.ss_status.Text = "statusStrip1";
            // 
            // lb_tip
            // 
            this.lb_tip.Name = "lb_tip";
            this.lb_tip.Size = new System.Drawing.Size(1219, 17);
            this.lb_tip.Spring = true;
            this.lb_tip.Text = "当前工作文件夹：";
            this.lb_tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssl_pname
            // 
            this.tssl_pname.Name = "tssl_pname";
            this.tssl_pname.Size = new System.Drawing.Size(32, 17);
            this.tssl_pname.Text = "地点";
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(60, 21);
            this.tsmi_about.Text = "关于(&A)";
            this.tsmi_about.Click += new System.EventHandler(this.tsmi_about_Click);
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_setting,
            this.tsmi_about,
            this.tsmi_quit});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ms_main.Size = new System.Drawing.Size(1266, 25);
            this.ms_main.TabIndex = 1;
            this.ms_main.Text = "menuStrip1";
            // 
            // tsmi_setting
            // 
            this.tsmi_setting.Name = "tsmi_setting";
            this.tsmi_setting.Size = new System.Drawing.Size(59, 21);
            this.tsmi_setting.Text = "设置(&S)";
            this.tsmi_setting.Click += new System.EventHandler(this.tsmi_setting_Click);
            // 
            // tsmi_quit
            // 
            this.tsmi_quit.Name = "tsmi_quit";
            this.tsmi_quit.Size = new System.Drawing.Size(62, 21);
            this.tsmi_quit.Text = "退出(&Q)";
            this.tsmi_quit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 526);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(555, 25);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(555, 27);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightToolStripPanel.Location = new System.Drawing.Point(150, 25);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 150);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 150);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentPanel.Size = new System.Drawing.Size(555, 499);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 606);
            this.Controls.Add(this.ss_status);
            this.Controls.Add(this.sp_pan1);
            this.Controls.Add(this.ms_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_main;
            this.MinimumSize = new System.Drawing.Size(800, 462);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "语保文件管家";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.sp_pan1.Panel1.ResumeLayout(false);
            this.sp_pan1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_pan1)).EndInit();
            this.sp_pan1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.cms_tree.ResumeLayout(false);
            this.sp_pan2.Panel1.ResumeLayout(false);
            this.sp_pan2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_pan2)).EndInit();
            this.sp_pan2.ResumeLayout(false);
            this.ss_status.ResumeLayout(false);
            this.ss_status.PerformLayout();
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer sp_pan1;
        private System.Windows.Forms.StatusStrip ss_status;
        private System.Windows.Forms.ToolStripStatusLabel lb_tip;
        private System.Windows.Forms.ContextMenuStrip cms_tree;
        private System.Windows.Forms.ToolStripMenuItem tsmi_open_in_exp;
        private System.Windows.Forms.ToolStripSeparator tsp_p1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_reload;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.TreeView tv_dir;
        private System.Windows.Forms.RadioButton rb_vod;
        private System.Windows.Forms.RadioButton rb_tpl;
        private System.Windows.Forms.RadioButton rb_voc;
        private System.Windows.Forms.RadioButton rb_pic;
        private System.Windows.Forms.SplitContainer sp_pan2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_open_voc;
        private System.Windows.Forms.ToolStripSeparator tsp_p2;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripMenuItem tsmi_open_vod;
        private System.Windows.Forms.ToolStripMenuItem tsmi_use_excelopen;
        private System.Windows.Forms.ToolStripMenuItem tsmi_use_wordopen;
        private System.Windows.Forms.ToolStripSeparator tsp_p3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_expall;
        private System.Windows.Forms.ToolStripMenuItem tsmi_colall;
        private Ctrl.FileView fv_left;
        private Ctrl.XlsView xls_View;
        private Ctrl.PicView pic_View;
        private Ctrl.MidView mda_View;
        private System.Windows.Forms.ToolStripMenuItem tsmi_setting;
        private System.Windows.Forms.ToolStripMenuItem tsmi_quit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_places;
        private System.Windows.Forms.Button bt_pl_new;
        private System.Windows.Forms.ToolStripStatusLabel tssl_pname;
    }
}
