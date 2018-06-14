namespace CDMenu.SubForms
{
    partial class ItemManager
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
            this.MenuItemTreeView = new System.Windows.Forms.TreeView();
            this.MenuItemContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSubItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OKButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PrimaryTitleTextBox = new System.Windows.Forms.TextBox();
            this.SecondaryTitleTextBox = new System.Windows.Forms.TextBox();
            this.PrimaryTitleLabel = new System.Windows.Forms.Label();
            this.SecondaryTitleLabel = new System.Windows.Forms.Label();
            this.CallNumberLabel = new System.Windows.Forms.Label();
            this.CallNumberTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.MetaGroupBox = new System.Windows.Forms.GroupBox();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.LaunchPathLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.ImageBrowseButton = new System.Windows.Forms.Button();
            this.LaunchPathBrowseButton = new System.Windows.Forms.Button();
            this.ImageTextBox = new System.Windows.Forms.TextBox();
            this.LaunchPathTextBox = new System.Windows.Forms.TextBox();
            this.MediaRequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddSubitemButton = new System.Windows.Forms.Button();
            this.MenuItemContextMenuStrip.SuspendLayout();
            this.MetaGroupBox.SuspendLayout();
            this.FileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuItemTreeView
            // 
            this.MenuItemTreeView.ContextMenuStrip = this.MenuItemContextMenuStrip;
            this.MenuItemTreeView.Location = new System.Drawing.Point(10, 11);
            this.MenuItemTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.MenuItemTreeView.Name = "MenuItemTreeView";
            this.MenuItemTreeView.Size = new System.Drawing.Size(272, 402);
            this.MenuItemTreeView.TabIndex = 0;
            this.MenuItemTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MenuItemTreeView_AfterSelect);
            this.MenuItemTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MenuItemTreeView_NodeMouseClick);
            this.MenuItemTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItemTreeView_MouseDown);
            // 
            // MenuItemContextMenuStrip
            // 
            this.MenuItemContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem,
            this.addSubItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem});
            this.MenuItemContextMenuStrip.Name = "MenuItemContextMenuStrip";
            this.MenuItemContextMenuStrip.Size = new System.Drawing.Size(147, 70);
            // 
            // addSubItemToolStripMenuItem
            // 
            this.addSubItemToolStripMenuItem.Name = "addSubItemToolStripMenuItem";
            this.addSubItemToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addSubItemToolStripMenuItem.Text = "Add Sub Item";
            this.addSubItemToolStripMenuItem.Click += new System.EventHandler(this.addSubItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deleteItemToolStripMenuItem.Text = "Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(498, 419);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(579, 419);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(660, 419);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PrimaryTitleTextBox
            // 
            this.PrimaryTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimaryTitleTextBox.Location = new System.Drawing.Point(123, 49);
            this.PrimaryTitleTextBox.Name = "PrimaryTitleTextBox";
            this.PrimaryTitleTextBox.Size = new System.Drawing.Size(301, 24);
            this.PrimaryTitleTextBox.TabIndex = 1;
            this.PrimaryTitleTextBox.TextChanged += new System.EventHandler(this.PrimaryTitleTextBox_TextChanged);
            // 
            // SecondaryTitleTextBox
            // 
            this.SecondaryTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondaryTitleTextBox.Location = new System.Drawing.Point(123, 79);
            this.SecondaryTitleTextBox.Name = "SecondaryTitleTextBox";
            this.SecondaryTitleTextBox.Size = new System.Drawing.Size(301, 24);
            this.SecondaryTitleTextBox.TabIndex = 2;
            // 
            // PrimaryTitleLabel
            // 
            this.PrimaryTitleLabel.AutoSize = true;
            this.PrimaryTitleLabel.Location = new System.Drawing.Point(53, 56);
            this.PrimaryTitleLabel.Name = "PrimaryTitleLabel";
            this.PrimaryTitleLabel.Size = new System.Drawing.Size(64, 13);
            this.PrimaryTitleLabel.TabIndex = 6;
            this.PrimaryTitleLabel.Text = "Primary Title";
            this.PrimaryTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SecondaryTitleLabel
            // 
            this.SecondaryTitleLabel.AutoSize = true;
            this.SecondaryTitleLabel.Location = new System.Drawing.Point(36, 86);
            this.SecondaryTitleLabel.Name = "SecondaryTitleLabel";
            this.SecondaryTitleLabel.Size = new System.Drawing.Size(81, 13);
            this.SecondaryTitleLabel.TabIndex = 7;
            this.SecondaryTitleLabel.Text = "Secondary Title";
            this.SecondaryTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CallNumberLabel
            // 
            this.CallNumberLabel.AutoSize = true;
            this.CallNumberLabel.Location = new System.Drawing.Point(53, 26);
            this.CallNumberLabel.Name = "CallNumberLabel";
            this.CallNumberLabel.Size = new System.Drawing.Size(64, 13);
            this.CallNumberLabel.TabIndex = 9;
            this.CallNumberLabel.Text = "Call Number";
            this.CallNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CallNumberTextBox
            // 
            this.CallNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CallNumberTextBox.Location = new System.Drawing.Point(123, 19);
            this.CallNumberTextBox.Name = "CallNumberTextBox";
            this.CallNumberTextBox.Size = new System.Drawing.Size(152, 24);
            this.CallNumberTextBox.TabIndex = 0;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(57, 112);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Description";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(123, 109);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(301, 167);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // MetaGroupBox
            // 
            this.MetaGroupBox.Controls.Add(this.CallNumberTextBox);
            this.MetaGroupBox.Controls.Add(this.PrimaryTitleTextBox);
            this.MetaGroupBox.Controls.Add(this.DescriptionLabel);
            this.MetaGroupBox.Controls.Add(this.SecondaryTitleTextBox);
            this.MetaGroupBox.Controls.Add(this.DescriptionTextBox);
            this.MetaGroupBox.Controls.Add(this.PrimaryTitleLabel);
            this.MetaGroupBox.Controls.Add(this.CallNumberLabel);
            this.MetaGroupBox.Controls.Add(this.SecondaryTitleLabel);
            this.MetaGroupBox.Location = new System.Drawing.Point(298, 12);
            this.MetaGroupBox.Name = "MetaGroupBox";
            this.MetaGroupBox.Size = new System.Drawing.Size(437, 294);
            this.MetaGroupBox.TabIndex = 13;
            this.MetaGroupBox.TabStop = false;
            this.MetaGroupBox.Text = "Meta";
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Controls.Add(this.LaunchPathLabel);
            this.FileGroupBox.Controls.Add(this.ImageLabel);
            this.FileGroupBox.Controls.Add(this.ImageBrowseButton);
            this.FileGroupBox.Controls.Add(this.LaunchPathBrowseButton);
            this.FileGroupBox.Controls.Add(this.ImageTextBox);
            this.FileGroupBox.Controls.Add(this.LaunchPathTextBox);
            this.FileGroupBox.Controls.Add(this.MediaRequiredCheckBox);
            this.FileGroupBox.Location = new System.Drawing.Point(298, 313);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(437, 100);
            this.FileGroupBox.TabIndex = 14;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "File";
            // 
            // LaunchPathLabel
            // 
            this.LaunchPathLabel.AutoSize = true;
            this.LaunchPathLabel.Location = new System.Drawing.Point(49, 23);
            this.LaunchPathLabel.Name = "LaunchPathLabel";
            this.LaunchPathLabel.Size = new System.Drawing.Size(68, 13);
            this.LaunchPathLabel.TabIndex = 13;
            this.LaunchPathLabel.Text = "Launch Path";
            this.LaunchPathLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(81, 49);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(36, 13);
            this.ImageLabel.TabIndex = 12;
            this.ImageLabel.Text = "Image";
            this.ImageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ImageBrowseButton
            // 
            this.ImageBrowseButton.Location = new System.Drawing.Point(381, 46);
            this.ImageBrowseButton.Name = "ImageBrowseButton";
            this.ImageBrowseButton.Size = new System.Drawing.Size(50, 20);
            this.ImageBrowseButton.TabIndex = 3;
            this.ImageBrowseButton.Text = "...";
            this.ImageBrowseButton.UseVisualStyleBackColor = true;
            this.ImageBrowseButton.Click += new System.EventHandler(this.ImageBrowseButton_Click);
            // 
            // LaunchPathBrowseButton
            // 
            this.LaunchPathBrowseButton.Location = new System.Drawing.Point(381, 20);
            this.LaunchPathBrowseButton.Name = "LaunchPathBrowseButton";
            this.LaunchPathBrowseButton.Size = new System.Drawing.Size(50, 20);
            this.LaunchPathBrowseButton.TabIndex = 1;
            this.LaunchPathBrowseButton.Text = "...";
            this.LaunchPathBrowseButton.UseVisualStyleBackColor = true;
            this.LaunchPathBrowseButton.Click += new System.EventHandler(this.LaunchPathBrowseButton_Click);
            // 
            // ImageTextBox
            // 
            this.ImageTextBox.Location = new System.Drawing.Point(123, 46);
            this.ImageTextBox.Name = "ImageTextBox";
            this.ImageTextBox.Size = new System.Drawing.Size(252, 20);
            this.ImageTextBox.TabIndex = 2;
            // 
            // LaunchPathTextBox
            // 
            this.LaunchPathTextBox.Location = new System.Drawing.Point(123, 20);
            this.LaunchPathTextBox.Name = "LaunchPathTextBox";
            this.LaunchPathTextBox.Size = new System.Drawing.Size(252, 20);
            this.LaunchPathTextBox.TabIndex = 0;
            // 
            // MediaRequiredCheckBox
            // 
            this.MediaRequiredCheckBox.AutoSize = true;
            this.MediaRequiredCheckBox.Location = new System.Drawing.Point(36, 73);
            this.MediaRequiredCheckBox.Name = "MediaRequiredCheckBox";
            this.MediaRequiredCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MediaRequiredCheckBox.Size = new System.Drawing.Size(101, 17);
            this.MediaRequiredCheckBox.TabIndex = 4;
            this.MediaRequiredCheckBox.Text = "Media Required";
            this.MediaRequiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(10, 419);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(99, 23);
            this.AddItemButton.TabIndex = 15;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(220, 419);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(62, 23);
            this.RemoveButton.TabIndex = 16;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddSubitemButton
            // 
            this.AddSubitemButton.Location = new System.Drawing.Point(115, 419);
            this.AddSubitemButton.Name = "AddSubitemButton";
            this.AddSubitemButton.Size = new System.Drawing.Size(99, 23);
            this.AddSubitemButton.TabIndex = 17;
            this.AddSubitemButton.Text = "Add Subitem";
            this.AddSubitemButton.UseVisualStyleBackColor = true;
            this.AddSubitemButton.Click += new System.EventHandler(this.AddSubitemButton_Click);
            // 
            // ItemManager
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 451);
            this.Controls.Add(this.AddSubitemButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.FileGroupBox);
            this.Controls.Add(this.MetaGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MenuItemTreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDMenu - Item Manager";
            this.MenuItemContextMenuStrip.ResumeLayout(false);
            this.MetaGroupBox.ResumeLayout(false);
            this.MetaGroupBox.PerformLayout();
            this.FileGroupBox.ResumeLayout(false);
            this.FileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView MenuItemTreeView;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PrimaryTitleTextBox;
        private System.Windows.Forms.TextBox SecondaryTitleTextBox;
        private System.Windows.Forms.Label PrimaryTitleLabel;
        private System.Windows.Forms.Label SecondaryTitleLabel;
        private System.Windows.Forms.Label CallNumberLabel;
        private System.Windows.Forms.TextBox CallNumberTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.GroupBox MetaGroupBox;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.CheckBox MediaRequiredCheckBox;
        private System.Windows.Forms.Label LaunchPathLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button ImageBrowseButton;
        private System.Windows.Forms.Button LaunchPathBrowseButton;
        private System.Windows.Forms.TextBox ImageTextBox;
        private System.Windows.Forms.TextBox LaunchPathTextBox;
        private System.Windows.Forms.ContextMenuStrip MenuItemContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addSubItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddSubitemButton;
    }
}