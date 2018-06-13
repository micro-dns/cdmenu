using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CDMenu.Util;
using System.IO;

namespace CDMenu
{

    public partial class MainWindow : Form
    {
        public String current = Program.SETTINGS.MAIN_MENU_FILE;
        public int LastMainIndex = 0;

        public int firstRun = 0; //This checks to see if this is the first run

        /// <summary>
        /// The main CDMenuWindow constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            int state = LoadMenu(Program.SETTINGS.MAIN_MENU_FILE);

            LastMainIndex = 0;
            
        }

        /// <summary>
        /// When clicking, update the menu description
        /// 
        /// DONE: Update the picture to show the item being selected. 
        ///    Distinguish between single and double-click
        ///    -Single click: REDACTED update picture REDACTED
        ///                   Update Description
        ///    -Double-click: open selected item
        ///    
        /// Would need to parse file so that populated list shows the list of menus
        /// 
        /// https://msdn.microsoft.com/en-us/library/ms171543%28v=vs.110%29.aspx (How to: Distinguish Between Clicks and Double-Clicks)
        /// http://stackoverflow.com/questions/3434154/handling-double-click-events-on-listbox-items-in-c-sharp (Used this as basis)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItemList_ShowDetails();
        }

        /// <summary>
        /// Shows the details of the menu item to that of the current index.
        /// </summary>
        private void MenuItemList_ShowDetails()
        {
            int index = MenuItemList.SelectedIndex;
            if (index != -1) //USE THIS TO CHECK TO MAKE SURE THE ITEM IS AN ITEM IN THE LIST BOX
            {
                MenuItem SelectedItem = (MenuItem)MenuItemList.SelectedItem;

                MenuItemList_ClearDetails();

                ItemPath.Text = SelectedItem.ATTRIBS.GetValue("PATH");

                if (!SelectedItem.IsBackLink)
                {
                    this.Description_CALLNO.Text = SelectedItem.ATTRIBS.GetValue("CALLNO");
                    this.Description_PRIMARY_TITLE.Text = SelectedItem.ATTRIBS.GetValue("PRIMARY_TITLE");
                    this.Description_SECONDARY_TITLE.Text = SelectedItem.ATTRIBS.GetValue("SECONDARY_TITLE");
                    this.Description_DESCRIPTION.Text = SelectedItem.ATTRIBS.GetValue("DESCRIPTION");


                    if (SelectedItem.ATTRIBS.GetValue("NEEDS_MEDIA") == "TRUE")
                    {
                        this.Description_NEEDS_MEDIA.Text = "REQUIRES DISK";
                    }
                    else
                    {
                        this.Description_NEEDS_MEDIA.Text = "";
                    }
                }
            }
        }

        private void MenuItemList_ClearDetails()
        {
            this.ItemPath.Text = "";

            this.Description_CALLNO.Text = "";
            this.Description_PRIMARY_TITLE.Text = "";
            this.Description_SECONDARY_TITLE.Text = "";
            this.Description_DESCRIPTION.Text = "";
            this.Description_NEEDS_MEDIA.Text = "";
        }

        /// <summary>
        /// Function Names: menuItems_MouseDoubleClick
        /// 
        /// Description: When clicking or pressing enter, open the file selected.
        /// 
        /// DONE: Update the picture to show the item being selected. 
        ///      Distinguish between single and double-click
        ///      -Single click: REDACTED update picture REDACTED
        ///                     Update Description
        ///      -Double-click: open selected item
        /// 
        /// https://msdn.microsoft.com/en-us/library/ms171543%28v=vs.110%29.aspx (How to: Distinguish Between Clicks and Double-Clicks - Not really used)
        /// http://stackoverflow.com/questions/3434154/handling-double-click-events-on-listbox-items-in-c-sharp (Used this as basis)
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemList_MouseDoubleClick(object sender, EventArgs e)
        {
            MenuItemList_LoadMenuItem();
        }

        /// <summary>
        /// Event Listener for keypresses in the menuItems window.
        /// 
        /// ENTER       (13) = Opens selected item.
        /// BACKSPACE   (8) = Goes to the previous menu.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //enter
            {
                MenuItemList_LoadMenuItem();
            }
            else if (e.KeyChar == (char)8) //backspace
            {
                LoadBack();
            }
        }

        /// <summary>
        /// Opens the menu item selected.
        /// </summary>
        private void MenuItemList_LoadMenuItem()
        {
            MenuItem SelectedItem = (MenuItem)MenuItemList.Items[MenuItemList.SelectedIndex];

            if (SelectedItem.IsMenu())
            {
                LoadMenu(SelectedItem.ATTRIBS.GetValue("PATH"));
            }
            else
            {
                //Opens the file using the default program associated
                try
                {
                    //TODO CHECK IF ITEM EXISTS
                    //if yes
                        //loading message
                        //open file
                    //else
                        //error message

                    System.Diagnostics.Process.Start(@SelectedItem.ATTRIBS.GetValue("PATH"));
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    this.Enabled = false;
                    SubForms.Message message = new SubForms.Message("ERROR", "Item not found!\n" + SelectedItem.ATTRIBS.GetValue("PATH"));
                    message.ShowDialog();
                    this.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Inserts menuItems into the list to display them
        /// </summary>
        /// <param name="path"></param>
        /// <returns>the number of items in this menu</returns>
        private int LoadMenu(String path)
        {
            /*Console.WriteLine(path);
            if (!File.Exists(path))
            {
                return -1;
            }
            else
            {*/
                if (Util.FileIO.IsMainMenu(current)) //if current is the main menu, set MainIndex before leaving it
                {
                    LastMainIndex = MenuItemList.SelectedIndex;
                }

                MenuItemList.Items.Clear();

                List<MenuItem> buffer = Util.FileIO.readMENUFile(path);

                foreach (MenuItem x in buffer)
                {
                    MenuItemList.Items.Add(x);
                }

                current = path;

                if (Util.FileIO.IsMainMenu(path)) //if path is main menu
                {
                    if (LastMainIndex != -1) //if a main index has been selected, reselect it
                    {
                        MenuItemList.SetSelected(LastMainIndex, true);
                    }
                    else //if a main index hasn't been selected, default to index 0
                    {
                        MenuItemList.SetSelected(0, true);
                    }
                }
                else //if path is not a main menu, default to index 1 (right after the [ BACK ] path)
                {
                    MenuItemList.SetSelected(1, true);
                }

                current = path;


                return buffer.Count;
            //}
        }

        private int LoadBack()
        {
            int size = 0;
            for (int i = 0; i < MenuItemList.Items.Count; i++)
            {
                MenuItem SelectedItem = (MenuItem)MenuItemList.Items[i];
                if (SelectedItem.IsBackLink)
                {
                    size = LoadMenu(SelectedItem.ATTRIBS.GetValue("PATH"));
                }
            }
            return size;
        }
        
        /// <summary>
        /// exitToolStripMenuItem_Click
        /// 
        /// To have the application exit upon clicking the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// aboutToolStripMenuItem_Click
        /// 
        /// To have the application show the about window for the CDMenu program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form newFrm = new About();
            newFrm.ShowDialog();
            this.Enabled = true;
        }
        
        /// <summary>
        /// Clicking CDMenu > Main Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMenu("menu.menu");
        }

        /*******START OF BUTTON EFFECTS*******/

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_button_MouseEnter(object sender, EventArgs e)
        {
            exit_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void exit_button_MouseLeave(object sender, EventArgs e)
        {
            exit_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void exit_button_MouseDown(object sender, MouseEventArgs e)
        {
            exit_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        }

        private void exit_button_MouseUp(object sender, MouseEventArgs e)
        {
            exit_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimize_button_MouseEnter(object sender, EventArgs e)
        {
            minimize_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void minimize_button_MouseLeave(object sender, EventArgs e)
        {
            minimize_button.ForeColor = System.Drawing.SystemColors.ButtonShadow;
        }

        private void minimize_button_MouseDown(object sender, MouseEventArgs e)
        {
            minimize_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        }

        private void minimize_button_MouseUp(object sender, MouseEventArgs e)
        {
            minimize_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        /// <summary>
        /// Allows this form to be moved.
        /// SOURCE: http://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void CDMenuWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Gives the form a shadow.
        /// SOURCE: http://stackoverflow.com/questions/16493698/drop-shadow-on-a-borderless-winform
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void TitleDecor_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        private void ItemPath_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        private void options_menu_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        private void OpenMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Opening .menu file");
            System.Diagnostics.Process.Start(@current);
        }
    }
}
