using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazar
{
    public class Stack
    {
        public Node Head = null;
        public int count = 0;


        public bool IsEmpty()
        {
            return Head == null ? true : false;
        }

        public object Peek()
        {
            if (Head == null)
            {
                return null;

            }
            return Head.Data;
        }

        public object Pop()
        {
            Node temp;
            if (Head == null)
            {
                return null;

            }
            temp = Head;
            Head = Head.Next;
            return temp.Data;
        }

        public void Push(object item)
        {
            Node newNode = new Node(item);
            if (Head == null)
            {
                newNode.Next = null;
            }
            else
            {
                newNode.Next = Head;
            }
            Head = newNode;
            count++;
        }


    }
}
