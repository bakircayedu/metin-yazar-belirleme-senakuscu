using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazar
{
    public class Hash
    {
        public HashNode[] hashTable;
        public Hash(int size)
        {
            this.hashTable = new HashNode[size];

        }
        public void Add(int key, Word word)
        {
            HashNode add = new HashNode();
            add.Data = word;

            int index = (key % 20);
            if (hashTable[index] == null)
            {
                add.Next = null;
                hashTable[index] = add;


            }
            else
            {
                HashNode temp = hashTable[index];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = add;
                add.Next = null;

            }



        }
       
        

    }
}
