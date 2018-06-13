using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMenu
{
    public class MenuItem
    {
        public Util.KVList ATTRIBS = new Util.KVList();

        public String CALLNO { get; set; }
        public String PRIMARY_TITLE { get; set; }
        public String SECONDARY_TITLE { get; set; }
        public String LAUNCH_PATH { get; set; }
        public String IMAGE_PATH { get; set; }
        public String REQUIRED { get; set; }
        public String DESCRIPTION { get; set; }

        public Boolean IsBackLink { get; set; }

        public MenuItem()
        {
        }

        /// <summary>
        /// Would check if this MenuItem's respective media is mounted.
        /// Needs some way to identify the disk (name, etc)
        /// </summary>
        /// <returns></returns>
        public Boolean IsMounted()
        {
            //TODO NOT IMPLEMENTED
            return false;
        }

        public MenuItem(String CALLNO, String PRIMARY_TITLE, String SECONDARY_TITLE, String PATH, Boolean REQUIRED, String DESCRIPTION)
        {
            //todo remove, read as JSON instead
            ATTRIBS.Items.Add(new Util.KVPair("CALLNO", CALLNO));
            ATTRIBS.Items.Add(new Util.KVPair("PRIMARY_TITLE", PRIMARY_TITLE));
            ATTRIBS.Items.Add(new Util.KVPair("SECONDARY_TITLE", SECONDARY_TITLE));
            ATTRIBS.Items.Add(new Util.KVPair("PATH", PATH));
            ATTRIBS.Items.Add(new Util.KVPair("REQUIRED", REQUIRED.ToString()));
            ATTRIBS.Items.Add(new Util.KVPair("DESCRIPTION", DESCRIPTION));
            
        }

        public Boolean IsMenu()
        {
            if (this.ATTRIBS.GetValue("PATH").Contains(".menu"))
            {
                return true;
            }
            return false;
        }

        override public String ToString()
        {
            String buffer = "\t";

            if (this.IsMenu() == true && this.IsBackLink == false)
            {
                buffer = '>' + buffer;
            }
            else if (this.IsMenu() == true && this.IsBackLink == true)
            {
                buffer = '<' + buffer;
            }

            if (this.ATTRIBS.GetValue("CALLNO").Trim().Equals(""))
            {
                buffer = buffer + String.Format("{0}", ATTRIBS.GetValue("PRIMARY_TITLE"));
            }
            else
            {
                buffer = buffer + String.Format("{0} - {1}", ATTRIBS.GetValue("CALLNO"), ATTRIBS.GetValue("PRIMARY_TITLE"));
            }

            return buffer;
        }

        public String ToAttribString()
        {
            String buffer = "";
            foreach (Util.KVPair x in ATTRIBS.Items)
            {
                buffer = buffer + x.ToString() + '\n';
            }

            return buffer;
        }

        public String ToInfoString()
        {
            return String.Format("CALLNO= {0}\nPRIMARY_TITLE= {1}\nSECONDARY_TITLE= {2}\nPATH= {3}\nREQUIRED= {4}\nDESCRIPTION= {5}\n", ATTRIBS.GetValue("CALLNO"), ATTRIBS.GetValue("PRIMARY_TITLE"), ATTRIBS.GetValue("SECONDARY_TITLE"), ATTRIBS.GetValue("PATH"), ATTRIBS.GetValue("REQUIRED"), ATTRIBS.GetValue("DESCRIPTION"));
        }

        public String ToMenuItemString()
        {
            return String.Format("[ {0} ] - {1}", ATTRIBS.GetValue("CALLNO"), ATTRIBS.GetValue("PRIMARY_TITLE"));
        }

        /// <summary>
        /// Returns RTF-formatted representation of this MenuItem.
        /// </summary>
        /// <returns></returns>
        /*
        public String ToDescriptionString()
        {
            if (this.IsBackLink)
            {
                return "";
            }

            String REQUIRED = "";
            if (ATTRIBS.GetValue("REQUIRED").Equals("TRUE"))
            {
                REQUIRED = "REQUIRES DISK";
            }

            //http://stackoverflow.com/questions/4077582/format-text-in-rich-text-box
            String buffer = @"{\rtf\pc{\colortbl;\red0\green0\blue0;\red0\green149\blue255;\red255\green0\blue0;}\cf2 \b " + CALLNO + @" \b0 \cf1 \line " + @PRIMARY_TITLE + @" \fs24 \line \i " + SECONDARY_TITLE + @" \i0 \line \line " + DESCRIPTION + @" \fs32 \cf3 \line \line " + REQUIRED;
            //http://stackoverflow.com/questions/7247644/c-sharp-japanese-characters-with-unicode-encoding
            //buffer = HttpUtility.UrlEncode(buffer);
            return buffer;

        }
        */
        public String ToFileFormat()
        {
            return null;
        }
    }
}
