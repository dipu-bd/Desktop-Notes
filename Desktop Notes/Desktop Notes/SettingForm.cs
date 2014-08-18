using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class SettingForm : Form
    {
        MainForm form = null;

        public SettingForm(MainForm form)
        {
            InitializeComponent();

            load_themes();
            this.form = form;
            load_settings();
        }

        void load_themes()
        {
            List<string> items = new List<string>();
            for (int i = 0; i < Program.Themes.Count; ++i)
            {
                items.Add(string.Format("{0} : {1}",
                    i + 1, Program.Themes[i].Name));
            }

            theme_sel.Items.Clear();
            theme_sel.Items.AddRange(items.ToArray());

            theme_sel.SelectedIndex = 0;
        }

        void load_settings()
        {
            Theme th = Program.Themes[form.CurrentTheme];
            topbar_color.BackColor = th.TopBarColor;
            back_color.BackColor = th.BackColor;
            text_color.BackColor = th.TextColor;

            current_font.Font = form.notebox1.Font;
            current_font.Text = form.notebox1.Font.FontFamily.Name;
            font_size.Value = (decimal)(form.notebox1.Font.Size);

            opacity_val.Value = (decimal)form.Opacity;
            theme_sel.SelectedIndex = form.CurrentTheme;
        }

        void load_defaults()
        {
            MainForm def = new MainForm(0);
            form.CurrentTheme = def.CurrentTheme;
            form.notebox1.Font = def.notebox1.Font;
            form.Opacity = def.Opacity;
            load_settings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_defaults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Save();
            this.Close();
        }

        //theme changed
        private void theme_sel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { form.CurrentTheme = (int)theme_sel.SelectedIndex; }
            catch { }
        }


        //change values 
        private void current_font_Click(object sender, EventArgs e)
        {
            FontDialog fod = new FontDialog();
            fod.Font = current_font.Font;
            if (fod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                current_font.Font = new Font(fod.Font.FontFamily, 12.0F);
                current_font.Text = fod.Font.FontFamily.Name;
                font_size.Value = (decimal)fod.Font.Size;
                form.notebox1.Font = fod.Font;
            }
        }

        private void font_size_ValueChanged(object sender, EventArgs e)
        {
            if (current_font.Font.Size == (float)font_size.Value) return;
            current_font.Font = new Font(current_font.Font.FontFamily, (float)font_size.Value);
            form.notebox1.Font = current_font.Font;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            decimal v = (decimal)trackBar1.Value / 100;
            if (opacity_val.Value != v) opacity_val.Value = v;
        }

        private void opacity_val_ValueChanged(object sender, EventArgs e)
        {
            form.Opacity = (double)opacity_val.Value;
            int v = (int)(opacity_val.Value * 100);
            if (v >= trackBar1.Minimum && v != trackBar1.Value) trackBar1.Value = v;
        }
    }
}
