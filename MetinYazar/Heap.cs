using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazar
{
    public class Heap
    {
        public int currentSize { get; set; }
        public NodeHeap[] heapWord = new NodeHeap[50];

        public bool Insert(Word word)
        {
            NodeHeap newNodeHeap = new NodeHeap(word);
            heapWord[currentSize] = newNodeHeap;
            MoveToUp(currentSize++);
            return true;

        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            NodeHeap bottom = heapWord[index];
            while (index > 0 && heapWord[parent].word.frequency < bottom.word.frequency)
            {
                heapWord[index] = heapWord[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapWord[index] = bottom;

        }
        public NodeHeap RemoveMax() 
        {
            NodeHeap root = heapWord[0];
            heapWord[0] = heapWord[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            NodeHeap top = heapWord[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && heapWord[leftChild].word.frequency < heapWord[rightChild].word.frequency)
                {
                    largerChild = rightChild;
                }
                else
                {
                    largerChild = leftChild;
                }
                if (top.word.frequency >= heapWord[largerChild].word.frequency)
                    break;
                heapWord[index] = heapWord[largerChild];
                index = largerChild;
            }
            heapWord[index] = top;
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }

        public Word[] Sort(Word[] wordss)
        {
            Heap h = new Heap();
            Word[] sorted = new Word[wordss.Length];
            foreach (var item in wordss)
            {
                h.Insert(item);
            }
            int i = 0;
            while (!h.IsEmpty())
            {
                sorted[i++] = h.RemoveMax().word;
            }
            return sorted;
        }

    }
}
