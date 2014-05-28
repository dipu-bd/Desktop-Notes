using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class SettingForm : Form
    {
        MainForm form = null;

        public SettingForm(MainForm form)
        {
            InitializeComponent();

            this.form = form;
            load_settings();
        }

        void load_settings()
        {
            topbar_color.BackColor = form.TopBar.BackColor;
            back_color.BackColor = form.notebox1.BackColor;
            text_color.BackColor = form.notebox1.ForeColor;
            current_font.Font = form.notebox1.Font;
            current_font.Text = form.notebox1.Font.FontFamily.Name;
            font_size.Value = (decimal)(form.notebox1.Font.Size);
        }

        void load_defaults()
        {
            MainForm def = new MainForm(0);
            form.TopBar.BackColor = def.TopBar.BackColor;
            form.notebox1.BackColor = def.notebox1.BackColor;
            form.notebox1.ForeColor = def.notebox1.ForeColor;
            form.notebox1.Font = def.notebox1.Font;
            load_settings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_defaults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //change values

        private void topbar_color_Click(object sender, EventArgs e)
        {
            ColorDialog cod = new ColorDialog();
            cod.Color = topbar_color.BackColor;
            if (cod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                topbar_color.BackColor = cod.Color;
                form.TopBar.BackColor = cod.Color;
            }
        }

        private void back_color_Click(object sender, EventArgs e)
        {
            ColorDialog cod = new ColorDialog();
            cod.Color = back_color.BackColor;
            if (cod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                back_color.BackColor = cod.Color;
                form.notebox1.BackColor = cod.Color;
            }
        }

        private void text_color_Click(object sender, EventArgs e)
        {
            ColorDialog cod = new ColorDialog();
            cod.Color = text_color.BackColor;
            if (cod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                text_color.BackColor = cod.Color;
                form.notebox1.ForeColor = cod.Color;
            }
        }

        private void current_font_Click(object sender, EventArgs e)
        {
            FontDialog fod = new FontDialog();
            fod.Font = current_font.Font;
            if (fod.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                current_font.Font = fod.Font;
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


    }
}
