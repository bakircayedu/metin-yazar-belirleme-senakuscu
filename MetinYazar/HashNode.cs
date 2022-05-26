using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazar
{
    public class HashNode
    {
        public HashNode Next { get; set; }
        public int Frequency { get; set; }
        public Word Data { get; set; }
        public int key;
    }
}
