using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMenu.Util
{
    public class KVList
    {
        public List<KVPair> Items = new List<KVPair>();

        public KVList()
        {
        }

        public void Add(String Key, String Val)
        {
            Items.Add(new KVPair(Key, Val));
        }

        public void Add(KVPair KeyValuePair)
        {
            Items.Add(KeyValuePair);
        }

        public String Get(String key)
        {
            foreach (KVPair x in Items)
            {
                if (key.Equals(x.KEY))
                {
                    return x.VAL;
                }
            }
            return "";
        }

        public int Contains(String Key, String Val)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items.ElementAt(i).Equals(Key, Val))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Contains(KVPair KeyValuePair)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items.ElementAt(i).Equals(KeyValuePair))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Contains(String Key)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items.ElementAt(i).KEY.Equals(Key))
                {
                    return i;
                }
            }
            return -1;
        }

        public String GetValue(String Key)
        {
            foreach (KVPair pair in Items)
            {
                if (pair.KEY.Equals(Key))
                {
                    return pair.VAL;
                }
            }
            return "";
        }

        public void SetValue(String Key, String Val)
        {
            Boolean exists = false;
            foreach (KVPair pair in Items)
            {
                if (pair.KEY.Equals(Key))
                {
                    exists = true;
                    pair.VAL = Val;
                }
            }
            if (exists == false)
            {
                Add(Key, Val);
            }
        }

        public String ToString()
        {
            String buffer = "";

            foreach(KVPair x in Items)
            {
                buffer = buffer + x.ToString() + '\n';
            }

            return buffer;
        }
    }
}
