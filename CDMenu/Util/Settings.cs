using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMenu.Util
{
    class Settings
    {
        public String CONTENT_DIR = @""; //folder containing content - KR, CN, JP, EA (Korean, Chinese, Japanese, East Asia)
        public String MENU_DIR = @"menus"; //folder containing menus
        public String WORKING_DIR = @".";
        public String MAIN_MENU_FILE = @"menu.json";

        public Settings()
        {

        }
    }
}
