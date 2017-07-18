﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Shell32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace X.File.Ctrl
{

    public partial class FileView : UserControl
    {
        public delegate void PlayFilesHandler(string[] file);
        public event PlayFilesHandler PlayFiles;

        [DllImport("shell32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool SHFileOperation([In, Out]  SHFILEOPSTRUCT str);
        private const int FO_MOVE = 0x1;
        private const int FO_COPY = 0x2;
        private const int FO_DELETE = 0x3;
        private const ushort FOF_NOCONFIRMATION = 0x10;
        private const ushort FOF_ALLOWUNDO = 0x40;
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public class SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            /// <summary>
            /// 设置操作方式，移动：FO_MOVE，复制：FO_COPY，删除：FO_DELETE
            /// </summary>
            public UInt32 wFunc;
            /// <summary>
            /// 源文件路径
            /// </summary>
            public string pFrom;
            /// <summary>
            /// 目标文件路径
            /// </summary>
            public string pTo;
            /// <summary>
            /// 允许恢复
            /// </summary>
            public UInt16 fFlags;
            /// <summary>
            /// 监测有无中止
            /// </summary>
            public Int32 fAnyOperationsAborted;
            public IntPtr hNameMappings;
            /// <summary>
            /// 设置标题
            /// </summary>
            public string lpszProgressTitle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="act">
        /// 1、剪切
        /// 2、复制
        /// 3、删除
        /// </param>
        /// <returns></returns>
        private bool copyFile(string to, string from, int act)
        {
            SHFILEOPSTRUCT pm = new SHFILEOPSTRUCT();
            pm.wFunc = (uint)act;
            pm.pFrom = from;
            pm.pTo = to;
            pm.fFlags = FOF_ALLOWUNDO;//允许恢复
            pm.lpszProgressTitle = "正在" + "移动|复制|删除".Split('|')[act - 1]; //+ this.FindForm().Text;
            return !SHFileOperation(pm);
        }

        ShellClass sc = new ShellClass();

        public FileView()
        {
            InitializeComponent();
            lv_files.SmallImageList = App.il20;
            lv_files.LargeImageList = App.il32;
            this.DoubleBuffered = true;
        }

        public void SelectFile(string file)
        {
            var items = lv_files.Items.Find(file.Substring(file.LastIndexOf("\\") + 1), false);
            if (items == null || items.Count() == 0) return;
            lv_files.SelectedItems.Clear();
            items[0].Selected = true;
        }

        public void LoadFile(DirectoryInfo di)
        {
            if (di == null && tsl_dir.Tag == null) return;
            if (di == null) di = new DirectoryInfo(tsl_dir.Tag.ToString());

            tsl_dir.Tag = di.FullName;
            tsl_dir.Text = "文件夹：" + tsl_dir.Tag.ToString().ToLower().Replace(App.cfg.work.ToLower(), "\\").Replace("\\\\", "\\");

            lv_files.Items.Clear();
            lv_files.BeginUpdate();
            if (!di.Exists) return;
            var i = 1;

            foreach (var d in di.GetDirectories())
            {
                App.getIcon("dir", d.FullName);
                var lvi = new ListViewItem();
                lvi.ImageKey = "dir";
                if (lv_files.View == View.Details) lvi.SubItems.AddRange(new string[] { i++ + "" + "　　", "文件夹", "", "", d.CreationTime.ToString("yyyy-MM-dd HH:mm"), "" });
                lvi.Tag = d.FullName;
                lvi.Text = d.Name;
                lv_files.Items.Add(lvi);
            }
            var fs = di.GetFiles();
            if (fs.Length == 0) { lv_files.Columns[3].Width = 0; lv_files.Columns[4].Width = 0; lv_files.Columns[6].Width = 0; }
            else { lv_files.Columns[6].Width = 120; lv_files.Columns[3].Width = 60; lv_files.Columns[4].Width = 60; }
            var files = new List<ListViewItem>();
            foreach (var f in fs)
            {
                App.getIcon(f.Extension, f.FullName);
                var lvi = new ListViewItem(f.Name.Substring(0, f.Name.LastIndexOf('.')));
                lvi.Name = f.Name;
                lvi.Tag = f.FullName;
                lvi.ImageKey = f.Extension;
                lvi.SubItems.AddRange(new string[] { i++ + "", f.Extension.ToUpper(), "", getSize(f.Length), f.CreationTime.ToString("yyyy-MM-dd HH:mm"), f.LastWriteTime.ToString("yyyy-MM-dd HH:mm") });
                files.Add(lvi);
            }
            lv_files.Items.AddRange(files.ToArray());
            lv_files.EndUpdate();
            tsl_dir_tip.Text = "文件夹 " + di.GetDirectories().LongLength + "个，文件" + di.GetFiles().LongLength + "个";

            lv_files_ItemSelectionChanged(null, null);
        }

        /// <summary>
        /// 文件大小转换
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        string getSize(long len)
        {
            var l = (double)len;
            var us = "Byte|Kb|Mb|Gb|Tb".Split('|');
            var i = 0;
            for (; l >= 1024; l /= 1024.0, i++) ;
            return l.ToString("F2") + us[i];
        }

        private void tsb_up_Click(object sender, EventArgs e)
        {
            var d = tsl_dir.Tag.ToString();
            if (d.ToLower() == App.cfg.work.ToLower()) return;
            d = d.Substring(0, d.LastIndexOf("\\"));
            LoadFile(new DirectoryInfo(d));
        }

        void lv_files_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (lv_files.View != View.Details) e.DrawDefault = true;
        }

        void lv_files_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (lv_files.View != View.Details) { e.DrawDefault = true; return; }
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            var txt = e.Item.SubItems[e.ColumnIndex].Text;
            if (e.ColumnIndex == 0) txt = e.Item.SubItems[1].Text;
            else if (e.ColumnIndex == 1) txt = e.Item.Text;
            if (e.Item.Selected) e.Graphics.FillRectangle(new SolidBrush(SystemColors.Highlight), e.Bounds);
            if (e.ColumnIndex == 0)
            {
                e.Graphics.DrawString(txt, e.Item.Font, e.Item.Selected ? Brushes.White : Brushes.Black, e.Bounds.X + 2, e.Bounds.Y + 4);
            }
            else if (e.ColumnIndex == 1 && !string.IsNullOrEmpty(e.Item.ImageKey)) //在第几列画    
            {
                var tmp_image = e.Item.ImageList.Images[e.Item.ImageKey];// lv_files.SmallImageList.Images[0]; //声明Image实例，用来指定后面要画的那个图标    
                var rect = new Rectangle(); //指明画的矩形对象    
                rect.X = e.Bounds.X;
                rect.Y += e.Bounds.Y + 2;
                rect.Width = 16;
                rect.Height = 16;
                e.Graphics.DrawImage(tmp_image, rect);
                e.Graphics.DrawString(txt, e.Item.Font, e.Item.Selected ? Brushes.White : Brushes.Black, tmp_image.Width + 5 + e.Bounds.X, e.Bounds.Y + 4);
            }
            else
            {
                if (e.ColumnIndex == 3 && lv_files.View == View.Details)
                {
                    if (e.SubItem.Tag == null)
                    {
                        var dir = sc.NameSpace(tsl_dir.Tag.ToString());
                        e.SubItem.Tag = e.SubItem.Text = dir.GetDetailsOf(dir.ParseName(e.Item.Text + e.Item.SubItems[2].Text), 27);
                    }
                }
                e.DrawDefault = true;
            }
        }

        void lv_files_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void View_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mi = sender as ToolStripMenuItem;
            if (mi == null) return;
            foreach (ToolStripMenuItem m in toolStripSplitButton1.DropDownItems) m.Checked = false;
            mi.Checked = true;
            switch (mi.Tag.ToString())
            {
                case "1":
                    lv_files.View = View.Details;
                    break;
                case "2":
                    lv_files.View = View.SmallIcon;
                    break;
                case "3":
                    lv_files.View = View.LargeIcon;
                    break;
                case "4":
                    lv_files.View = View.Tile;
                    break;
                case "5":
                    lv_files.View = View.List;
                    break;
            }
            lv_files.RedrawItems(0, lv_files.Items.Count - 1, false);
        }

        private void tsb_new_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tsl_dir.Tag.ToString())) return;
            var fn = "新建文件夹";
            var i = 1;
            while (Directory.Exists(tsl_dir.Tag + "\\" + fn))
            {
                fn = "新建文件夹" + i++;
            }
            Directory.CreateDirectory(tsl_dir.Tag + "\\" + fn);
            LoadFile(null);
            foreach (ListViewItem it in lv_files.Items)
                if (it.Tag.ToString() == (tsl_dir.Tag + "\\" + fn) + "") { lv_files.LabelEdit = true; it.BeginEdit(); break; }
        }

        private void tsb_del_Click(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var fs = new StringBuilder();
            foreach (ListViewItem it in lv_files.SelectedItems)
                fs.Append(it.Tag + "\0");
            fs.Append("\0");
            if (MessageBox.Show("确认要删除选中项吗？", this.ParentForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            copyFile("del", fs.ToString(), 3);
            LoadFile(null);
        }

        private void cms_tree_Opening(object sender, CancelEventArgs e)
        {
            #region 初始化
            tsmi_copy.Enabled = false;
            tsmi_cut.Enabled = false;
            tsmi_del.Enabled = false;
            tsmi_open_in_exp.Visible = false;
            tsmi_open_vod.Visible = false;
            tsmi_open_voc.Visible = false;
            tsmi_parse.Enabled = false;
            tsmi_play.Enabled = false;
            tsmi_rename.Enabled = false;
            tsmi_use_excelopen.Visible = false;
            tsmi_use_wordopen.Visible = false;
            tsmi_st_play.Enabled = false;
            tsp_p2.Visible = false;
            tsp_p3.Visible = false;
            #endregion

            var items = lv_files.SelectedItems;
            if (items.Count == 0)
            {
                var fs = Clipboard.GetFileDropList();
                if (fs.Count > 0) tsmi_parse.Enabled = true;
                else tsb_parse.Enabled = false;
                tsp_p2.Visible = true;
            }
            else if (items.Count == 1)
            {
                tsmi_open_in_exp.Visible = true;
                tsp_p3.Visible = true;

                tsmi_copy.Enabled = tsmi_cut.Enabled = tsmi_rename.Enabled = true;//文件操作

                tsmi_del.Enabled = true;

                var it = items[0];
                var p = it.Tag.ToString();
                if (System.IO.File.Exists(p))
                {
                    var ext = p.Substring(p.LastIndexOf(".") + 1).ToLower();
                    string v = "";
                    if (App.cfg.exts.ContainsKey(ext)) v = App.cfg.exts[ext];
                    switch (v)
                    {
                        case "图片":
                        case "录音":
                        case "视频":
                            tsmi_play.Enabled = true;
                            tsmi_st_play.Enabled = true;
                            break;
                        case "表格":
                            tsmi_use_excelopen.Visible = true;
                            tsp_p2.Visible = tsmi_open_voc.Visible = tsmi_open_vod.Visible = true;
                            break;
                        case "文档":
                            tsmi_use_wordopen.Visible = true;
                            tsp_p2.Visible = false;
                            break;
                    }
                }
            }
            else
            {
                tsmi_del.Visible = tsp_p3.Visible = tsmi_copy.Enabled = tsmi_cut.Enabled = true;
                tsp_p2.Visible = false;
                tsmi_play.Enabled = true;
                tsmi_rename.Enabled = false;
                tsmi_use_excelopen.Visible = false;
                tsmi_use_wordopen.Visible = false;
                tsmi_open_voc.Visible = false;
                tsmi_open_vod.Visible = false;
            }
        }

        private void tsmi_reload_Click(object sender, EventArgs e)
        {
            LoadFile(null);
        }

        private void tsmi_open_vod_Click(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var p = lv_files.SelectedItems[0].Tag.ToString();
            p = p.Replace("模板表\\", "视频\\");
            p = p.Substring(0, p.LastIndexOf("."));
            LoadFile(new DirectoryInfo(p));
        }

        private void tsmi_open_voc_Click(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var p = lv_files.SelectedItems[0].Tag.ToString();
            p = p.Replace("模板表\\", "录音\\");
            p = p.Substring(0, p.LastIndexOf("."));
            LoadFile(new DirectoryInfo(p));
        }

        private void tsmi_open_doc_Click(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var p = lv_files.SelectedItems[0].Tag.ToString();
            if (System.IO.File.Exists(p)) Process.Start(p);
            else MessageBox.Show("文件不存在", this.ParentForm.Text);
        }

        private void tsmi_open_excel_Click(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var p = lv_files.SelectedItems[0].Tag.ToString();
            if (System.IO.File.Exists(p)) Process.Start(p);
            else MessageBox.Show("文件不存在", this.ParentForm.Text);
        }

        private void tsmi_use_wordopen_Click(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var p = lv_files.SelectedItems[0].Tag.ToString();
            if (System.IO.File.Exists(p)) Process.Start(p);
            else MessageBox.Show("文件不存在", this.ParentForm.Text);
        }

        private void tsmi_use_excelopen_Click(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var p = lv_files.SelectedItems[0].Tag.ToString();
            if (System.IO.File.Exists(p)) Process.Start(p);
            else MessageBox.Show("文件不存在", this.ParentForm.Text);
        }

        private void tsmi_open_in_exp_Click(object sender, EventArgs e)
        {
            if (lv_files.SelectedItems.Count == 0) return;
            var p = lv_files.SelectedItems[0].Tag.ToString();
            Process.Start("explorer.exe", "/select," + p);
        }

        private void tsmi_play_Click(object sender, EventArgs e)
        {
            var items = lv_files.SelectedItems;
            if (items.Count == 0) return;
            if (items.Count == 1)
            {
                var p = items[0].Tag.ToString();
                if (!System.IO.File.Exists(p)) { LoadFile(new DirectoryInfo(p)); return; }
            }
            var fs = new List<string>();
            foreach (ListViewItem li in items)
            {
                if (!System.IO.File.Exists(li.Tag.ToString())) continue;
                fs.Add(li.Tag.ToString());
            }
            if (fs.Count > 0) PlayFiles?.Invoke(fs.ToArray());
        }

        private void lv_files_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                tsmi_play_Click(null, null);
        }

        private void lv_files_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            #region 处理剪贴板
            var fs = Clipboard.GetFileDropList();
            if (fs.Count > 0)
            {
                var ms = Clipboard.GetDataObject().GetData("Preferred DropEffect") as MemoryStream;
                if (ms != null)
                {
                    if (ms.ToArray()[0] == 2) tsb_parse.Tag = 1;//剪切
                    else if (ms.ToArray()[0] == 5) tsb_parse.Tag = 2;//复制
                }
                tsb_parse.Enabled = true;
            }
            else tsb_parse.Enabled = false;
            #endregion

            var ct = lv_files.SelectedItems.Count;
            if (ct == 0)
            {
                tsb_copy.Enabled = tsb_cut.Enabled = tsb_del.Enabled = false;
            }
            else
            {
                tsb_copy.Enabled = tsb_cut.Enabled = tsb_del.Enabled = true;
            }
        }

        private void tsb_parse_Click(object sender, EventArgs e)
        {
            var fs = Clipboard.GetFileDropList();
            var files = "";
            foreach (var f in fs) files += f + "\0";
            files += "\0";
            copyFile(tsl_dir.Tag.ToString(), files, Convert.ToInt16(tsb_parse.Tag));
            LoadFile(null);
        }

        private void tsb_cut_Click(object sender, EventArgs e)
        {
            var items = lv_files.SelectedItems;
            if (items == null || items.Count == 0) return;

            var files = new List<string>();
            foreach (ListViewItem it in items) { files.Add(it.Tag.ToString()); }

            toClipboard(files.ToArray(), 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fs"></param>
        /// <param name="act">
        /// 2、移动
        /// 5、复制
        /// </param>
        void toClipboard(string[] fs, int act)
        {
            var data = new DataObject(DataFormats.FileDrop, fs);
            var memo = new MemoryStream(4);
            byte[] bytes = new byte[] { (byte)act, 0, 0, 0 };
            memo.Write(bytes, 0, bytes.Length);
            data.SetData("Preferred DropEffect", memo);
            Clipboard.SetDataObject(data);
        }

        private void tsb_copy_Click(object sender, EventArgs e)
        {
            var items = lv_files.SelectedItems;
            if (items == null || items.Count == 0) return;

            var files = new List<string>();
            foreach (ListViewItem it in items) { files.Add(it.Tag.ToString()); }

            toClipboard(files.ToArray(), 5);
        }
        private void tsmi_rename_Click(object sender, EventArgs e)
        {
            var items = lv_files.SelectedItems;
            if (items == null || items.Count != 1) return;
            lv_files.LabelEdit = true;
            items[0].BeginEdit();
        }

        private void lv_files_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            lv_files.LabelEdit = false;
            var item = lv_files.Items[e.Item];
            if (string.IsNullOrEmpty(e.Label) || item.Text == e.Label) return;
            var path = item.Tag.ToString();
            if (System.IO.File.Exists(path)) System.IO.File.Move(path, (path.Substring(0, path.LastIndexOf("\\") + 1) + e.Label + item.SubItems[2].Text.ToLower()));  //copyFile(path.Substring(0, path.LastIndexOf("\\") + 1) + e.Label + item.SubItems[2].Text.ToLower(), path, 1);
            else new DirectoryInfo(path).MoveTo(path.Substring(0, path.LastIndexOf("\\") + 1) + e.Label); //(, path);
            tsmi_reload_Click(null, null);
            e.CancelEdit = true;
        }

        private void FileView_Enter(object sender, EventArgs e)
        {
            lv_files_ItemSelectionChanged(null, null);
        }

        private void tsmi_selall_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem li in lv_files.Items) li.Selected = true;
        }

        private void tsmi_st_play_Click(object sender, EventArgs e)
        {
            var items = lv_files.SelectedItems;
            if (items.Count != 1) return;
            var i = lv_files.Items.IndexOf(items[0]);
            var fs = new List<string>();
            for (; i < lv_files.Items.Count; i++) fs.Add(lv_files.Items[i].Tag.ToString());
            PlayFiles?.Invoke(fs.ToArray());
        }

        private void lv_files_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                var items = lv_files.SelectedItems;
                if (items.Count != 1) return;
                PlayFiles?.Invoke(new string[] { items[0].Tag.ToString() });
            }
            else if (e.KeyData == Keys.F2) tsmi_rename_Click(null, null);
            else if (e.KeyData == Keys.C && e.Control) tsb_copy_Click(null, null);
            else if (e.KeyData == Keys.X && e.Control) tsb_cut_Click(null, null);
            else if (e.KeyData == Keys.V && e.Control) tsb_parse_Click(null, null);
            else if (e.KeyData == Keys.Space) tsmi_play_Click(null, null);
            else if (e.KeyData == Keys.F5) tsmi_reload_Click(null, null);
        }

        private void lv_files_Enter(object sender, EventArgs e)
        {
            LoadFile(null);
        }
    }

    class XcListView : ListView
    {
        public XcListView()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
        }
    }
}