using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Desktop_Notes
{
    public partial class MainForm : Form
    {
        public MainForm(int id, FormData dat = null)
        {            
            FORM_ID = id;
            InitializeComponent();
            CustomTheme = new Theme();

            loadThemes();
            this.AllowTransparency = true;
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.Manual;

            LoadData(dat);
        }

        private void LoadData(FormData dat = null)
        {
            //load defaults
            this.Opacity = 0.95;
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            if (string.IsNullOrEmpty(Title))
            {
                Title = string.Format("Note {0:##}", FORM_ID);
            }
            if (Program.Themes.Count > 1)
            {
                int seed = (int)DateTime.Now.Ticks & ((1 << 25) - 1);
                Random rand = new Random(seed);
                CurrentTheme = rand.Next(Program.Themes.Count);
            }
            this.Show();
            
            //load others
            if (dat == null) return;
            if (dat.hidden) this.Hide();
            this.SuspendLayout();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = dat.Location;
            this.Size = dat.FormSize;
            this.notebox1.Font = dat.font;
            this.notebox1.Text = dat.data;
            this.Opacity = dat.opacity;
            this.Title = dat.title;
            if (dat.customTheme != null) this.CustomTheme = dat.customTheme;
            this.CurrentTheme = dat.theme;
            this.ResumeLayout(true);
        }

        //
        // Properties and Variables
        //
        public int FORM_ID { get; set; }
        public string Title
        {
            get { return titlebar.Text; }
            set { titlebar.Text = value; Save(); }
        }
        private int _theme = 0;
        public int CurrentTheme
        {
            get { return _theme; }
            set
            {
                _theme = value;

                if (_theme >= Program.Themes.Count)
                    _theme = Program.Themes.Count - 1;
                if (_theme < 0) _theme = 0;

                ReloadTheme();
                Save();
            }
        }

        public void ReloadTheme()
        {
            Theme th = Program.Themes[_theme];
            if (th.Name == "Custom") th = CustomTheme;
            this.notebox1.BackColor = th.BackColor;
            this.notebox1.ForeColor = th.TextColor;
            this.TopBar.BackColor = th.TopBarColor;
            this.titlebar.BackColor = th.TopBarColor;
            this.addButton.BackColor = th.TopBarColor;
            this.deleteButton.BackColor = th.TopBarColor;
            this.hideButton.BackColor = th.TopBarColor;
        }

        public Theme CustomTheme { get; set; }
        
        //
        //Drag form using Topbar
        //
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, long Msg, long wParam, long lParam);
        [DllImportAttribute("user32.dll")]
        public static extern int ReleaseCapture();

        private void TopBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //
        // save and load data
        // 
        public bool Save()
        {
            try
            {
                REGISTRY.SetData(FORM_ID.ToString(), new FormData(this));
                return true;
            }
            catch { return false; }
        }
        private void property_Changed(object sender, EventArgs e)
        {
            Save();
        }

        //
        // Themes
        //
        void loadThemes()
        {
            themeContext.Items.Clear();
            for (int i = 0; i < Program.Themes.Count; ++i)
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
        }

        //
        // Topbar icons
        //

        private void themeContext_Opening(object sender, CancelEventArgs e)
        {
            stayOnTopToolStripMenuItem.Checked = this.TopMost;
        }

        private void cut_Click(object sender, EventArgs e)
        {
            notebox1.Cut();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            notebox1.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            notebox1.Paste();
        }
        private void hideNote_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addNote_Click(object sender, EventArgs e)
        {
            notebox1.Focus();
            Program.AddNewNote();
        }
        private void stayOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stayOnTopToolStripMenuItem.Checked = !stayOnTopToolStripMenuItem.Checked;
            this.TopMost = stayOnTopToolStripMenuItem.Checked;
            Save();
        }
        private void deleteNote_Click(object sender, EventArgs e)
        {
            sureDialog.Visible = true;
            this.TopMost = true;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm(this);
            setting.ShowDialog();
        }


        //
        // Sure Dialog
        //
        private void yesButton_Click(object sender, EventArgs e)
        {
            REGISTRY.Delete(FORM_ID.ToString());
            Program.EmptySlots.Enqueue(FORM_ID);
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            sureDialog.Visible = false;
            this.TopMost = false;
        }
        
        //
        // Button Style
        //
        private void addButton_Enter(object sender, EventArgs e)
        {
            addButton.Image = Properties.Resources.add;
        }

        private void addButton_Leave(object sender, EventArgs e)
        {
            addButton.Image = Properties.Resources.add_gray;
        }

        private void hideButton_Enter(object sender, EventArgs e)
        {
            hideButton.Image = Properties.Resources.hide;
        }

        private void hideButton_Leave(object sender, EventArgs e)
        {
            hideButton.Image = Properties.Resources.hide_gray;
        }

        private void deleteButton_Enter(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.delete;
        }

        private void deleteButton_Leave(object sender, EventArgs e)
        {
            deleteButton.Image = Properties.Resources.delete_gray;
        }
    }
}
