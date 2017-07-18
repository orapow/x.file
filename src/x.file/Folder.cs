using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace x.file
{
    public partial class Folder : Form
    {
        public string SelectedPath { get; set; }
        public Folder()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            var tn = tv_dir.SelectedNode;
            if (tn != null)
            {
                DialogResult = DialogResult.OK;
                SelectedPath = App.cfg.dir + "\\" + tn.FullPath;
            }
            Close();
        }

        private void Folder_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(App.cfg.dir)) return;
            tv_dir.Nodes.Clear();
            ((Action)(() =>
            {
                loadDir(new DirectoryInfo(App.cfg.dir), tv_dir.Nodes);
                //tv_dir.ExpandAll();
            })).Invoke();
        }

        void loadDir(DirectoryInfo dir, TreeNodeCollection tns)
        {
            foreach (var d in dir.EnumerateDirectories())
            {
                Invoke(new Action(() =>
                {
                    var tn = new TreeNode() { Text = d.Name, Tag = d.FullName };
                    tns.Add(tn);
                    loadDir(d, tn.Nodes);
                }));
            }
            foreach (var f in dir.GetFiles())
            {
                Invoke(new Action(() =>
                {
                    var tn = new TreeNode() { Text = f.Name, Tag = f.FullName };
                    tns.Add(tn);
                }));
            }
        }

    }
}
