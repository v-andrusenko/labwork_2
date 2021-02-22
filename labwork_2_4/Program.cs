using System;

namespace labwork_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ForExample forexample = MyClass<ForExample>.FacrotyMethod();

            Console.ReadKey();
        }
    }

    public class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
    class ForExample
    {
        public ForExample()
        {
            Console.WriteLine("Порождение экземпляра типа ForExample");
        }
    }
}
