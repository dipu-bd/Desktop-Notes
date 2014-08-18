using System.Drawing;

namespace Desktop_Notes
{
    public class FormData
    {
        public Point Location { get; set; }
        public Size FormSize { get; set; }
        public string data { get; set; }
        public Font font { get; set; }
        public int theme { get; set; }
        public double opacity { get; set; }
        public string title { get;set;}
        public bool hidden { get; set; }
        public bool topmost { get; set; }

        public FormData() { }
        public FormData(MainForm form)
        {
            Location = form.Location;
            FormSize = form.Size;
            data = form.notebox1.Text;
            font = form.notebox1.Font;
            theme = form.CurrentTheme;
            opacity = form.Opacity;
            hidden = !form.Visible;
            title = form.Title;
            topmost = form.TopMost;
        }
    }

    public class Theme
    {
        public string Name { get; set; }
        public Color TextColor { get; set; }
        public Color BackColor { get; set; }
        public Color TopBarColor { get; set; }

        public Theme() { }
        public Theme(string name, Color text, Color back, Color top)
        {
            Name = name;
            TextColor = text;
            BackColor = back;
            TopBarColor = top;
        }

        public static Theme DefaultTheme()
        {
            Theme th = new Theme();
            th.Name = "Default";
            th.TextColor = Color.Black;
            th.BackColor = Color.FromArgb(255, 255, 200);
            th.TopBarColor = Color.FromArgb(245, 240, 180);
            return th;
        }
    }        
} 
