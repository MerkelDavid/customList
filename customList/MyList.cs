using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{

    public class MyList<T>: IEnumerable<T>
    {

        private int Capacity;
        private T[] holder;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        public T this[int i]
        {
            get
            {
                if (i <= count)
                {
                    return holder[i];
                }
                else
                {
                    throw new IndexOutOfRangeException("index has not yet been defined");
                }

            }
            set
            {
                if (i <= count)
                {
                    holder[i] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("index has not yet been defined");
                }
             
            }
        }
        public MyList()
        {
            count = 0;
            Capacity = 5;
            holder = new T[Capacity];
        }

        //public MyList(int Count)
        //{
        //    this.Count = Count;
        //    Capacity = Count + 10;
        //    holder = new T[Capacity];
        //}
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return holder[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return holder[i];
            }
        }

        public override string ToString()
        {
            string ListString = "";

            for(int i = 0; i < count; i++)
            {
               string currentValue = Convert.ToString(holder[i]);
                Console.WriteLine(currentValue);
                ListString += currentValue + " ";
            }
            return ListString;
        }

        public void Add(T value)
        {
          if ((Count + 1) > Capacity)
            {
                IncreaseCapacity();
                holder[count] = value;
                count++;
            }
            else
            {
                holder[count] = value;
                count++;
            }
        }

        public bool Remove(T value)
        {
            bool isValueFound = false;

            for(int i = 0; i < count; i++)
            {
                if(holder[i].Equals(value))
                {
                    RemoveAt(i);
                    isValueFound = true;
                    break;
                }
            }

            return isValueFound;
        }

        public void RemoveAt(int index)
        {
            for(int i = index; i < (count-1); i++)
            {
                holder[i] = holder[i + 1];
            }

            DecrementCount();
        }

        //helper functions
        private void DecrementCount()
        {
            count--;
        }
        private void IncreaseCapacity()
        {
            Capacity *= 2;
            ResizeArray();
        }

        private void ResizeArray()
        {
            T[] newArray = new T[Capacity];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = holder[i];
            }

            holder = newArray;
        }

        // T Where: Ienumerable
        //initializer (need Ienumerable,indexer,add)
    }
}
