using System;
using System.Collections;
using System.Collections.Generic;

namespace labwork_2_2
{
    class MyDictionary <K, V>
    {
        private K[] DictionaryKeys;
        
        private V[] DictionaryValues;

        public MyDictionary()
        {
            DictionaryKeys = Array.Empty<K>();
            DictionaryValues = Array.Empty<V>();
        }


        public void Add(K key, V value)
        {
            Array.Resize(ref DictionaryKeys, DictionaryKeys.Length+1);
            DictionaryKeys[DictionaryKeys.Length - 1] = key;

            Array.Resize(ref DictionaryValues, DictionaryValues.Length + 1);
            DictionaryValues[DictionaryValues.Length - 1] = value;
        }

        public V this[K key]
        {
            get
            {
                var num = Convert.ToInt32(key);
                var index = Convert.ToInt32(DictionaryKeys[num - 1]);
                return DictionaryValues[index];
            }
        }
        public int DictionaryLength
        {
            get
            {
                return (DictionaryValues.Length);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "Январь");
            myDictionary.Add(2, "Февраль");
            myDictionary.Add(3, "Март");
            myDictionary.Add(4, "Апрель");
            myDictionary.Add(5, "Май");
            myDictionary.Add(6, "Июнь");
            myDictionary.Add(7, "Июль");
            myDictionary.Add(8, "Август");
            myDictionary.Add(9, "Сентябрь");
            myDictionary.Add(10, "Октябрь");
            myDictionary.Add(11, "Ноябрь");
            myDictionary.Add(12, "Декабрь");

            Console.Write("Введите номер месяца: ");
            int num;
            do
            {
                num = int.Parse(Console.ReadLine());
            }
            while (num <= 0 || num > 13);
            Console.WriteLine($"{num} - это {myDictionary[num-1]}");
            Console.WriteLine($"\nОбщее количество пар: {myDictionary.DictionaryLength}");
        }
    }
}
