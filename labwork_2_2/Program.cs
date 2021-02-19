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
                var index = 0;
                foreach (var m in DictionaryKeys)
                {
                    if (!Equals(m, key))
                    {
                        index++;
                    }
                }

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
            MyDictionary<string,string> myDictionary = new MyDictionary<string,string>();
            myDictionary.Add("a", "Январь");
            myDictionary.Add("2", "Февраль");
            myDictionary.Add("3", "Март");
            myDictionary.Add("4", "Апрель");
            myDictionary.Add("5", "Май");
            myDictionary.Add("6", "Июнь");
            myDictionary.Add("7", "Июль");
            myDictionary.Add("8", "Август");
            myDictionary.Add("9", "Сентябрь");
            myDictionary.Add("10", "Октябрь");
            myDictionary.Add("11", "Ноябрь");
            myDictionary.Add("12", "Декабрь");

            Console.Write("Введите номер месяца: ");
            string num = Console.ReadLine();
            try
            {
                Console.WriteLine($"{num} - это {myDictionary[num]}");
            }
            catch 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ключ {num} не найден в словаре.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
            Console.WriteLine($"\nОбщее количество пар: {myDictionary.DictionaryLength}");
        }
    }
}
