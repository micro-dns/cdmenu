using System;

namespace CDMenu
{   
    /// <summary>
    /// Notes: filePreview: Redacted - set to not visible.
    /// </summary>
    partial class CDMenuWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (_components != null))
            {
                _components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDMenuWindow));
            this.options_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemList = new System.Windows.Forms.ListBox();
            this.ItemPath = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TitleDecor = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Label();
            this.minimize_button = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Description_NEEDS_MEDIA = new System.Windows.Forms.Label();
            this.Description_DESCRIPTION = new System.Windows.Forms.Label();
            this.Description_SECONDARY_TITLE = new System.Windows.Forms.Label();
            this.Description_PRIMARY_TITLE = new System.Windows.Forms.Label();
            this.Description_CALLNO = new System.Windows.Forms.Label();
            this.options_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // options_menu
            // 
            this.options_menu.AutoSize = false;
            this.options_menu.BackColor = System.Drawing.Color.LightGray;
            this.options_menu.Dock = System.Windows.Forms.DockStyle.None;
            this.options_menu.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.options_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.OpenMenuToolStripMenuItem});
            this.options_menu.Location = new System.Drawing.Point(0, 73);
            this.options_menu.Name = "options_menu";
            this.options_menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.options_menu.Size = new System.Drawing.Size(903, 46);
            this.options_menu.TabIndex = 0;
            this.options_menu.Text = "menuStrip1";
            this.options_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.options_menu_MouseDown);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(95, 42);
            this.fileToolStripMenuItem.Text = "CDMENU";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(230, 28);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Visible = false;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(80, 42);
            this.aboutToolStripMenuItem.Text = "ABOUT";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OpenMenuToolStripMenuItem
            // 
            this.OpenMenuToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.OpenMenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OpenMenuToolStripMenuItem.Name = "OpenMenuToolStripMenuItem";
            this.OpenMenuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.OpenMenuToolStripMenuItem.Size = new System.Drawing.Size(123, 42);
            this.OpenMenuToolStripMenuItem.Text = "OPEN MENU";
            this.OpenMenuToolStripMenuItem.Visible = false;
            this.OpenMenuToolStripMenuItem.Click += new System.EventHandler(this.OpenMenuToolStripMenuItem_Click);
            // 
            // MenuItemList
            // 
            this.MenuItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuItemList.DisplayMember = "MenuName";
            this.MenuItemList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuItemList.ForeColor = System.Drawing.Color.DimGray;
            this.MenuItemList.FormattingEnabled = true;
            this.MenuItemList.HorizontalScrollbar = true;
            this.MenuItemList.ItemHeight = 24;
            this.MenuItemList.Location = new System.Drawing.Point(16, 122);
            this.MenuItemList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuItemList.Name = "MenuItemList";
            this.MenuItemList.Size = new System.Drawing.Size(817, 600);
            this.MenuItemList.TabIndex = 1;
            this.MenuItemList.ValueMember = "MenuPath";
            this.MenuItemList.SelectedIndexChanged += new System.EventHandler(this.MenuItemList_SelectedIndexChanged);
            this.MenuItemList.DoubleClick += new System.EventHandler(this.MenuItemList_MouseDoubleClick);
            this.MenuItemList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MenuItemList_KeyPress);
            // 
            // ItemPath
            // 
            this.ItemPath.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ItemPath.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPath.Location = new System.Drawing.Point(16, 746);
            this.ItemPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemPath.MinimumSize = new System.Drawing.Size(667, 2);
            this.ItemPath.Name = "ItemPath";
            this.ItemPath.Size = new System.Drawing.Size(1291, 25);
            this.ItemPath.TabIndex = 3;
            this.ItemPath.Text = "Item Path";
            this.ItemPath.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemPath_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TitleDecor
            // 
            this.TitleDecor.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleDecor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TitleDecor.Location = new System.Drawing.Point(-1, 11);
            this.TitleDecor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleDecor.Name = "TitleDecor";
            this.TitleDecor.Size = new System.Drawing.Size(561, 87);
            this.TitleDecor.TabIndex = 4;
            this.TitleDecor.Text = "CDMENU";
            this.TitleDecor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleDecor_MouseDown);
            // 
            // exit_button
            // 
            this.exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.exit_button.Location = new System.Drawing.Point(1276, -4);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(49, 50);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "x";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exit_button_MouseDown);
            this.exit_button.MouseEnter += new System.EventHandler(this.exit_button_MouseEnter);
            this.exit_button.MouseLeave += new System.EventHandler(this.exit_button_MouseLeave);
            this.exit_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exit_button_MouseUp);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.Transparent;
            this.minimize_button.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.minimize_button.Location = new System.Drawing.Point(1236, -20);
            this.minimize_button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(45, 66);
            this.minimize_button.TabIndex = 6;
            this.minimize_button.Text = "-";
            this.minimize_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize_button.Click += new System.EventHandler(this.minimize_button_Click);
            this.minimize_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimize_button_MouseDown);
            this.minimize_button.MouseEnter += new System.EventHandler(this.minimize_button_MouseEnter);
            this.minimize_button.MouseLeave += new System.EventHandler(this.minimize_button_MouseLeave);
            this.minimize_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minimize_button_MouseUp);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Description_NEEDS_MEDIA);
            this.panel1.Controls.Add(this.Description_DESCRIPTION);
            this.panel1.Controls.Add(this.Description_SECONDARY_TITLE);
            this.panel1.Controls.Add(this.Description_PRIMARY_TITLE);
            this.panel1.Controls.Add(this.Description_CALLNO);
            this.panel1.Location = new System.Drawing.Point(841, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 600);
            this.panel1.TabIndex = 7;
            // 
            // Description_NEEDS_MEDIA
            // 
            this.Description_NEEDS_MEDIA.AutoSize = true;
            this.Description_NEEDS_MEDIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_NEEDS_MEDIA.ForeColor = System.Drawing.Color.Red;
            this.Description_NEEDS_MEDIA.Location = new System.Drawing.Point(7, 553);
            this.Description_NEEDS_MEDIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_NEEDS_MEDIA.MaximumSize = new System.Drawing.Size(460, 615);
            this.Description_NEEDS_MEDIA.Name = "Description_NEEDS_MEDIA";
            this.Description_NEEDS_MEDIA.Size = new System.Drawing.Size(121, 25);
            this.Description_NEEDS_MEDIA.TabIndex = 4;
            this.Description_NEEDS_MEDIA.Text = "REQUIRED";
            // 
            // Description_DESCRIPTION
            // 
            this.Description_DESCRIPTION.AutoSize = true;
            this.Description_DESCRIPTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_DESCRIPTION.ForeColor = System.Drawing.Color.Black;
            this.Description_DESCRIPTION.Location = new System.Drawing.Point(7, 176);
            this.Description_DESCRIPTION.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_DESCRIPTION.MaximumSize = new System.Drawing.Size(460, 615);
            this.Description_DESCRIPTION.Name = "Description_DESCRIPTION";
            this.Description_DESCRIPTION.Size = new System.Drawing.Size(135, 24);
            this.Description_DESCRIPTION.TabIndex = 3;
            this.Description_DESCRIPTION.Text = "DESCRIPTION";
            // 
            // Description_SECONDARY_TITLE
            // 
            this.Description_SECONDARY_TITLE.AutoSize = true;
            this.Description_SECONDARY_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_SECONDARY_TITLE.ForeColor = System.Drawing.Color.Black;
            this.Description_SECONDARY_TITLE.Location = new System.Drawing.Point(5, 117);
            this.Description_SECONDARY_TITLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_SECONDARY_TITLE.MaximumSize = new System.Drawing.Size(460, 615);
            this.Description_SECONDARY_TITLE.Name = "Description_SECONDARY_TITLE";
            this.Description_SECONDARY_TITLE.Size = new System.Drawing.Size(204, 25);
            this.Description_SECONDARY_TITLE.TabIndex = 2;
            this.Description_SECONDARY_TITLE.Text = "SECONDARY_TITLE";
            // 
            // Description_PRIMARY_TITLE
            // 
            this.Description_PRIMARY_TITLE.AutoSize = true;
            this.Description_PRIMARY_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_PRIMARY_TITLE.ForeColor = System.Drawing.Color.Black;
            this.Description_PRIMARY_TITLE.Location = new System.Drawing.Point(5, 41);
            this.Description_PRIMARY_TITLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_PRIMARY_TITLE.MaximumSize = new System.Drawing.Size(460, 615);
            this.Description_PRIMARY_TITLE.Name = "Description_PRIMARY_TITLE";
            this.Description_PRIMARY_TITLE.Size = new System.Drawing.Size(251, 36);
            this.Description_PRIMARY_TITLE.TabIndex = 1;
            this.Description_PRIMARY_TITLE.Text = "PRIMARY_TITLE";
            // 
            // Description_CALLNO
            // 
            this.Description_CALLNO.AutoSize = true;
            this.Description_CALLNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_CALLNO.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Description_CALLNO.Location = new System.Drawing.Point(5, 5);
            this.Description_CALLNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_CALLNO.MaximumSize = new System.Drawing.Size(460, 615);
            this.Description_CALLNO.Name = "Description_CALLNO";
            this.Description_CALLNO.Size = new System.Drawing.Size(141, 36);
            this.Description_CALLNO.TabIndex = 0;
            this.Description_CALLNO.Text = "CALLNO";
            // 
            // CDMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1323, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimize_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.ItemPath);
            this.Controls.Add(this.MenuItemList);
            this.Controls.Add(this.options_menu);
            this.Controls.Add(this.TitleDecor);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.options_menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CDMenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CDMenuWindow_MouseDown);
            this.options_menu.ResumeLayout(false);
            this.options_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip options_menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox MenuItemList;
        private System.Windows.Forms.Label ItemPath;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Label TitleDecor;
        private System.Windows.Forms.Label exit_button;
        private System.Windows.Forms.Label minimize_button;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Description_CALLNO;
        private System.Windows.Forms.Label Description_NEEDS_MEDIA;
        private System.Windows.Forms.Label Description_DESCRIPTION;
        private System.Windows.Forms.Label Description_SECONDARY_TITLE;
        private System.Windows.Forms.Label Description_PRIMARY_TITLE;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

