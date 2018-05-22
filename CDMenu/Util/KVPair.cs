using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMenu.Util
{
    public class KVPair
    {
        public String KEY;
        public String VAL;

        public KVPair(String Key, String Val)
        {
            this.KEY = Key;
            this.VAL = Val;
        }

        public Boolean Equals(KVPair KeyValuePair)
        {
            if (KeyValuePair.KEY.Equals(this.KEY) && KeyValuePair.VAL.Equals(this.VAL))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Equals(String Key, String Val)
        {
            if (Key.Equals(this.KEY) && Val.Equals(this.VAL))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String ToString()
        {
            return KEY + " = " + VAL;
        }
    }
}
