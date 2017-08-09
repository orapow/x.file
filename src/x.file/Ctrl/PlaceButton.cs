using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X.File.Ctrl
{
    public class PlaceButton : Button
    {
        public string ID { get; set; }
        public PlaceButton()
        {
            Width = 90;
            Height = 30;
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Text = "采录点";
            Margin = new Padding(3, 3, 0, 0);
        }
    }
}
