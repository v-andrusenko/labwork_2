using System;
using System.Collections;
using System.Diagnostics;

namespace labwork_2_1
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
            Array.Resize(ref myList, myList.Length+1);
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите изначальное количество элементов: ");
            int num1;
            do
            {
                num1 = int.Parse(Console.ReadLine());
                if (num1 < 0) Console.Write("Введите корректное количество (больше или равно 0): ");
            }
            while (num1 < 0);
            MyList<int> mylist = new MyList<int>(num1);
            Random rand = new Random();

            for (int i=0; i<num1;i++)
            {
                mylist[i] = rand.Next(0,10);
            }
            Console.WriteLine($"Общее количество элементов: {mylist.ArrayLength}");
            Console.Write("Введите элемент, который нужно добавить: ");
            int num2 = int.Parse(Console.ReadLine());

            mylist.Add(num2);
            Console.WriteLine($"Общее количество элементов после добавления: {mylist.ArrayLength}");
            for (int i = 0; i < mylist.ArrayLength; i++)
            {
                Console.WriteLine($"Элемент номер {i}: {mylist[i]}");
            }

            Console.ReadKey();
        }
    }
}
