using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHash
{
   class MyDictionary
    {
        private static int capacity = 100000;
        private Pair_KeyValue[] table;

       
        public MyDictionary()
        {
            table = new Pair_KeyValue[capacity];
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public Pair_KeyValue Table(int i)
        {
            return table[i];
        }

        public  bool Add(string key, string value)
        {
            if (DataIsCorrect(key, value))
            {
                Pair_KeyValue note = new Pair_KeyValue(key, value);
                int index = Hash(key);
                table[index] = note;
                return true;
            }
             return false;
        }

        public string Choose(string key)
        {
            if (KeyExist(key))
            {
                int index = Hash(key);
                return table[index].Value;
            }

            else return null;
        }
        
        public void Delete(string key)
        {
           if (KeyExist(key)) table[Hash(key)] = null;  
        }

        private int Hash(string key)
        {
             return (Math.Abs(key.GetHashCode() / 100000));
        }

        private bool KeyExist(string key)
        {
            if (key != "")
            {
                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i] != null)
                    {
                        if (key == table[i].Key) return true;
                    }
                }
            }
            return false;

        }

        private bool DataIsCorrect(string key, string value)
        {
            if (key == "" || value == "") return false;

            string keyDublicate = (string)key.Clone();
            while (keyDublicate.Contains(" "))
            {
                keyDublicate = keyDublicate.Remove(keyDublicate.IndexOf(" "));
            }
            if (keyDublicate.Length == 0) return false;
            else
            {
                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i] != null)
                    {
                        if (key == table[i].Key) return false;
                    }
                }

                return true;
            }


        }

    }
}
