namespace X.File.Ctrl
{
    partial class XlsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsc_xls = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsl_data_tip = new System.Windows.Forms.ToolStripLabel();
            this.tsl_file = new System.Windows.Forms.ToolStripLabel();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.ts_t2 = new System.Windows.Forms.ToolStrip();
            this.cms_grid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_play = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_playlist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gcms_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.gcms_del = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.gcms_ref = new System.Windows.Forms.ToolStripMenuItem();
            this.tsd_sheets = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsb_ref = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.tsc_xls.BottomToolStripPanel.SuspendLayout();
            this.tsc_xls.ContentPanel.SuspendLayout();
            this.tsc_xls.TopToolStripPanel.SuspendLayout();
            this.tsc_xls.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.ts_t2.SuspendLayout();
            this.cms_grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsc_xls
            // 
            // 
            // tsc_xls.BottomToolStripPanel
            // 
            this.tsc_xls.BottomToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tsc_xls.ContentPanel
            // 
            this.tsc_xls.ContentPanel.Controls.Add(this.dgv_list);
            this.tsc_xls.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tsc_xls.ContentPanel.Size = new System.Drawing.Size(438, 378);
            this.tsc_xls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc_xls.LeftToolStripPanelVisible = false;
            this.tsc_xls.Location = new System.Drawing.Point(0, 0);
            this.tsc_xls.Name = "tsc_xls";
            this.tsc_xls.RightToolStripPanelVisible = false;
            this.tsc_xls.Size = new System.Drawing.Size(438, 430);
            this.tsc_xls.TabIndex = 16;
            this.tsc_xls.Text = "toolStripContainer1";
            // 
            // tsc_xls.TopToolStripPanel
            // 
            this.tsc_xls.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tsc_xls.TopToolStripPanel.Controls.Add(this.ts_t2);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_data_tip,
            this.tsl_file});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(438, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 19;
            // 
            // tsl_data_tip
            // 
            this.tsl_data_tip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsl_data_tip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsl_data_tip.Name = "tsl_data_tip";
            this.tsl_data_tip.Size = new System.Drawing.Size(44, 22);
            this.tsl_data_tip.Text = "文件：";
            this.tsl_data_tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsl_data_tip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tsl_file
            // 
            this.tsl_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsl_file.Name = "tsl_file";
            this.tsl_file.Size = new System.Drawing.Size(44, 22);
            this.tsl_file.Text = "文件：";
            this.tsl_file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsl_file.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // dgv_list
            // 
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_list.BackgroundColor = System.Drawing.Color.White;
            this.dgv_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgv_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_list.ColumnHeadersHeight = 26;
            this.dgv_list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_list.Location = new System.Drawing.Point(-1, -1);
            this.dgv_list.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_list.MultiSelect = false;
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_list.RowHeadersWidth = 26;
            this.dgv_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_list.RowTemplate.Height = 32;
            this.dgv_list.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_list.Size = new System.Drawing.Size(439, 378);
            this.dgv_list.TabIndex = 15;
            this.dgv_list.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellEndEdit);
            this.dgv_list.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_list_CellMouseClick);
            // 
            // ts_t2
            // 
            this.ts_t2.AutoSize = false;
            this.ts_t2.BackColor = System.Drawing.Color.White;
            this.ts_t2.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_t2.GripMargin = new System.Windows.Forms.Padding(0);
            this.ts_t2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_t2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_t2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsd_sheets,
            this.tsb_ref,
            this.tsb_close});
            this.ts_t2.Location = new System.Drawing.Point(0, 0);
            this.ts_t2.Name = "ts_t2";
            this.ts_t2.Padding = new System.Windows.Forms.Padding(0);
            this.ts_t2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_t2.Size = new System.Drawing.Size(438, 27);
            this.ts_t2.Stretch = true;
            this.ts_t2.TabIndex = 18;
            // 
            // cms_grid
            // 
            this.cms_grid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_play,
            this.tsmi_playlist,
            this.toolStripSeparator4,
            this.gcms_insert,
            this.gcms_del,
            this.toolStripMenuItem3,
            this.gcms_ref});
            this.cms_grid.Name = "cms_grid";
            this.cms_grid.Size = new System.Drawing.Size(145, 126);
            // 
            // tsmi_play
            // 
            this.tsmi_play.Name = "tsmi_play";
            this.tsmi_play.Size = new System.Drawing.Size(144, 22);
            this.tsmi_play.Text = "播放(&P)";
            // 
            // tsmi_playlist
            // 
            this.tsmi_playlist.Name = "tsmi_playlist";
            this.tsmi_playlist.Size = new System.Drawing.Size(144, 22);
            this.tsmi_playlist.Text = "顺序播放(&M)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // gcms_insert
            // 
            this.gcms_insert.Name = "gcms_insert";
            this.gcms_insert.Size = new System.Drawing.Size(144, 22);
            this.gcms_insert.Text = "插入行(&I)";
            // 
            // gcms_del
            // 
            this.gcms_del.Name = "gcms_del";
            this.gcms_del.Size = new System.Drawing.Size(144, 22);
            this.gcms_del.Text = "删除行(&D)";
            this.gcms_del.Click += new System.EventHandler(this.gcms_del_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(141, 6);
            // 
            // gcms_ref
            // 
            this.gcms_ref.Name = "gcms_ref";
            this.gcms_ref.Size = new System.Drawing.Size(144, 22);
            this.gcms_ref.Text = "刷新(&R)";
            this.gcms_ref.Click += new System.EventHandler(this.gcms_ref_Click);
            // 
            // tsd_sheets
            // 
            this.tsd_sheets.Image = global::X.File.Properties.Resources.table;
            this.tsd_sheets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsd_sheets.Name = "tsd_sheets";
            this.tsd_sheets.Size = new System.Drawing.Size(65, 24);
            this.tsd_sheets.Text = "表格";
            // 
            // tsb_ref
            // 
            this.tsb_ref.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_ref.Image = global::X.File.Properties.Resources.refresh;
            this.tsb_ref.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ref.Name = "tsb_ref";
            this.tsb_ref.Size = new System.Drawing.Size(24, 24);
            this.tsb_ref.Text = "重新加载";
            this.tsb_ref.Click += new System.EventHandler(this.tssb_ref_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_close.Image = global::X.File.Properties.Resources.close;
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(24, 24);
            this.tsb_close.Text = "toolStripButton1";
            this.tsb_close.Click += new System.EventHandler(this.tsb_close_Click);
            // 
            // XlsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tsc_xls);
            this.Name = "XlsView";
            this.Size = new System.Drawing.Size(438, 430);
            this.tsc_xls.BottomToolStripPanel.ResumeLayout(false);
            this.tsc_xls.BottomToolStripPanel.PerformLayout();
            this.tsc_xls.ContentPanel.ResumeLayout(false);
            this.tsc_xls.TopToolStripPanel.ResumeLayout(false);
            this.tsc_xls.ResumeLayout(false);
            this.tsc_xls.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.ts_t2.ResumeLayout(false);
            this.ts_t2.PerformLayout();
            this.cms_grid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tsc_xls;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsl_data_tip;
        private System.Windows.Forms.ToolStripLabel tsl_file;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.ToolStrip ts_t2;
        private System.Windows.Forms.ToolStripDropDownButton tsd_sheets;
        private System.Windows.Forms.ToolStripButton tsb_ref;
        private System.Windows.Forms.ContextMenuStrip cms_grid;
        private System.Windows.Forms.ToolStripMenuItem tsmi_play;
        private System.Windows.Forms.ToolStripMenuItem tsmi_playlist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem gcms_insert;
        private System.Windows.Forms.ToolStripMenuItem gcms_del;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gcms_ref;
        private System.Windows.Forms.ToolStripButton tsb_close;
    }
}
