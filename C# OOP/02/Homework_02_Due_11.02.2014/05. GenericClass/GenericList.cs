namespace _05.GenericClass
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T>
        where T : IComparable, IComparable<T>
    {
        // fields

        private int capacity;
        private int indexNext;
        private T[] data;

        // properties

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public int IndexNext
        {
            get { return this.indexNext; }
            private set { this.indexNext = value; }
        }

        //public T[] Data
        //{
        //    get { return this.data; }
        //    private set { this.data = value; }
        //}

        // constructors

        public GenericList()
            : this(16)
        {
        }

        public GenericList(int cap)
        {
            this.Capacity = cap;
            this.IndexNext = 0;
            this.data = new T[cap];
        }

        // indexer

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < this.Capacity)
                {
                    return this.data[index];
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Cannot access outside of GenericList range!");
                }
            }
            set
            {
                if (index >= 0 && index < this.Capacity)
                {
                    this.data[index] = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Cannot write outside of GenericList range!");
                }
            }
        }

        // method for adding elements

        public void Add(T element)
        {
            if (this.IndexNext >= this.Capacity)
            {
                // capacity reached, list must expand
                // Auto-grow functionality from Problem 06

                this.Capacity *= 2;

                T[] tempData = new T[this.Capacity];

                IndexNext = 0;

                for (int ind = 0; ind < this.data.Length; ind++)
                {
                    tempData[indexNext] = this[ind];
                    indexNext++;
                }

                this.data = tempData;
            }

            this[IndexNext] = element;
            this.IndexNext++;
        }

        // method for removing elements

        public void Remove(int position)
        {
            if (position >= 0 && position < this.IndexNext)
            {
                int miniIndex = 0;

                for (int index = 0; index < IndexNext; index++)
                {
                    if (index != position)
                    {
                        this[miniIndex] = this[index];
                        miniIndex++;
                    }
                }
            }

            this.IndexNext--;

            if (this.IndexNext < 0)
            {
                this.IndexNext = 0;
            }
        }

        // method for inserting elements

        public void Insert(T element, int position)
        {
            if (position >= 0 && position < this.IndexNext)
            {
                if (this.IndexNext == 0)
                {
                    this.Add(element);
                }
                else
                {
                    T temp = this[position];
                    this[position] = element;

                    for (int i = position + 1; i < this.IndexNext; i++)
                    {
                        T tempItem = this[i];
                        this[i] = temp;
                        temp = tempItem;
                    }
                }

                this.indexNext++;
            }
            else if (position >= this.IndexNext)
            {
                this.Add(element);
            }
            else if (position < 0)
            {
                this.Insert(element, 0);
            }
        }

        // find element by value

        public int Find(T element)
        {
            if (this.IndexNext == 0)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < this.IndexNext; i++)
                {
                    if (this[i].ToString() == element.ToString())
                    {
                        return i;
                    }
                }

                return -1;
            }
        }

        // clear list

        public void Clear()
        {
            this.data = new T[16];
            this.IndexNext = 0;
        }

        // ToString() overload

        public string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.IndexNext; i++)
            {
                result.Append(this[i].ToString() + ' ');
            }

            if (result.Length > 0)
            {
                result.Remove(result.Length - 1, 1);
            }

            return result.ToString();
        }

        // solutions for <Problem 07>

        public T Min<T>()
        {
            dynamic result = this.data.Min();
            return result;
        }

        public T Max<T>()
        {
            dynamic result = this.data.Max();
            return result;
        }
    }
}
