﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Desktop_Notes
{
    public partial class Component1 : Component
    {

        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);

        public Component1()
        {
            InitializeComponent();

            this.showall_menu.Click += showall_menu_Click;
            this.hideall_menu.Click += hideall_menu_Click;
            this.newnote_menu.Click += newnote_menu_Click;
            this.exit_menu.Click += exit_menu_Click;
            this.start_windows.Checked = REGISTRY.StartWithWindows;
            this.start_windows.CheckedChanged += start_windows_CheckedChanged;
        }
        
        public Component1(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        //start with windows
        void start_windows_CheckedChanged(object sender, EventArgs e)
        {
            REGISTRY.StartWithWindows = start_windows.Checked;
        }

        //notify icon
        public void SetIconVisible(bool isVisible)
        {
            notifyIcon1.Visible = isVisible;
        }

        void newnote_menu_Click(object sender, System.EventArgs e)
        {
            Program.AddNewNote();
        }

        void hideall_menu_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in Application.OpenForms) f.Hide();
        }

        void showall_menu_Click(object sender, System.EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Show();
                SetForegroundWindow(f.Handle.ToInt32());
            }
        }

        void exit_menu_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        } 

        private void context1_Opening(object sender, CancelEventArgs e)
        {
            while(context1.Items[0].Tag != null) 
                context1.Items.RemoveAt(0);            
            
            foreach (Form f in Application.OpenForms)
            {
                if (!f.Visible)
                {
                    ToolStripMenuItem menu = new ToolStripMenuItem();
                    menu.Text = ((MainForm)f).Title;
                    menu.Tag = f;
                    menu.Click += menu_Click;
                    context1.Items.Insert(0, menu);                    
                }
            }
        }

        void menu_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem menu = (ToolStripMenuItem)sender;
                MainForm f = (MainForm)menu.Tag;
                f.Show();
                context1.Items.Remove(menu);
            }
            catch { }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Visible) SetForegroundWindow(f.Handle.ToInt32());
                }
            }
        }

    }
}