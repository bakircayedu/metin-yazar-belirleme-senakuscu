﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazar
{
    public class Node
    {
        public object Data;
        public Node Next;
        public Node(object d)
        {
            Data = d;
            Next = null;
        }
    }
}
