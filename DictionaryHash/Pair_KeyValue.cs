using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHash
{
    class Pair_KeyValue
    {
        private  string key;
        private  string value;

        public Pair_KeyValue(string key, string value)
        {
            this.key = key;
            this.value = value;
        }

        public string Key
        {
            get
            {
                return key;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }
        }
    }

}
