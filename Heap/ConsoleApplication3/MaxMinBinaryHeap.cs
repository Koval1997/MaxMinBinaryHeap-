using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{    

    public class MaxMinBinaryHeap<T>  where T : IComparable<T>
    {
        List <T> items;
        
        public MaxMinBinaryHeap()
        {
            items = new List<T>();            
        }

        public void HeapBuilder(bool flag, params T[] sourceArray)
        {
            items = sourceArray.ToList();
            for (int i = 0; i < Size; i++)
            {
                if (items.Contains(sourceArray[i])) throw new Exception("Содержит повторяющиеся элементы!");
            }
            for (int i = items.Count / 2; i >= 0; i--)
            {
                heapify(i, flag);
            }
        }

        public int Size
        {
            get
            {
                return items.Count;
            }
        }

        public void Insert(T item, bool flag)
        {
            if (items.Contains(item)) throw new Exception("Есть такой элемент!");            
            items.Add(item);
            for (int i = Size / 2; i >= 0; i--)
            {
                heapify(i,flag);
            }
        }  

        public T Extract(bool flag)
        {
             
            if (items.Count == 0) throw new Exception("Куча пуста!");           
            T resault = items[0];        
            items.RemoveAt(0);
            for (int i = Size / 2; i >= 0; i--)
            {
                heapify(i, flag);
            }
            return resault;
        }

        public void heapify(int i, bool flag)
        {
            int leftIndex = 2 * i + 1;
            int rightIndex = 2 * i + 2;
            int largest = i;

            if (leftIndex < Size)
            {
                if ((items[leftIndex].CompareTo(items[largest]) > 0)^flag)
                    largest = leftIndex;
            }
            if (rightIndex < Size)
            {
                if ((items[rightIndex].CompareTo(items[largest]) > 0)^flag)
                    largest = rightIndex;
            }
            if (largest != i)
            {
                T temp = items[largest];
                items[largest] = items[i];
                items[i] = temp;
                i = largest;
            }
        }      

    }
}
