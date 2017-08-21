using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Classes
{
    public class CustomNewList<T> : IEnumerable
    {
        private T[] array;
        private int count;
        private int capacity;

        public CustomNewList()
        {
            this.capacity = Capacity;
            this.count = Count;
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public void GetCapacity()
        {
            if(Capacity == 0)
            {
                Capacity += 4;
            }
            else if(Count == Capacity)
            {
                Capacity *= 2;
            }
        }

        public void Add(T item)
        {
            GetCapacity();
            T[] newArray = new T[Capacity];
            newArray = NewArrays(newArray);            
            newArray[Count] = item;
            array = newArray;
            Count++;
        }

        private T[] NewArrays(T[] newArray)
        {
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        public void Remove(T item)
        {
            T[] newArray = new T[Count];
            int counter = 0;
            int minusCounter = 0;
            for(int number = 0; number < Count; number++)
            {
                if(array[number].Equals(item))
                {
                    minusCounter++;
                }
                else
                {
                    newArray[counter] = array[number];
                    counter++;
                }
            }
            Count -= minusCounter;
            newArray = ShiftArray(newArray);
            array = newArray;   
        }

        public T[] ShiftArray(T[] nextArray)
        {
            T[] temp = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                temp[i] = nextArray[i];
            }

            return temp;
        }

        public override string ToString()
        {
            string newString = "";
            StringBuilder combinedString = new StringBuilder();
           
            for(int i = 0; i < this.Count; i++)
            {
                combinedString.AppendFormat($"{array[i]}", array[i]);
            }
            newString += combinedString;

            return newString;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return i;
            }
        }
    }
}
