﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X.File
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            lb_appname.Text = App.cfg.AppName;
            lb_appver.Text = "V" + App.cfg.AppVer;
        }

        private void lk_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.chinalanguages.org/");
        }
    }
}
