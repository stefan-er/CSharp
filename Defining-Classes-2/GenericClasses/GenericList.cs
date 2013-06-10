namespace GenericClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T>
        where T : IComparable<T>
    {
        const int DefaultCapacity = 4096;

        private T[] elements;
        private int count;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public GenericList()
            : this(DefaultCapacity)
        { 
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Add(T element)
        {
            if (this.count >= elements.Length)
            {
                T[] newElements = new T[elements.Length * 2];
                for (int i = 0; i < elements.Length; i++)
                {
                    newElements[i] = this.elements[i];
                }
                this.elements = newElements;
            }
            this.elements[count] = element;
            this.count++;
        }

        public T this[int index]
        {
            get 
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }

                T result = elements[index];
                return result;
            }
        }

        public void Remove(int index)
        {
            if (index >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
            }

            for (int i = index; i < this.count - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            this.count--;
        }

        public void Insert(T element, int position)
        {
            if (position >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", position));
            }

            this.count++;
            for (int i = this.count-1; i > position; i--)
            {
                elements[i] = elements[i - 1];
            }
            elements[position] = element;
        }

        public void Clear()
        {
            for (int i = 0; i < this.count; i++)
            {
                elements[i] = default(T);
            }
            this.count = 0;

        }

        public int Find(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (element.CompareTo(elements[i]) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder items = new StringBuilder();
            for (var i = 0; i < this.count; i++)
            {
                items.Append(Convert.ToString(elements[i]));
            }
            return items.ToString();
        }

        public static T Min<T>(GenericList<T> list)
            where T : IComparable<T>
        {
            T smallestElement = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(smallestElement) == -1)
                {
                    smallestElement = list[i];
                }
            }
            return smallestElement;
        }

        public static T Max<T>(GenericList<T> list)
            where T : IComparable<T>
        {
            T biggestElement = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(biggestElement) == 1)
                {
                    biggestElement = list[i];
                }
            }
            return biggestElement;
        }
    }
}
