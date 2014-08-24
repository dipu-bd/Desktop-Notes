namespace Desktop_Notes
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.hideNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notebox1 = new System.Windows.Forms.RichTextBox();
            this.TopBar = new System.Windows.Forms.TableLayoutPanel();
            this.titlebar = new System.Windows.Forms.TextBox();
            this.sureDialog = new System.Windows.Forms.Panel();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.CustomButton();
            this.hideButton = new System.Windows.Forms.CustomButton();
            this.deleteButton = new System.Windows.Forms.CustomButton();
            this.contextMenuStrip1.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.sureDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.newNoteToolStripMenuItem,
            this.toolStripSeparator3,
            this.hideNoteToolStripMenuItem,
            this.deleteNoteToolStripMenuItem,
            this.toolStripSeparator2,
            this.stayOnTopToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 220);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.paste_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Image = global::Desktop_Notes.Properties.Resources.add;
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newNoteToolStripMenuItem.Text = "New Note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.addNote_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(133, 6);
            // 
            // hideNoteToolStripMenuItem
            // 
            this.hideNoteToolStripMenuItem.Image = global::Desktop_Notes.Properties.Resources.hide;
            this.hideNoteToolStripMenuItem.Name = "hideNoteToolStripMenuItem";
            this.hideNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hideNoteToolStripMenuItem.Text = "Hide Note";
            this.hideNoteToolStripMenuItem.Click += new System.EventHandler(this.hideNote_Click);
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Image = global::Desktop_Notes.Properties.Resources.delete;
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(133, 6);
            // 
            // stayOnTopToolStripMenuItem
            // 
            this.stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            this.stayOnTopToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.stayOnTopToolStripMenuItem.Text = "Stay on top";
            this.stayOnTopToolStripMenuItem.Click += new System.EventHandler(this.stayOnTopToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDown = this.themeContext;
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // themeContext
            // 
            this.themeContext.Name = "themeContext";
            this.themeContext.OwnerItem = this.themeToolStripMenuItem;
            this.themeContext.Size = new System.Drawing.Size(61, 4);
            this.themeContext.Opening += new System.ComponentModel.CancelEventHandler(this.themeContext_Opening);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Desktop_Notes.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settings_Click);
            // 
            // notebox1
            // 
            this.notebox1.AcceptsTab = true;
            this.notebox1.AutoWordSelection = true;
            this.notebox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.notebox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notebox1.ContextMenuStrip = this.contextMenuStrip1;
            this.notebox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notebox1.EnableAutoDragDrop = true;
            this.notebox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notebox1.ForeColor = System.Drawing.Color.Black;
            this.notebox1.Location = new System.Drawing.Point(0, 27);
            this.notebox1.Name = "notebox1";
            this.notebox1.ShowSelectionMargin = true;
            this.notebox1.Size = new System.Drawing.Size(204, 237);
            this.notebox1.TabIndex = 1;
            this.notebox1.Text = "";
            this.notebox1.TextChanged += new System.EventHandler(this.property_Changed);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.TopBar.ColumnCount = 4;
            this.TopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TopBar.Controls.Add(this.addButton, 0, 0);
            this.TopBar.Controls.Add(this.hideButton, 2, 0);
            this.TopBar.Controls.Add(this.deleteButton, 3, 0);
            this.TopBar.Controls.Add(this.titlebar, 1, 0);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.RowCount = 1;
            this.TopBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TopBar.Size = new System.Drawing.Size(204, 27);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // titlebar
            // 
            this.titlebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.titlebar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titlebar.ContextMenuStrip = this.contextMenuStrip1;
            this.titlebar.Cursor = System.Windows.Forms.Cursors.Default;
            this.titlebar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.titlebar.ForeColor = System.Drawing.Color.Black;
            this.titlebar.Location = new System.Drawing.Point(33, 5);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(108, 17);
            this.titlebar.TabIndex = 0;
            this.titlebar.TabStop = false;
            this.titlebar.TextChanged += new System.EventHandler(this.property_Changed);
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // sureDialog
            // 
            this.sureDialog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sureDialog.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sureDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sureDialog.Controls.Add(this.noButton);
            this.sureDialog.Controls.Add(this.yesButton);
            this.sureDialog.Controls.Add(this.label1);
            this.sureDialog.Location = new System.Drawing.Point(14, 95);
            this.sureDialog.Name = "sureDialog";
            this.sureDialog.Size = new System.Drawing.Size(175, 90);
            this.sureDialog.TabIndex = 3;
            this.sureDialog.Visible = false;
            // 
            // noButton
            // 
            this.noButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.noButton.Location = new System.Drawing.Point(92, 59);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 24);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yesButton.Location = new System.Drawing.Point(6, 59);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 24);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure to delete this note?";
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::Desktop_Notes.Properties.Resources.add_gray;
            this.addButton.Location = new System.Drawing.Point(1, 1);
            this.addButton.Margin = new System.Windows.Forms.Padding(1);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(28, 25);
            this.addButton.TabIndex = 1;
            this.addButton.TabStop = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addNote_Click);
            this.addButton.Enter += new System.EventHandler(this.addButton_Enter);
            this.addButton.Leave += new System.EventHandler(this.addButton_Leave);
            this.addButton.MouseEnter += new System.EventHandler(this.addButton_Enter);
            this.addButton.MouseLeave += new System.EventHandler(this.addButton_Leave);
            // 
            // hideButton
            // 
            this.hideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Image = global::Desktop_Notes.Properties.Resources.hide_gray;
            this.hideButton.Location = new System.Drawing.Point(145, 1);
            this.hideButton.Margin = new System.Windows.Forms.Padding(1);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(28, 25);
            this.hideButton.TabIndex = 2;
            this.hideButton.TabStop = false;
            this.hideButton.UseVisualStyleBackColor = false;
            this.hideButton.Click += new System.EventHandler(this.hideNote_Click);
            this.hideButton.Enter += new System.EventHandler(this.hideButton_Enter);
            this.hideButton.Leave += new System.EventHandler(this.hideButton_Leave);
            this.hideButton.MouseEnter += new System.EventHandler(this.hideButton_Enter);
            this.hideButton.MouseLeave += new System.EventHandler(this.hideButton_Leave);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = global::Desktop_Notes.Properties.Resources.delete_gray;
            this.deleteButton.Location = new System.Drawing.Point(175, 1);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(1);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(28, 25);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.TabStop = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteNote_Click);
            this.deleteButton.Enter += new System.EventHandler(this.deleteButton_Enter);
            this.deleteButton.Leave += new System.EventHandler(this.deleteButton_Leave);
            this.deleteButton.MouseEnter += new System.EventHandler(this.deleteButton_Enter);
            this.deleteButton.MouseLeave += new System.EventHandler(this.deleteButton_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(204, 264);
            this.ControlBox = false;
            this.Controls.Add(this.sureDialog);
            this.Controls.Add(this.notebox1);
            this.Controls.Add(this.TopBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.LocationChanged += new System.EventHandler(this.property_Changed);
            this.SizeChanged += new System.EventHandler(this.property_Changed);
            this.VisibleChanged += new System.EventHandler(this.property_Changed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.sureDialog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem; 
        private System.Windows.Forms.ToolStripMenuItem deleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        public System.Windows.Forms.RichTextBox notebox1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip themeContext;
        private System.Windows.Forms.ToolStripMenuItem hideNoteToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TopBar;
        private System.Windows.Forms.CustomButton addButton;
        private System.Windows.Forms.CustomButton hideButton;
        private System.Windows.Forms.CustomButton deleteButton;
        private System.Windows.Forms.TextBox titlebar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel sureDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.ToolStripMenuItem stayOnTopToolStripMenuItem;

    }
}

