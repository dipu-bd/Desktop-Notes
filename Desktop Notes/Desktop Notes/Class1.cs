using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Desktop_Notes
{
    public class FormData
    {
        public Point Location { get; set; }
        public Size FormSize { get; set; }
        public string data { get; set; }
        public Font font { get; set; }
        public Color textcolor { get; set; }
        public Color backcolor { get; set; }
        public Color topbarcolor { get; set; }

        public FormData() { }
        public FormData(MainForm form)
        {
            Location = form.Location;
            FormSize = form.Size;
            data = form.notebox1.Text;
            font = form.notebox1.Font;
            textcolor = form.notebox1.ForeColor;
            backcolor = form.notebox1.BackColor;
            topbarcolor = form.TopBar.BackColor;
        }
    }
}
