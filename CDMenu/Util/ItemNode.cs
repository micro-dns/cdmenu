using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMenu.Util
{
    //https://stackoverflow.com/questions/1438198/how-to-inherit-from-the-treenode-class
    class ItemNode : TreeNode
    {
        public String CALLNO { get; set; }
        public String PRIMARY_TITLE { get; set; }
        public String SECONDARY_TITLE { get; set; }
        public String DESCRIPTION { get; set; }

        public String LAUNCH_PATH { get; set; }
        public String IMAGE_PATH { get; set; }
        public String MEDIA_REQUIRED { get; set; }

        //https://stackoverflow.com/questions/548129/what-is-the-best-way-to-store-data-on-a-treeview-node
    }
}
