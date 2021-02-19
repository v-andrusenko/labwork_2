using System;
using System.Collections.Generic;
using System.Text;

namespace labwork_2_3
{
    class MyList<T>
    {
        private T[] myList;

        public T this[int index]
        {
            get { return myList[index]; }
            set { myList[index] = value; }
        }

        public MyList()
        {
            this.myList = new T[1];
        }

        public MyList(int count)
        {
            this.myList = new T[count];
        }

        public void Add(T item)
        {
            Array.Resize(ref myList, myList.Length + 1);
            myList[myList.Length - 1] = item;
        }

        public int ArrayLength
        {
            get
            {
                return (myList.Length);
            }
        }
    }
}
