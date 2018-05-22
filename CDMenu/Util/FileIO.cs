using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMenu.Util
{
    class FileIO
    {

        public static List<MenuItem> readMENUFile(String path)
        {
            if (path == "")
            {
                SubForms.Message message = new SubForms.Message("ERROR", "readMENUFile path is empty!\n" + path);
                message.ShowDialog();

                return null;
            }
            else
            {
                
                Directory.SetCurrentDirectory(Program.WORKING_DIR);

                List<MenuItem> buffer = new List<MenuItem>();
                List<String> lineBuffer = new List<String>();
                String line;

                try
                {

                    System.IO.StreamReader myFile = new System.IO.StreamReader(path, System.Text.Encoding.Default, true);
                    while ((line = myFile.ReadLine()) != null)
                    {
                        lineBuffer.Add(line);
                    }

                    int index01 = 0;
                    while (index01 < lineBuffer.Count)
                    {
                        if (lineBuffer.ElementAt(index01).IndexOf("PARENT=") == 0)
                        {
                            MenuItem BackButton = new MenuItem();
                            BackButton.ATTRIBS.SetValue("PRIMARY_TITLE", "[ BACK ]");
                            BackButton.ATTRIBS.SetValue("PATH", retrieveString(lineBuffer, "PARENT=", index01));
                            BackButton.IsBackLink = true;

                            Console.WriteLine(BackButton.ToInfoString());
                            buffer.Add(BackButton);
                        }

                        index01++;
                    }

                    int index02 = 0;
                    while (index02 < lineBuffer.Count)
                    {
                        if (lineBuffer.ElementAt(index02).IndexOf("CALLNO=") == 0)
                        {
                            MenuItem entry = new MenuItem();


                            while (index02 < lineBuffer.Count && !lineBuffer.ElementAt(index02).Trim().Equals(""))
                            {
                                String key = lineBuffer.ElementAt(index02).Split('=')[0].Trim();
                                String val = lineBuffer.ElementAt(index02).Split('=')[1].Trim();

                                entry.ATTRIBS.Add(key, val);

                                index02++;
                            }
                            //Console.WriteLine(entry.ToAttribString());

                            buffer.Add(entry);
                        }

                        index02++;
                    }

                    myFile.Close();
                }
                catch (System.IO.DirectoryNotFoundException)
                {
                    SubForms.Message message = new SubForms.Message("ERROR", "CDMenu directory not found!\n" + path);
                    message.ShowDialog();
                }
                catch (System.IO.FileNotFoundException)
                {
                    SubForms.Message message = new SubForms.Message("ERROR", "CDMenu .menu file not found!\n" + path);
                    message.ShowDialog();
                }
                return buffer;
            }
            
        }

        public void writeMENUFile (String Path, List<MenuItem> MenuItems)
        {
            //TODO NOT IMPLEMENTED
        }

        /// <summary>
        /// 
        /// Extracts a .menu file formatted String value.
        /// 
        /// </summary>
        /// <param name="lineBuffer"></param>
        /// <param name="tag"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static String retrieveString(List<String> lineBuffer, String tag, int index)
        {
            return lineBuffer.ElementAt(index).Substring(lineBuffer.ElementAt(index).IndexOf(tag) + tag.Length).Trim();
        }

        /// <summary>
        /// 
        /// Extracts a .menu file formatted Boolean value.
        /// 
        /// https://msdn.microsoft.com/en-us/library/system.boolean.tryparse(v=vs.110).aspx
        /// </summary>
        /// <param name="lineBuffer"></param>
        /// <param name="tag"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static Boolean retrieveBoolean(List<String> lineBuffer, String tag, int index)
        {
            String buffer = lineBuffer.ElementAt(index).Substring(lineBuffer.ElementAt(index).IndexOf(tag) + tag.Length).Trim();

            bool flag;
            if (Boolean.TryParse(buffer, out flag))
            {
                return flag;
            }
            return false;
        }

        private static Boolean convertBoolean(String input)
        {
            String buffer = input.Trim();

            bool flag;
            if (Boolean.TryParse(buffer, out flag))
            {
                return flag;
            }
            return false;
        }

        public static Boolean IsMenu(String path)
        {
            if (path.Contains(".menu"))
            {
                return true;
            }
            return false;
        }

        public static Boolean IsMainMenu(String path)
        {
            if (path.Equals("menu.menu"))
            {
                return true;
            }
            else if (path.Substring(path.LastIndexOf('\\') + 1).Equals("menu.menu"))
            {
                return true;
            }
            return false;
        }
    }
}
