namespace Desktop_Notes
{
    partial class Component1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Component1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.context1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newnote_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showall_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.hideall_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.start_windows = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.context1.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Click here to access desktop notes.";
            this.notifyIcon1.BalloonTipTitle = "Desktop Notes";
            this.notifyIcon1.ContextMenuStrip = this.context1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // context1
            // 
            this.context1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.newnote_menu,
            this.toolStripSeparator2,
            this.showall_menu,
            this.hideall_menu,
            this.toolStripSeparator1,
            this.start_windows,
            this.exit_menu});
            this.context1.Name = "contextMenuStrip1";
            this.context1.Size = new System.Drawing.Size(182, 132);
            this.context1.Opening += new System.ComponentModel.CancelEventHandler(this.context1_Opening);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // newnote_menu
            // 
            this.newnote_menu.Name = "newnote_menu";
            this.newnote_menu.Size = new System.Drawing.Size(181, 22);
            this.newnote_menu.Text = "New Note";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // showall_menu
            // 
            this.showall_menu.Name = "showall_menu";
            this.showall_menu.Size = new System.Drawing.Size(181, 22);
            this.showall_menu.Text = "Show All";
            // 
            // hideall_menu
            // 
            this.hideall_menu.Name = "hideall_menu";
            this.hideall_menu.Size = new System.Drawing.Size(181, 22);
            this.hideall_menu.Text = "Hide All";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // start_windows
            // 
            this.start_windows.CheckOnClick = true;
            this.start_windows.Name = "start_windows";
            this.start_windows.Size = new System.Drawing.Size(181, 22);
            this.start_windows.Text = "Open with Windows";
            // 
            // exit_menu
            // 
            this.exit_menu.Name = "exit_menu";
            this.exit_menu.Size = new System.Drawing.Size(181, 22);
            this.exit_menu.Text = "Exit";
            this.context1.ResumeLayout(false);

        }
        
        #endregion

        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip context1;
        private System.Windows.Forms.ToolStripMenuItem showall_menu;
        private System.Windows.Forms.ToolStripMenuItem hideall_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit_menu;
        private System.Windows.Forms.ToolStripMenuItem newnote_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem start_windows;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

    }
}
