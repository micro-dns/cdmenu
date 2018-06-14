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
            ItemNode n = new ItemNode();
            n.CALLNO = CallNumberTextBox.Text;
            n.PRIMARY_TITLE = PrimaryTitleTextBox.Text;
            n.SECONDARY_TITLE = SecondaryTitleTextBox.Text;
            n.DESCRIPTION = DescriptionTextBox.Text;

            MenuItemTreeView.SelectedNode = n;

            MenuItemTreeView.SelectedNode.Text = PrimaryTitleTextBox.Text;
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
            var newNode = new ItemNode();
            newNode.Text = "New Subitem";

            if (MenuItemTreeView.Nodes.Count > 0)
            {
                

                MenuItemTreeView.SelectedNode.Nodes.Add(newNode);
            } else
            {
                MenuItemTreeView.Nodes.Add(newNode);
            }
        }

        private void MenuItemTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine("Selected " + MenuItemTreeView.SelectedNode.Text);

            ItemNode n = (ItemNode) MenuItemTreeView.SelectedNode;

            CallNumberTextBox.Text = n.CALLNO;
            PrimaryTitleTextBox.Text = n.PRIMARY_TITLE;
            SecondaryTitleTextBox.Text = n.SECONDARY_TITLE;
            DescriptionTextBox.Text = n.DESCRIPTION;
        }

        private void MenuItemTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    if (MenuItemTreeView != null)
            //    {
            //        ItemNode i = (ItemNode) MenuItemTreeView.SelectedNode;
            //        i.IsSelected = false;

            //    }
            //}
        }

        private void PrimaryTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newNode = new ItemNode();
            newNode.Text = "New Item";

            MenuItemTreeView.Nodes.Add(newNode);
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var newNode = new ItemNode();
            newNode.Text = "New Item";

            MenuItemTreeView.Nodes.Add(newNode);
        }

        private void AddSubitemButton_Click(object sender, EventArgs e)
        {
            var newNode = new ItemNode();
            newNode.Text = "New Subitem";

            if (MenuItemTreeView.Nodes.Count > 0)
            {


                MenuItemTreeView.SelectedNode.Nodes.Add(newNode);
            }
            else
            {
                MenuItemTreeView.Nodes.Add(newNode);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            MenuItemTreeView.SelectedNode.Remove();
        }
    }
}
