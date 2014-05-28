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

        public MainForm(int id, FormData dat = null)
        {
            FORM_ID = id;
            InitializeComponent();

            if (dat != null) SetData(dat);

            Title = string.Format("Note {0:##}", FORM_ID);
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
            this.TopBar.BackColor = dat.topbarcolor;
            this.notebox1.ForeColor = dat.textcolor;
            this.notebox1.BackColor = dat.backcolor;
            this.notebox1.Font = dat.font;
            this.notebox1.Text = dat.data;
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

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.AddNewNote();
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRY.Delete(FORM_ID.ToString());
            if (Application.OpenForms.Count == 1) Application.Exit();
            else this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm(this);
            setting.ShowDialog();
        }

    }
}
