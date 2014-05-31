using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class MainForm : Form
    {
        public int FORM_ID { get; set; }
        public string Title
        {
            get { return titlebar.Text; }
            set { titlebar.Text = value; }
        }
        private int _theme = 0;
        public int CurrentTheme
        {
            get { return _theme; }
            set
            {
                _theme = value;

                if (_theme > Program.Themes.Count)
                    _theme = Program.Themes.Count - 1;

                Theme th = Program.Themes[_theme];
                this.TopBar.BackColor = th.TopBarColor;
                this.notebox1.BackColor = th.BackColor;
                this.notebox1.ForeColor = th.TextColor;
            }
        }        
                
        public MainForm(int id, FormData dat = null)
        {
            FORM_ID = id;
            InitializeComponent();

            this.AllowTransparency = true;
            this.DoubleBuffered = true;

            loadThemes();
            if (dat != null) SetData(dat);
            Title = string.Format("Note {0:##}", FORM_ID);             
        }

        //
        // Themes
        //
        void loadThemes()
        {
            themeContext.Items.Clear();
            for(int i = 0; i < Program.Themes.Count; ++i)
            {
                ToolStripMenuItem ti = new ToolStripMenuItem();
                ti.Text = Program.Themes[i].Name;
                ti.Tag = i;
                ti.Click += ti_Click;
                themeContext.Items.Add(ti);
            }
        }

        void ti_Click(object sender, EventArgs e)
        {
            CurrentTheme = (int)((ToolStripItem)sender).Tag;
            Save();
        }

        //
        // save and load data
        //
        public bool Save()
        {
            try
            {
                if (this.notebox1.Text.Length == 0) return false;
                REGISTRY.SetData(FORM_ID.ToString(), new FormData(this));
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void property_Changed(object sender, EventArgs e)
        {
            Save();
        }

        void SetData(FormData dat)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = dat.Location;
            this.Size = dat.FormSize;
            this.CurrentTheme = dat.theme;
            this.notebox1.Font = dat.font;
            this.notebox1.Text = dat.data;
            this.Opacity = dat.opacity;
            REGISTRY.SetData(FORM_ID.ToString(), dat);
        }

        //
        //Drag form using Topbar
        //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TopBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //
        // Topbar icons
        //
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
         
        private void add_note_Click(object sender, EventArgs e)
        {
            Program.AddNewNote();
        } 
         
        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRY.Delete(FORM_ID.ToString());
            Program.EmptySlots.Enqueue(FORM_ID);
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm(this);
            setting.ShowDialog();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notebox1.Paste();
        }

    }
}
