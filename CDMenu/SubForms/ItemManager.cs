using CDMenu.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMenu.SubForms
{
    public partial class ItemManager : Form
    {
        public ItemManager()
        {
            InitializeComponent();
        }

        private void LaunchPathBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog LaunchPathOpenFileDialog = new OpenFileDialog();
            if (LaunchPathOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                LaunchPathTextBox.Text = LaunchPathOpenFileDialog.FileName;
            }
        }

        private void ImageBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImageOpenFileDialog = new OpenFileDialog();
            if (ImageOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageTextBox.Text = ImageOpenFileDialog.FileName;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //https://stackoverflow.com/questions/4784258/right-click-select-on-net-treenode
        private void MenuItemTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MenuItemTreeView.SelectedNode = e.Node;
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuItemTreeView.SelectedNode.Remove();
        }

        private void addSubItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childNode = new ItemNode();
            childNode.Text = "hello";

            MenuItemTreeView.SelectedNode.Nodes.Add(childNode);
        }
    }
}
