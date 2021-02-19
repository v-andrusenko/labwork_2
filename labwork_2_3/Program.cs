using System;
using System.Collections;
using System.Diagnostics;

namespace labwork_2_3
{
    static class Program
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.ArrayLength];

            for (int i = 0; i < list.ArrayLength; i++)
            {
                array[i] = list[i];
            }

            return array;
        }
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

            for (int i = 0; i < num1; i++)
            {
                mylist[i] = rand.Next(0, 10);
            }
            Console.WriteLine($"Общее количество элементов: {mylist.ArrayLength}");
            Console.Write("Введите элемент, который нужно добавить: ");
            int num2 = int.Parse(Console.ReadLine());

            mylist.Add(num2);
            Console.WriteLine($"\nОбщее количество элементов после добавления: {mylist.ArrayLength}");
            for (int i = 0; i < mylist.ArrayLength; i++)
            {
                Console.WriteLine($"Элемент номер {i}: {mylist[i]}");
            }

            var array = mylist.GetArray();

            Console.WriteLine("\nСодержимое после расширяющего метода GetArray");
            for (int i=0;i<array.Length;i++)
            {
                Console.WriteLine($"Элемент номер {i}: {array[i]}");
            }
            Console.ReadKey();
        }
    }
}

