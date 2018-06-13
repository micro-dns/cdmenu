using CDMenu.Util;
using Newtonsoft.Json;
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
        public static String SETTINGS_PATH = @"settings.json";

        public static Settings SETTINGS;
        //PROGRAM CONSTANTS
        //public static String CONTENT_DIR = @""; //folder containing content - KR, CN, JP, EA (Korean, Chinese, Japanese, East Asia)
        //public static String MENU_DIR = @"menus"; //folder containing menus

        //TODO NOT IMPLEMENTED
        //public static Util.KVList prefs = new Util.KVList();
        //(this would store values from a loaded preference file)

        /// <summary>
        /// Starting point of CDMENU
        /// </summary>
        [STAThread]
        static void Main()
        {
            //startup_message_buffer
            List<String> startupmsg = new List<String>();

            String SettingsFilePath = Path.GetFullPath(SETTINGS_PATH);
            if (File.Exists(SettingsFilePath))
            {
                //load settings
                SETTINGS = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SettingsFilePath));
            } else
            {
                //create new settings file with defaults
                SETTINGS = new Settings();
                SETTINGS.WORKING_DIR = Path.GetFullPath(".");

                string output = JsonConvert.SerializeObject(SETTINGS, Formatting.Indented);
                File.WriteAllText(SettingsFilePath, output);

                startupmsg.Add("No settings file was found, so a default settings.json file was created at \"" + SettingsFilePath + "\".");
            }

            String MenuFilePath = Path.GetFullPath(SETTINGS.MAIN_MENU_FILE);
            if (File.Exists(MenuFilePath))
            {

            } else
            {
                String cdmenu_menu_path = SETTINGS.WORKING_DIR + "\\" + "menu.menu";
                String cdmenu_dns_path = SETTINGS.WORKING_DIR + "\\" + "menu.dns";

                //this will deal with cdmenu formats v1 and v2 and convert them to json
                if (File.Exists(cdmenu_menu_path))
                {
                    Console.WriteLine(".menu file found. Crawling and converting");
                    //crawl .menu files
                } else if (File.Exists(cdmenu_dns_path))
                {
                    Console.WriteLine(".dns file found. Crawling and converting");
                    //crawl .dns files
                }

                startupmsg.Add("No main menu file was found, so a default menu.json file was created at \"PATH\". Be sure to add items to CDMenu!");
            }

            if (!startupmsg.Equals(""))
            {
                SubForms.Message message = new SubForms.Message("INFO", String.Join("\n\n", startupmsg.ToArray()));
                message.ShowDialog();
            }

            //todo uncomment
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

            /*
            if (File.Exists(WORKING_DIR + @"\" + MAIN_MENU_FILE))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            else
            {
                //new settings
                //create settings.json
                //run program

                SubForms.Message message = new SubForms.Message("ERROR", "Could not find the main menu file!\n");
                message.ShowDialog();
            }*/

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CDMenuWindow());
        }
    }
}
