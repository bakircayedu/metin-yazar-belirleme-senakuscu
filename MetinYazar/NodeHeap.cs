using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazar
{
    public class NodeHeap
    {
        public NodeHeap left;
        public NodeHeap right;
        public Word word;
        public NodeHeap(Word word)
        {
            this.word = word;
            left = null;
            right = null;
            

        }

    }
}
