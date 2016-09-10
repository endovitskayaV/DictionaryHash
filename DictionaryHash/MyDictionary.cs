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
        private Pair_KeyValue note;
       
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

        public  void Add(string key, string value)
        {
               note = new Pair_KeyValue(key, value);
               int index = Hash(key);
            
               table[index]=note;
        }

        public string Choose(string key)
        {
            int index = Hash(key);
            return table[index].Value;
        }

        
        public void Delete(string key)
        {
            bool keyExist = false;
            
                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i]!= null)
                    {
                        if (key == table[i].Key)
                           {
                                 keyExist = true;
                                 break;
                           }   
                    }

                if (keyExist) Array.Clear(table, Hash(key), 1);
            }

           
        }

        private int Hash(string key)
        {
            int foo =Math.Abs( key.GetHashCode()/100000);
            /*
            int sum = 0;
            for (int i = 0; i < key.Length; i++)
            {
                sum += key[i];
            }

            int sum2;
            if (key.Length>=2) sum2 = key[key.Length - 1]+ key[key.Length - 2]; 
            else sum2 = key[key.Length - 1];
            */

            return (foo);
        }

        public bool DataIsCorrect(string key, string value)
        {
            if (key == "" || value == "")  return false;

           
                for (int i = 0; i < table.Length; i++)
                {
                   if (table[i] != null)
                   {
                      if (key == table[i].Key) return false;
                   }
                }
            
            
            return true;
        } // !




    }
}
