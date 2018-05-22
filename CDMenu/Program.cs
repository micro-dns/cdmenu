using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMenu
{
    static class Program
    {
        //PROGRAM CONSTANTS
        public static String WORKING_DIR = @"C:\Cdmenu";
        public static String MAIN_MENU_FILE = @"menu.menu";
        public static String CONTENT_DIR = @""; //folder containing content - KR, CN, JP, EA (Korean, Chinese, Japanese, East Asia)
        public static String MENU_DIR = @"menus"; //folder containing menus

        //TODO NOT IMPLEMENTED
        //public static Util.KVList prefs = new Util.KVList();
        //(this would store values from a loaded preference file)

        /// <summary>
        /// Starting point of CDMENU
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists(WORKING_DIR + @"\" + MAIN_MENU_FILE))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CDMenuWindow());
            }
            else
            {
                SubForms.Message message = new SubForms.Message("ERROR", "Could not find the main menu file!\n");
                message.ShowDialog();
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CDMenuWindow());
        }

        /// <summary>
        /// Loads preference file
        /// </summary>
        static void LoadPrefs()
        {
            if (MAIN_MENU_FILE.Equals(""))
            {
                MAIN_MENU_FILE = @"menu.menu";
            }

            if (!File.Exists(WORKING_DIR + @"\" + MAIN_MENU_FILE))
            {
                Console.WriteLine("menu file does not exist.");
            }

            //check if MAIN_MENU_FILE exists
            //if does not exist
            //  set default path
            //  create menu.menu file

            //check if CONTENT_DIR folder exists
            //if does not exist
            //  set default path
            //  create folder at path

            //check if MENU_DIR folder exists
            //if does not exist
            //  set default path
            //  create folder at path

            //TODO NOT IMPLEMENTED

        }

        /// <summary>
        /// Saves preference file
        /// </summary>
        static void SavePrefs()
        {
            //TODO NOT IMPLEMENTED
        }

        /// <summary>
        /// Checks preference file
        /// </summary>
        static void CheckPrefs()
        {
            //TODO NOT IMPLEMENTED
        }

    }
}
