using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazar
{
    interface IStack
    {
        void Push(object item);
        object Pop();
        object Peek();
        bool IsEmpty();
    }
}
